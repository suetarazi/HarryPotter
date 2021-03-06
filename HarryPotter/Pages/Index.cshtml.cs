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
    public class IndexModel : PageModel
    {
        public string House { get; set; }

        [BindProperty]
        public List<HouseObject> HouseObjects { get; set; }

        [BindProperty]
        public List<SpellsObject> SpellsObjects { get; set; }

        //private static readonly HttpClient client = new HttpClient();
        //private string baseUrl = @"https://www.potterapi.com/v1";
        private IHouses _houses;
        private ISpells _spells;

        public IndexModel(IHouses houses, ISpells spells)
        {
            _houses = houses;
            _spells = spells;
        }


        public async Task<IActionResult> OnGet()
        {
            HouseObjects = await _houses.GetAllHouses();
            //HouseObject results = new HouseObject();
            //HouseObjects.results = gettingHouseInfo;
            return Page();
        }

        

    }
}
