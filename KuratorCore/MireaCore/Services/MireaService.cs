using Grpc.Core;
using MireaCore.Communicators;
using MireaCore.RequestSenders;

namespace MireaCore.Services;

public class MireaService : MireaCore.MireaCoreBase
{
    private DatabaseCommunicator _databaseCommunicator;
    private MireaRequestSender _mireaRequestSender;
    public MireaService(DatabaseCommunicator databaseCommunicator,  MireaRequestSender mireaRequestSender)
    {
        _databaseCommunicator = databaseCommunicator;
        _mireaRequestSender = mireaRequestSender;
    }
    public async override Task<SignInResponse> SignIn(SignInRequest request, ServerCallContext context)
    {
        var result = await _mireaRequestSender.SignIn(request.Email,"http://94.103.83.231:5186/mirea/signIn");
        var res2 = await _databaseCommunicator.AddToken(request.Email,result.email);
        if (res2.Result)
        {
            return await Task.FromResult(new SignInResponse(){Result = true,Error = ""});
        }
        return await Task.FromResult(new SignInResponse(){Result = false,Error = res2.Error});
    }

    public async override Task<GetGroupsResponse> GetGroups(GetGroupsRequest request, ServerCallContext context)
    {
        var result = await _mireaRequestSender.GetGroups(System.Environment.GetEnvironmentVariable("token"),"http://94.103.83.231:5186/mirea/user/groups");
        List<Group> groups = new List<Group>();
        foreach (var VARIABLE in result)
        {
            List<GetUserResponse> users = new List<GetUserResponse>();
            foreach (var VARIABLE2 in VARIABLE.users)
            {
                users.Add(new GetUserResponse(){Email = VARIABLE2.email,FirstName = VARIABLE2.firstName, SecondName = VARIABLE2.secondName, StudyGroup = VARIABLE2.studyGroup});
            }

            var currgroup = new Group()
            {
                GroupName = VARIABLE.groupName

            };
            currgroup.Users.AddRange(users);
            groups.Add(currgroup);
            
        }

        var resp = new GetGroupsResponse();
        resp.Groups.AddRange(groups);
        return await Task.FromResult(resp);
    }

    public async override Task<GetUserResponse> GetUser(GetUserRequest request, ServerCallContext context)
    {
        var result = await _mireaRequestSender.GetUserInfo(request.Email,System.Environment.GetEnvironmentVariable("token"),"http://94.103.83.231:5186/mirea/user/userdata");

        return await Task.FromResult(new GetUserResponse()
        {
            Email = result.email,
            FirstName = result.firstName,
            SecondName = result.secondName,
            StudyGroup = result.studyGroup
        });
    }
    public async override Task<GetUsersResponse> GetUsers(GetUserRequest request, ServerCallContext context)
    {
        var result = await _mireaRequestSender.GetUsersInfo(System.Environment.GetEnvironmentVariable("token"), "http://94.103.83.231:5186/mirea/user/usersdata");
        List<GetUserResponse> resp = new List<GetUserResponse>();
        foreach (var VARIABLE in result)
        {
            resp.Add(new GetUserResponse()
            {
                Email = VARIABLE.email,
                FirstName = VARIABLE.firstName,
                SecondName = VARIABLE.secondName,
                StudyGroup = VARIABLE.firstName
            });
        }

        var response = new GetUsersResponse();
        response.Users.AddRange(resp);
        return await Task.FromResult(response);
    }

    public async override Task<GetUserResponse> GetUserByEmail(GetUser1Request request, ServerCallContext context)
    {
        var result = await _mireaRequestSender.GetUserInfo(request.Token,$"http://94.103.83.231:5186/mirea/user/userdata/{request.Email}");

        return await Task.FromResult(new GetUserResponse()
        {
            Email = result.email,
            FirstName = result.firstName,
            SecondName = result.secondName,
            StudyGroup = result.studyGroup
        });
    }
}