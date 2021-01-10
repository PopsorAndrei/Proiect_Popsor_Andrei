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
    public class IndexModel : PageModel
    {
        private readonly Proiect_Popsor_Andrei.Data.Proiect_Popsor_AndreiContext _context;

        public IndexModel(Proiect_Popsor_Andrei.Data.Proiect_Popsor_AndreiContext context)
        {
            _context = context;
        }

        public IList<Tea> Tea { get;set; }

        public async Task OnGetAsync()
        {
            Tea = await _context.Tea.ToListAsync();
        }
    }
}
