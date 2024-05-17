using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Application.DTOs.Order
{
    public class UpdateStatusOrder
    {
        [Required(ErrorMessage = "Hesap bilgisi giriniz.")]
        public int AccountId { get; set; }

        [Required(ErrorMessage = "Sipariş numarası giriniz.")]
        public int OrderNumber { get; set; }
    }
}
