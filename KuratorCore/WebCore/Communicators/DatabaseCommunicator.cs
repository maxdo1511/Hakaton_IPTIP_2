using Grpc.Net.Client;
using WebCore.Configs;

namespace WebCore.Communicators;

public class DatabaseCommunicator
{
    public readonly DatabaseCore.DatabaseCoreClient _databaseClient;

    public DatabaseCommunicator()
    {
        var config = ConfigReader.GetGrpc("Database").Result;


        GrpcChannel channel = GrpcChannel.ForAddress($"http://{config.Host}:{config.Port}");
        _databaseClient = new DatabaseCore.DatabaseCoreClient(channel);
    }

    public async Task<GetAllUsersResponse> GetAllUsers()
    {
        return await _databaseClient.GetAllUsersAsync(new GetAllUsersRequest());
    }

    public async Task<GetCuratorResponse> GetCurator(string email)
    {
        return await _databaseClient.GetCuratorAsync(new GetCuratorRequest() { Email = email });
    }

    public async Task<GetCuratorsByRoleResponse> GetCurators(string role)
    {
        return await _databaseClient.GetCuratorsByRoleAsync(new GetCuratorsByRoleRequest() { Role = role });
    }

    public async Task<GetSortedCuratorsResponse> GetSortedCurators(string sortBy)
    {
        return await _databaseClient.GetSortedCuratorsAsync(new GetSortedCuratorsRequest() { SortBy = sortBy });
    }

    public async Task<AddCuratorResponse> AddCurator(string email, string role)
    {
        return await _databaseClient.AddCuratorAsync(new AddCuratorRequest(){Email = email,Role = role});
    }

    public async Task<AddMireaTokenResponse> AddToken(string email, string token)
    {
        return await _databaseClient.AddMireaTokenAsync(new AddMireaTokenRequest(){Token = token,Email = email});
    }

    public async Task<SetContactResponse> SetContact(string field, string value, string editor_email, string recipient_email)
    {
        return await _databaseClient.SetContactAsync(new SetContactRequest(){Field = field,Value = value,EditorEmail = editor_email,RecipientEmail = recipient_email});
    }

    public async Task<CreateCuratorPairResponse> CreateCuratorPair(string teacher_email,string student_email, string group)
    {
        return await _databaseClient.CreateCuratorPairAsync(new CreateCuratorPairRequest(){Group = group,StudentEmail = student_email,TeacherEmail = teacher_email});
    }

    public async Task<SetCuratorRatingResponse> SetCuratorRating(string field, string editorEmail, string recipientEmail,double value)
    {
        return await _databaseClient.SetCuratorRatingAsync(new SetCuratorRatingRequest
        {
            Field = field,
            Value = value,
            EditorEmail = editorEmail,
            RecipientEmail = recipientEmail
        });
    }

    public async Task<GetCuratorGraphicResponse> GetCuratorGraphic(string email)
    {
        return await _databaseClient.GetCuratorGraphicAsync(new GetCuratorGraphicRequest(){Email = email});
    }

    
}