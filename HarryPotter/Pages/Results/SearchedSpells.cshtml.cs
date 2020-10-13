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
    public class SearchedSpellsModel : PageModel
    {
        [BindProperty]
        public List<SpellsObject> spellType { get; set; }

        private ISpells _spells;

        public SearchedSpellsModel(ISpells spells)
        {
            _spells = spells;
        }
        
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(string type)
        {
            spellType = await _spells.GetSpellsByType(type);

            return Page();
        }

    }
}
