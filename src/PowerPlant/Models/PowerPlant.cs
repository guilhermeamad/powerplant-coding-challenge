using System.Text.Json.Serialization;

namespace PowerPlant.Models
{
    public class PowerPlant
    {
        public string Name { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PowerPlantType Type { get; set; }
        public double Efficiency { get; set; }
        public int Pmin { get; set; }
        public int Pmax { get; set; }
    }

    public enum PowerPlantType
    {
        GasFired,
        TurboJet,
        WindTurbine,
    }
}
