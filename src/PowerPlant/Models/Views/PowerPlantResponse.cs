using System.Text.Json.Serialization;

namespace PowerPlant.Models.Views
{
    public class PowerPlantResponse
    {
        public string Name { get; set; }

        [JsonPropertyName("p")]
        public double Power { get; set; }
    }
}
