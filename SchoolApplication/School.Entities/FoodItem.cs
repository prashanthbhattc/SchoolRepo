﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entities
{
   public class FoodItem: EntityBase
    {
        public string Name { get; set; }
        public Category category { get; set; }
    }
}
