using AribilgiWebProject.Model;
using System.Collections.Generic;

namespace AribilgiProject.UI.ViewModel
{
    public class ProductViewModel:BaseViewModel<Product>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Stock { get; set; }

        public double UnitPrice { get; set; }

        public short? Discount { get; set; }

        public short? Rate { get; set; }

        public long Color { get; set; }

        public long? Tags { get; set; }

        public List<Image> Images { get; set; }

        public ProductViewModel(Product product):base(product)
        {
            Name = product.Name;
            Description = product.Description;
            Stock = product.Stock;
            UnitPrice = product.UnitPrice;
            Discount = product.Discount;
            Rate = product.Rate;
            Color = product.Color;
            Tags = product.Tags;
            Images = new List<Image>();
        }


    }
}