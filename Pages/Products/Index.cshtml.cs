using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LiqourCentre.Data;
using LiqourCentre.Models;

namespace LiqourCentre.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly LiqourCentre.Data.LiqourCentreContext _context;

        public IndexModel(LiqourCentre.Data.LiqourCentreContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product
                .Include(p => p.Brand).ToListAsync();
        }
    }
}
