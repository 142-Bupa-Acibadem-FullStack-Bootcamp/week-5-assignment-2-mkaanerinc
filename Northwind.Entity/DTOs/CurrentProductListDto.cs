﻿using Northwind.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entity.DTOs
{
    public class CurrentProductListDto : DtoBase
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
