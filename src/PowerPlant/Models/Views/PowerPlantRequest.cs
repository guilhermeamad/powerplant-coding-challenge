using System.Text.Json.Serialization;

namespace PowerPlant.Models.Views
{
    public class PowerPlantRequest
    {
        public int Load { get; set; }

        public Fuels Fuels { get; set; }

        [JsonPropertyName("powerplants")]
        public IEnumerable<PowerPlant> PowerPlants { get; set; }
    }
}
