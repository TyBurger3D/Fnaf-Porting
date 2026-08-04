using System.Threading.Tasks;
using FNAFPorting.Models.API.Base;
using FNAFPorting.Models.API.Responses;
using RestSharp;

namespace FNAFPorting.Models.API;

public class RepositoryAPI(RestClient client) : APIBase(client)
{
    public const string REPOSITORY_URL = "https://raw.githubusercontent.com/Bmarquez1997/FNAFPorting/refs/heads/main/Repository.json";
    public const string MAPPINGS_URL = "https://raw.githubusercontent.com/Bmarquez1997/FNAFPorting/refs/heads/main/Mappings.json";
    
    public async Task<RepositoryResponse?> GetRepositoryAsync(string url = REPOSITORY_URL)
    {
        return await ExecuteAsync<RepositoryResponse>(url);
    }
    
    public async Task<MappingsResponse[]?> Mappings()
    {
        return await ExecuteAsync<MappingsResponse[]>(MAPPINGS_URL);
    }
}
