using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace ShopingSystem
{
    public class Cart
    {
        public List<Product> Products { get; set; } = new List<Product>();

        // Adding a product to the cart
        public void AddProduct(Product product)
        {
            Products.Add(product);
            Console.WriteLine($"Product '{product.Name}' has been added to the cart.");
        }

        // Saving the cart to an XML file
        public void SaveToXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Cart));
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, this);
            }
            Console.WriteLine($"Cart data has been saved to the XML file at '{filePath}'.");
        }


    }
}
