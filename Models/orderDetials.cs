using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mobile_Market.Models
{
    [Keyless]
    public class orderDetials
    {
        [Key]
        public int orderdetialsID { get; set; }

        public int Qty { get; set; }

        public double Price { get; set; }

        public Product itemnumber { get; set; }

        public Order orderId { get; set; }


    }
}
