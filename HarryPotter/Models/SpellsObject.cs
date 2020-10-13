using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarryPotter.Models
{
    public class SpellsObject
    {
        [JsonProperty("_id")]
        public string SpellId { get; set; }

        [JsonProperty("spell")]
        public string SpellName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("effect")]
        public string Effect { get; set; }
    }
}
