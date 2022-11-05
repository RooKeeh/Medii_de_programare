using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Moldovan_Andrei.Data;
using Moldovan_Andrei.Models;
using Moldovan_Andrei.ViewModels;

namespace Moldovan_Andrei.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Moldovan_Andrei.Data.Moldovan_AndreiContext _context;

        public IndexModel(Moldovan_Andrei.Data.Moldovan_AndreiContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public PublisherIndexData PublisherData { get; set; }
        public int PublisherID { get; set; }
        public int BookID { get; set; }

        public async Task OnGetAsync(int? id, int? bookID)
        {
            if (_context.Category != null)
            {
                Category = await _context.Category.ToListAsync();
            }
        }
    }
}
