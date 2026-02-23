namespace ZaloSDK.Bots;

public class BotResult<T>
{
    public bool Ok { get; set; }
    public T? Result { get; set; }
}