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
    public class CharacterResultsModel : PageModel
    {
        [BindProperty]
        public List<CharacterObject> houseCharacters { get; set; }

        private ICharacters _icharacters;

        public CharacterResultsModel(ICharacters icharacters)
        {
            _icharacters = icharacters;
        }

        public void OnGet()
        {
        }

        //public async Task<List<IActionResult>> OnPost(string house)
        //{
        //    houseCharacters = await _icharacters.GetAllCharactersInAHouse(house);

        //    return Page();
        //}
    }
}
