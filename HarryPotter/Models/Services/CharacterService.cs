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
    public class CharacterService : ICharacters
    {
        private IConfiguration _config;
        private readonly HttpClient _client = new HttpClient();
        private string baseUrl = @"https://www.potterapi.com/v1";

        public CharacterService(IConfiguration config, HttpClient client)
        {
            _config = config;
            _client = client;
        }

        public async Task<List<CharacterObject>> GetAllCharacters()
        {
            string route = "characters";

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await _client.GetStringAsync($"{ baseUrl }/{ route }?key={_config["PotterApiKey"]}");

            List<CharacterObject> characterObjects = JsonConvert.DeserializeObject<List<CharacterObject>>(response);

            return characterObjects;
        }



        public async Task<CharacterObject> GetCharacterById(string CharacterId)
        {
            string route = $"characters/{CharacterId}";

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await _client.GetStringAsync($"{ baseUrl }/{ route }?key={_config["PotterApiKey"]}");

            CharacterObject characterObject = JsonConvert.DeserializeObject<CharacterObject>(response);

            return characterObject;

        }

        public async Task<List<CharacterObject>> GetAllCharactersInAHouse(string house)
        {
            string route = "characters";

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await _client.GetStringAsync($"{ baseUrl }/{ route }?key={_config["PotterApiKey"]}");

            List<CharacterObject> characterObjects = JsonConvert.DeserializeObject<List<CharacterObject>>(response);

            
            var queryObject = characterObjects.Where(c => c.House == house).ToList();
             
            return queryObject;

        }
    }
}
