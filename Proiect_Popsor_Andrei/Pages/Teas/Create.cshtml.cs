using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect_Popsor_Andrei.Data;
using Proiect_Popsor_Andrei.Models;

namespace Proiect_Popsor_Andrei.Pages.Teas
{
    public class CreateModel : PageModel
    {
        private readonly Proiect_Popsor_Andrei.Data.Proiect_Popsor_AndreiContext _context;

        public CreateModel(Proiect_Popsor_Andrei.Data.Proiect_Popsor_AndreiContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Tea Tea { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Tea.Add(Tea);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
