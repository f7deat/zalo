using System.Text.Json.Serialization;

namespace ZaloSDK.Articles;

public class Article
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = default!;
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;
    [JsonPropertyName("title")]
    public string Title { get; set; } = default!;
    [JsonPropertyName("status")]
    public string Status { get; set; } = ZaloStatus.Show;
    [JsonPropertyName("create_date")]
    public long CreateDate { get; set; }
    [JsonPropertyName("update_date")]
    public long? UpdateDate { get; set; }
    [JsonPropertyName("total_view")]
    public int TotalView { get; set; }
    [JsonPropertyName("thumb")]
    public string Thumbnail { get; set; } = default!;
    [JsonPropertyName("link_view")]
    public string LinkView { get; set; } = default!;
    [JsonPropertyName("total_share")]
    public int TotalShare { get; set; }
}

public class Media
{
    [JsonPropertyName("medias")]
    public List<Article>? Medias { get; set; }
}

public class ArticleCover
{
    [JsonPropertyName("cover_type")]
    public string CoverType { get; set; } = "photo";
    [JsonPropertyName("photo_url")]
    public string PhotoUrl { get; set; } = default!;
    [JsonPropertyName("status")]
    public string Status { get; set; } = ZaloStatus.Show;
}

public class ArticleDetail
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = default!;
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;
    [JsonPropertyName("title")]
    public string Title { get; set; } = default!;
    [JsonPropertyName("status")]
    public string Status { get; set; } = default!;
    [JsonPropertyName("author")]
    public string? Author { get; set; }
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }
    [JsonPropertyName("cover")]
    public ArticleCover? Cover { get; set; }
    [JsonPropertyName("cite")]
    public ArticleCite? Cite { get; set; }
    [JsonPropertyName("body")]
    public List<ArticleBody>? Body { get; set; }
}

public class ArticleBody
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = BodyType.Text;
    [JsonPropertyName("content")]
    public string? Content { get; set; }
    [JsonPropertyName("url")]
    public string? Url { get; set; }
    [JsonPropertyName("caption")]
    public string? Caption { get; set; }
    [JsonPropertyName("thumb")]
    public string? Thumbnail { get; set; }
}

public class ArticleCite
{
    [JsonPropertyName("url")]
    public string? Url { get; set; }
    [JsonPropertyName("label")]
    public string? Label { get; set; }
}

public class BodyType
{
    public const string Text = "text";
    public const string Image = "image";
    public const string Video = "video";
    public const string Product = "product";
}