using Newtonsoft.Json;

namespace ABCPublication.Web.Models
{
    public class JsonRoot
    {
        [JsonProperty("preface")]
        public WebPageViewModel Preface { get; set; }

        [JsonProperty("table-of-contents")]
        public WebPageViewModel TableOfContents { get; set; }

        [JsonProperty("a-scandal-in-bohemia")]
        public WebPageViewModel AScandalInBohemia { get; set; }

        [JsonProperty("bohemia-chapter-1")]
        public WebPageViewModel BohemiaChapter1 { get; set; }

        [JsonProperty("bohemia-chapter-2")]
        public WebPageViewModel BohemiaChapter2 { get; set; }

        [JsonProperty("bohemia-chapter-3")]
        public WebPageViewModel BohemiaChapter3 { get; set; }
    }
}
