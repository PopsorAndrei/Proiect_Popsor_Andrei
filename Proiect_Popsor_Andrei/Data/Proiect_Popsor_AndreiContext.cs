using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect_Popsor_Andrei.Models;

namespace Proiect_Popsor_Andrei.Data
{
    public class Proiect_Popsor_AndreiContext : DbContext
    {
        public Proiect_Popsor_AndreiContext (DbContextOptions<Proiect_Popsor_AndreiContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect_Popsor_Andrei.Models.Tea> Tea { get; set; }

        public DbSet<Proiect_Popsor_Andrei.Models.Drink> Drink { get; set; }

        public DbSet<Proiect_Popsor_Andrei.Models.Food> Food { get; set; }
    }
}
