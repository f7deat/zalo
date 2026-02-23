using System.Text.Json.Serialization;

namespace ZaloSDK.Bots.Models;

public class GetMeResult
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = default!;
    [JsonPropertyName("account_name")]
    public string AccountName { get; set; } = default!;
    [JsonPropertyName("account_type")]
    public string AccountType { get; set; } = default!;
    [JsonPropertyName("can_join_groups")]
    public bool CanJoinGroups { get; set; }
}
