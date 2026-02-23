using Microsoft.Extensions.Options;
using System.Net.Http.Json;
using ZaloSDK.Bots.Models;
using ZaloSDK.Interfaces;
using ZaloSDK.Options;

namespace ZaloSDK.Bots;

public class BotService(HttpClient _client, IOptions<ZaloOptions> options) : IBotService
{
    private readonly ZaloOptions Options = options.Value;

    public async Task<BotResult<GetMeResult>?> GetMeAsync()
    {
        var entrypoint = $"https://bot-api.zaloplatforms.com/bot{Options.BOT_TOKEN}/getMe";
        var response = await _client.PostAsJsonAsync(entrypoint, new { });
        return await response.Content.ReadFromJsonAsync<BotResult<GetMeResult>>();
    }

    public async Task<BotResult<object>?> SendMessageAsync(string chatId, string text)
    {
        var entrypoint = $"https://bot-api.zaloplatforms.com/bot{Options.BOT_TOKEN}/sendMessage";
        var response = await _client.PostAsJsonAsync(entrypoint, new
        {
            chat_id = chatId,
            text
        });
        return await response.Content.ReadFromJsonAsync<BotResult<object>>();
    }
}
