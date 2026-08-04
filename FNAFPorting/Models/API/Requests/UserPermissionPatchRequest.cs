using FNAFPorting.Models.Supabase.Tables;
using Newtonsoft.Json;

namespace FNAFPorting.Models.API.Requests;

public class UserPermissionPatchRequest
{
    [JsonProperty("role")] public ESupabaseRole? Role;
    [JsonProperty("canExportUEFN")] public bool? CanExportUEFN;
    [JsonProperty("isMuted")] public bool? IsMuted;
}