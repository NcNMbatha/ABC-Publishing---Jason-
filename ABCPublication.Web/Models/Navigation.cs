using Newtonsoft.Json;

namespace ABCPublication.Web.Models
{
    public class Navigation
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("section")]
        public string Section { get; set; }
    }
}
