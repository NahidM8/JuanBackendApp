namespace JuanBackendApp.Models
{
    public class ProductSize:BaseEntity
    {
        public int ProductID { get; set; }
        public Product product { get; set; }
        public int SizeID { get; set; }
        public Size Size { get; set; }
    }
}
