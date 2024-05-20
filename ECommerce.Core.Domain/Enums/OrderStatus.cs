﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Domain.Enums
{
    public enum OrderStatus
    {
        Received = 1,
        InProgress = 2,
        Pick = 3,
        Pack = 4,
        Ship = 5,
        Delivered = 6
    }
}
