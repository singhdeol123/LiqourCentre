using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LiqourCentre.Data;
using LiqourCentre.Models;

namespace LiqourCentre.Pages.Wines
{
    public class DetailsModel : PageModel
    {
        private readonly LiqourCentre.Data.LiqourCentreContext _context;

        public DetailsModel(LiqourCentre.Data.LiqourCentreContext context)
        {
            _context = context;
        }

        public Wine Wine { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Wine = await _context.Wine.FirstOrDefaultAsync(m => m.ID == id);

            if (Wine == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
