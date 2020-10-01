using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HarryPotter.Models
{
    public class HouseObjects
    {
        [JsonPropertyName("_id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string HouseName { get; set; }

        [JsonPropertyName("mascot")]
        public string Mascot { get; set; }

        [JsonPropertyName("headOfHouse")]
        public string HeadOfHouse { get; set; }

        [JsonPropertyName("houseGhost")]
        public string HouseGhost { get; set; }

        [JsonPropertyName("founder")]
        public string Founder { get; set; }

        [JsonPropertyName("__v")]
        public string V { get; set; }

        [JsonPropertyName("school")]
        public string School { get; set; }

        [JsonPropertyName("members")]
        public string[] Members { get; set; }

        [JsonPropertyName("values")]
        public string[] Values { get; set; }

        [JsonPropertyName("colors")]
        public string[] Colors { get; set; }

        
    }
}
