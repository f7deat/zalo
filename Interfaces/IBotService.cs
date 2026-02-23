using ZaloSDK.Bots;
using ZaloSDK.Bots.Models;

namespace ZaloSDK.Interfaces;

public interface IBotService
{
    Task<BotResult<GetMeResult>?> GetMeAsync();
    Task<BotResult<object>?> SendMessageAsync(string chatId, string text);
}
