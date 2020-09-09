using Newtonsoft.Json;

namespace WebApiPractice.Models
{
    public abstract class Resourсe : Link
    {
        [JsonIgnore]
        public Link Self { get; set; }
    }
}