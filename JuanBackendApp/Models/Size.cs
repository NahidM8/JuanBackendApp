﻿namespace JuanBackendApp.Models
{
    public class Size:BaseEntity
    {
        public string Name { get; set; }
        public List<ProductSize> ProductSizes { get; set; }
    }
}
