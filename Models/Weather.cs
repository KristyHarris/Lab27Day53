using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Lab27_Day53.Models
{
    public class Weather
    {
        public string Name { get; set; }

        [DisplayName("Elevation")]
        public string Elev { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public string Date { get; set; }

        [DisplayName("Temperature")]
        public string Temp { get; set; }

        [JsonPropertyName("Dewp")]
         public string Dewpoint { get; set; }

        [JsonPropertyName("Relh")]
        [DisplayName("Relative Humidity")]
        public string RelativeHumidity { get; set; }

        [JsonPropertyName("Weather")]
        [DisplayName("Current Conditions")]
        public string CurrentCondition { get; set; }

        public string Visibility { get; set; }


        [DisplayName("Barometric Pressure")]
        public string SLP { get; set; }

        public string State { get; set; }

        [DisplayName("Wind Chill")]
        public string WindChill { get; set; }

       //[DisplayName("Forecast Period")]
       //public string[] StartPeriodName { get; set; }

       //public string[] Data { get; set; }
    }
}
