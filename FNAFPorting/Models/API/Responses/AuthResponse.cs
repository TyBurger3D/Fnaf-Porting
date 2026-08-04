using Newtonsoft.Json;

namespace FNAFPorting.Models.API.Responses;

public class AuthResponse
{
    [JsonProperty("supabaseUrl")] public string SupabaseURL;
    [JsonProperty("supabaseAnonKey")] public string SupabaseAnonKey;
}