using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proiect_Popsor_Andrei.Data;
using Proiect_Popsor_Andrei.Models;

namespace Proiect_Popsor_Andrei.Pages.Teas
{
    public class EditModel : PageModel
    {
        private readonly Proiect_Popsor_Andrei.Data.Proiect_Popsor_AndreiContext _context;

        public EditModel(Proiect_Popsor_Andrei.Data.Proiect_Popsor_AndreiContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Tea).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeaExists(Tea.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TeaExists(int id)
        {
            return _context.Tea.Any(e => e.ID == id);
        }
    }
}
