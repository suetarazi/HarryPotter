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
    public class SpellsResultsModel : PageModel
    {
        [BindProperty]
        public List<SpellsObject> SpellsObject { get; set; }

        private ISpells _spells;

        public SpellsResultsModel(ISpells spells)
        {
            _spells = spells;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            SpellsObject = await _spells.GetAllSpells();

            return Page();

        }

    }
}
