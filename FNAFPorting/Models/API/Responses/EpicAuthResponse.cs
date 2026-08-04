using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace FNAFPorting.Models.API.Responses;

public class EpicAuthResponse
{
    [J("access_token")] public string Token;
    [J("expires_at")] public DateTime ExpiresArt;
}