﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerArchitecture.Core.Model;

namespace NLayerArchitecture.Core.DTOs
{
    public class ProductWithCategoryDto:ProductDto
    { 
        public CategoryDto CategoryDto { get; set; }
    }
}
