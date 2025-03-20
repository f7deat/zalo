using System.Text.Json;

namespace ZaloSDK.Articles;

public class ZaloArticle
{
    public static async Task<ZaloResult<Media>?> GetSliceArticleAsync(HttpClient client, int offset, int limit, string type)
    {
        try
        {
            var response = await client.GetStreamAsync($"article/getslice?offset={offset}&limit={limit}&type={type}");
            return await JsonSerializer.DeserializeAsync<ZaloResult<Media>>(response);
        }
        catch (Exception ex)
        {
            return new ZaloResult<Media>
            {
                Error = 1,
                Message = ex.ToString()
            };
        }
    }

    public static async Task<ZaloResult<ArticleDetail>?> GetArticleDetailAsync(HttpClient client, string id)
    {
        try
        {
            var response = await client.GetStreamAsync($"article/getdetail?id={id}");
            return await JsonSerializer.DeserializeAsync<ZaloResult<ArticleDetail>>(response);
        }
        catch (Exception ex)
        {
            return new ZaloResult<ArticleDetail>
            {
                Error = 1,
                Message = ex.ToString()
            };
        }
    }
}
