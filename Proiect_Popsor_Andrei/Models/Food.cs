﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_Popsor_Andrei.Models
{
    public class Food
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string weight { get; set; }
        public string Vegan { get; set; }
        public decimal Price { get; set; }
    }
}