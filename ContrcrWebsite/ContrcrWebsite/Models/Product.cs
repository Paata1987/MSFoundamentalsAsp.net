using System.Text.Json;
using System.Text.Json.Serialization;

namespace ContrcrWebsite.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string maker { get; set; }


        [JsonPropertyName("img")]
        public string img { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string description { get; set; }
        public int[] Rating { get; set; }

        public override string ToString()=> JsonSerializer.Serialize(this);
     
    }
}
