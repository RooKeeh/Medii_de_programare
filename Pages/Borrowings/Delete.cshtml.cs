﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Moldovan_Andrei.Data;
using Moldovan_Andrei.Models;

namespace Moldovan_Andrei.Pages.Borrowings
{
    public class DeleteModel : PageModel
    {
        private readonly Moldovan_Andrei.Data.Moldovan_AndreiContext _context;

        public DeleteModel(Moldovan_Andrei.Data.Moldovan_AndreiContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Borrowing Borrowing { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Borrowing == null)
            {
                return NotFound();
            }

            var borrowing = await _context.Borrowing.FirstOrDefaultAsync(m => m.ID == id);

            if (borrowing == null)
            {
                return NotFound();
            }
            else 
            {
                Borrowing = borrowing;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Borrowing == null)
            {
                return NotFound();
            }
            var borrowing = await _context.Borrowing.FindAsync(id);

            if (borrowing != null)
            {
                Borrowing = borrowing;
                _context.Borrowing.Remove(Borrowing);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
