using Newtonsoft.Json;

namespace ABCPublication.Web.Models
{
    public class WebPageViewModel
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("content")]
        public List<string> Content { get; set; }

        [JsonProperty("navigation")]
        public List<Navigation> Navigation { get; set; }
    }
}