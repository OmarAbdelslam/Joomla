using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mobile_Market.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int empid { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string empName { get; set; }
        public string Address { get; set; }
        public int empPhone { get; set; }
        public string Email { get; set; }
        public string HireDate { get; set; }
        public string BirthDate { get; set; }

    }
}
