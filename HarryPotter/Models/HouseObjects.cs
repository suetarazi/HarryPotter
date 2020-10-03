using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace HarryPotter.Models
{
    public class HouseObject
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string HouseName { get; set; }

        [JsonProperty("mascot")]
        public string Mascot { get; set; }

        [JsonProperty("headOfHouse")]
        public string HeadOfHouse { get; set; }

        [JsonProperty("houseGhost")]
        public string HouseGhost { get; set; }

        [JsonProperty("founder")]
        public string Founder { get; set; }

        [JsonProperty("__v")]
        public string V { get; set; }

        [JsonProperty("school")]
        public string School { get; set; }

        [JsonPropertyName("members")]
        public string[] Members { get; set; }

        [JsonPropertyName("values")]
        public string[] Values { get; set; }

        [JsonPropertyName("colors")]
        public string[] Colors { get; set; }

        
    }
}
