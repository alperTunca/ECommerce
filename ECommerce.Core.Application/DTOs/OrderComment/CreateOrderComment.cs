using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Application.DTOs.OrderComment
{
    public class CreateOrderComment
    {
        [Required(ErrorMessage = "Kullanıcı bilgisi giriniz.")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Hesap bilgisi giriniz.")]
        public int AccountId { get; set; }

        [Required(ErrorMessage = "Sipariş numarası giriniz.")]
        public int OrderId { get; set; }
        public string Comment { get; set; }
    }
}
