using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mobile_Market.Models
{
    public class Departement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int depoNo { get; set; }
        [Required]
        [StringLength(40)]
        public string depoName { get; set; }

        [Required]
        public string depoimage { get; set; }

    }
}
