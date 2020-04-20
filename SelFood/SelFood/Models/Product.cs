using System.Collections.Generic;

namespace SelFood.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
    public class ProductsList 
    {
        public List<Product> _product { get; set; }

        public ProductsList()
        {
            _product = new List<Product>();
            LoadProduct();
        }

        public void LoadProduct()
        {
            _product.Add(new Product
            {
                Name = "Zanahoria",
                Quantity = 5
            });
            _product.Add(new Product
            {
                Name = "Papa",
                Quantity = 15
            });
            _product.Add(new Product
            {
                Name = "Cebolla",
                Quantity = 3
            });
            _product.Add(new Product
            {
                Name = "Manzanas",
                Quantity = 2
            });
            _product.Add(new Product
            {
                Name = "Cajas leche",
                Quantity = 6
            });
            _product.Add(new Product
            {
                Name = "Melocoton",
                Quantity = 5
            });

        }
    }
}
