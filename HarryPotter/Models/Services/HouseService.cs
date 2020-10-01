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
    public class HouseService : IHouses
    {
        //public string HouseName { get; set; }        
        
        private IConfiguration _config;
        private readonly HttpClient _client = new HttpClient();
        private string baseUrl = @"https://www.potterapi.com/v1";

        public HouseService(IConfiguration config, HttpClient client)
        {
            _config = config;
            _client = client;
        }

        public async Task<string> GetAllHouses()
        {
            string route = "houses";

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await _client.GetStringAsync($"{ baseUrl }/{ route }" + _config["PotterApiKey"]);

            string HouseName = JsonConvert.DeserializeObject<string>(response);

            return HouseName;
        }

        public Task<string> GetHouseById()
        {
            throw new NotImplementedException();
        }
    }
}
