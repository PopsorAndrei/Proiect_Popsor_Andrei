using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Popsor_Andrei.Data;
using Proiect_Popsor_Andrei.Models;

namespace Proiect_Popsor_Andrei.Pages.Teas
{
    public class DeleteModel : PageModel
    {
        private readonly Proiect_Popsor_Andrei.Data.Proiect_Popsor_AndreiContext _context;

        public DeleteModel(Proiect_Popsor_Andrei.Data.Proiect_Popsor_AndreiContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Tea Tea { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Tea = await _context.Tea.FirstOrDefaultAsync(m => m.ID == id);

            if (Tea == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Tea = await _context.Tea.FindAsync(id);

            if (Tea != null)
            {
                _context.Tea.Remove(Tea);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
