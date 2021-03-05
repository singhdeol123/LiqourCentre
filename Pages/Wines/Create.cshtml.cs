using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LiqourCentre.Data;
using LiqourCentre.Models;

namespace LiqourCentre.Pages.Wines
{
    public class CreateModel : PageModel
    {
        private readonly LiqourCentre.Data.LiqourCentreContext _context;

        public CreateModel(LiqourCentre.Data.LiqourCentreContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Wine Wine { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Wine.Add(Wine);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
