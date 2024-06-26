﻿using System.Collections.Generic;

namespace Sushi.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Food> Foods { get; set; }
    }
}
