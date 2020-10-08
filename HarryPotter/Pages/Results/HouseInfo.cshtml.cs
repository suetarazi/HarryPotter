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

        public HouseObject oneHouse { get; set; }

        private IHouses _ihouses;

        public HouseInfoModel(IHouses ihouses)
        {
            _ihouses = ihouses;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(string house)
        {
            oneHouse = await _ihouses.GetHouseById(house);

            return Page();

        }

    }
}
