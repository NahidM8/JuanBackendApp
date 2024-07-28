namespace JuanBackendApp.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public bool IsMain { get; set; }
    }
}
