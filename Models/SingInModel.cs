using System.ComponentModel.DataAnnotations;

namespace Mobil_Market.Models
{
    public class SingInModel
    {
        [Required]
        public string?  Id { get; set; }

        [Required]
        public string? Password { get; set; }

        public string? copyidsignin { get; set; }

    }
}
