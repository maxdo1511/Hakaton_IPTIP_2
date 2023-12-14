
using Google.Protobuf.Reflection;
using Grpc.Net.Client;
using MireaCore.Configs;

namespace MireaCore.Communicators;

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
        
}