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

        public async Task<List<HouseObject>> GetAllHouses()
        {
            string route = "houses";

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await _client.GetStringAsync($"{ baseUrl }/{ route }?key={_config["PotterApiKey"]}");

            List<HouseObject> HouseInfo = JsonConvert.DeserializeObject<List<HouseObject>>(response);

            return HouseInfo;
        }

        public async Task<HouseObject> GetHouseByName(string houseName)
        {
            string route = "houses";
            //string route = "$houses/{Id}";

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await _client.GetStringAsync($"{ baseUrl }/{ route }?key={_config["PotterApiKey"]}");

            List<HouseObject> HouseInfo = JsonConvert.DeserializeObject<List<HouseObject>>(response);
            
            var singleHouse = HouseInfo.First(h => h.HouseName == houseName);

            return singleHouse;

        }


    }
}
