using System.Text.Json.Serialization;

namespace ZaloSDK;

public class ZaloResult<T> where T : class
{
    [JsonPropertyName("data")]
    public T? Data { get; set; }
    [JsonPropertyName("total")]
    public int Total { get; set; }
    [JsonPropertyName("error")]
    public int Error { get; set; }
    [JsonPropertyName("message")]
    public string Message { get; set; } = default!;
}
