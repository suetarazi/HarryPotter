using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarryPotter.Models;
using HarryPotter.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HarryPotter.Pages.Results
{
    public class HouseInfoModel : PageModel
    {
        [BindProperty]
        public List<HouseObject> houseObjects { get; set; }

        [BindProperty]
        public HouseObject oneHouse { get; set; }

        [BindProperty]
        public List<CharacterObject> houseCharacters { get; set; } 

        private IHouses _ihouses;
        private ICharacters _icharacters;

        public HouseInfoModel(IHouses ihouses, ICharacters icharacters)
        {
            _ihouses = ihouses;
            _icharacters = icharacters;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost(string house)
        {
            oneHouse = await _ihouses.GetHouseByName(house);


            return Page();

        }

        //public async Task<List<IActionResult>> OnPostAsync(string house)
        //{
        //    houseCharacters = await _icharacters.GetAllCharactersInAHouse(house);

        //    return Page();
        //}
    }
}
