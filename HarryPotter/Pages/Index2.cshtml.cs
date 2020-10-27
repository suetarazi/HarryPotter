using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HarryPotter.Models;
using HarryPotter.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;


namespace HarryPotter.Pages
{
    public class Index2Model : PageModel
    {
        public string House { get; set; }

        private static readonly HttpClient client = new HttpClient();
        private string baseUrl = @"https://www.potterapi.com/v1";

        //Get route for sorting hat
        public async Task<IActionResult> OnGet()
        {
            //House = Request.Form[nameof(House)];
            string route = "sortingHat";

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetStringAsync($"{ baseUrl }/{ route }");

            House = JsonConvert.DeserializeObject<string>(response);


            return Page();

        }
    }
}
