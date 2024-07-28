namespace JuanBackendApp.Models
{
    public class ProductColor:BaseEntity
    {
        public int ProductID { get; set; }
        public Product product { get; set; }
        public int ColorID { get; set; }
        public Color Color { get; set; }
    }
}
