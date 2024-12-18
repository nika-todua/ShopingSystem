using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingSystem
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Parameterless constructor
        public Product() { }

        // Parameterized constructor
        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }


    }
}
