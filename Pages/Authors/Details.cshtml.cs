using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Moldovan_Andrei.Data;
using Moldovan_Andrei.Models;

namespace Moldovan_Andrei.Pages.Authors
{
    public class DetailsModel : PageModel
    {
        private readonly Moldovan_Andrei.Data.Moldovan_AndreiContext _context;

        public DetailsModel(Moldovan_Andrei.Data.Moldovan_AndreiContext context)
        {
            _context = context;
        }

      public Author Author { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Author == null)
            {
                return NotFound();
            }

            var author = await _context.Author.FirstOrDefaultAsync(m => m.ID == id);
            if (author == null)
            {
                return NotFound();
            }
            else 
            {
                Author = author;
            }
            return Page();
        }
    }
}
