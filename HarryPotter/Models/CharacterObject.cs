using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarryPotter.Models
{
    public class CharacterObject
    {
        [JsonProperty("_Id")]
        public string CharacterId { get; set; }
        
        [JsonProperty("name")]
        public string CharacterName { get; set; }
        
        [JsonProperty("role")]
        public string Role { get; set; }
        
        [JsonProperty("house")]
        public string House { get; set; }

        [JsonProperty("school")]
        public string School { get; set; }
        
        [JsonProperty("bloodStatus")]
        public string BloodStatus { get; set; }
        
        [JsonProperty("species")]
        public string Species { get; set; }

    }
}
