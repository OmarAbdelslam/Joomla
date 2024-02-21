using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mobile_Market.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string WarrantyPeriod { get; set; }
        public double Price { get; set; }
        public string CountryMake { get; set; }
        public string Item_Image { get; set; }
        public int Qty { get; set; }
        public Departement BrandNamber { get; set; }

    }
}
