using HarryPotter.Models.Interfaces;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HarryPotter.Models.Services
{
    public class SpellsService : ISpells
    {
        private IConfiguration _config;
        private HttpClient _client = new HttpClient();
        private string baseUrl = @"https://www.potterapi.com/v1";

        public SpellsService(IConfiguration config, HttpClient client)
        {
            _config = config;
            _client = client;
        }

        public async Task<List<SpellsObject>> GetAllSpells()
        {
            string route = "spells";

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await _client.GetStringAsync($"{ baseUrl }/{ route }?key={_config["PotterApiKey"]}");

            List<SpellsObject> spellsObjects = JsonConvert.DeserializeObject<List<SpellsObject>>(response);

            return spellsObjects;
        }
    }
}
