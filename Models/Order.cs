using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace Mobile_Market.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int orderid { get; set; }
        [StringLength(11)]
        public string orderDate { get; set; }
        public string orderTime { get; set; }
        public double Discount { get; set; }
        public double Tax { get; set; }
        public Member MemberId { get; set; }
        public Employee empid { get; set; }
    }
}
