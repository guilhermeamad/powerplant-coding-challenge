﻿using System.Text.Json.Serialization;

namespace PowerPlant.Models.Views
{
    public class Fuels
    {
        [JsonPropertyName("gas(euro/MWh)")]
        public double Gas { get; set; }

        [JsonPropertyName("kerosine(euro/MWh)")]
        public double Kerosine { get; set; }

        [JsonPropertyName("co2(euro/ton)")]
        public double Co2 { get; set; }

        [JsonPropertyName("wind(%)")]
        public double Wind { get; set; }
    }
}
