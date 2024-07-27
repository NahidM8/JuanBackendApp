using System.ComponentModel.DataAnnotations;

namespace JuanBackendApp.Models
{
    public class ProductCategory:BaseEntity
    {
        [Key]
        public int ProductCategoryId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
