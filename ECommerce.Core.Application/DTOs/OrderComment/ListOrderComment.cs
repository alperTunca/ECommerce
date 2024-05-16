using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Application.DTOs.OrderComment
{
    public class ListOrderComment
    {
        public int UserId { get; set; }
        public int OrderId { get; set; }
        public string Comment { get; set; }
    }
}
