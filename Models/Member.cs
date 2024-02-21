using Mobil_Market.Models.IRepositry;
using Mobile_Market.Models.DBwork;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mobile_Market.Models
{
    public class Member
    {
        [Key]
        public string? memberId { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "The firstname name is Required")]
        public string?  firstname { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "The lastname name is Required")]
        public string? lastname { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "The Password name is Required")]
        public string? Password { get; set; }

        //[StringLength(100)]
        [EmailAddress]
        [Required(ErrorMessage = "The email name is Required")]
        public string? email { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "The Gender name is Required")]
        public string? Gender { get; set; }

        [StringLength(11)]
        [Required(ErrorMessage = "The Bdate name is Required")]
        public string? Bdate { get; set; }

        [Range(10, 15 , ErrorMessage ="The Phone Number Range  Between 10 & 15")]
        [Required(ErrorMessage = "The phone name is Required")]
        public int phone { get; set; }

        [Required(ErrorMessage = "The questionsecurte name is Required")]
        public string? questionsecurte { get; set; }


    }
}
