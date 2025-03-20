using ZaloSDK.Articles;

namespace ZaloSDK;

public class ZaloClient
{
    private readonly string _accessToken;
    private readonly HttpClient _client;
    public ZaloClient(string access_token)
    {
        _accessToken = access_token;
        var client = new HttpClient
        {
            BaseAddress = new Uri("https://openapi.zalo.me/v2.0/")
        };
        client.DefaultRequestHeaders.Add("access_token", _accessToken);
        _client = client;
    }

    public Task<ZaloResult<Media>?> GetSliceArticleAsync(int offset, string type, int limit) => ZaloArticle.GetSliceArticleAsync(_client, offset, limit, type);

    public Task<ZaloResult<ArticleDetail>?> GetArticleDetailAsync(string id) => ZaloArticle.GetArticleDetailAsync(_client, id);
}
