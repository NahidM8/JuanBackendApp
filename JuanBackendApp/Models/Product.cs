using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JuanBackendApp.Models
{
    public class Product:BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool isNewArrival { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        [Column(TypeName = "money")]
        public decimal DiscountPrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ExTax { get; set; }
        public int Count { get; set; }
        public string Image { get; set; }

    }
}
