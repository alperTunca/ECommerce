﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Domain.Entities
{
    public class OrderComment : BaseEntity
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public string Comment { get; set; }
    }
}
