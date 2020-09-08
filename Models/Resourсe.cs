using Newtonsoft.Json;

namespace WebApiPractice.Models
{
    public abstract class Resourсe
    {
        [JsonProperty(Order = -2)]
        public string Href { get; set; }
    }
}