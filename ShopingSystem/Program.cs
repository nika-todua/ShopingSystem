using System;
using ShopingSystem;

List<Product> products = new List<Product>
{
    new Product(1, "Laptop", 1200.99m),
    new Product(2, "Smartphone", 799.49m),
    new Product(3, "Headphones", 199.99m)
};

Cart cart = new Cart();

while (true)
{
    Console.WriteLine("\nProduct list:");
    foreach (var product in products)
    {
        Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price:C}");
    }

    Console.Write("\nEnter the product ID to add to the cart (or '0' to exit): ");
    string input = Console.ReadLine();

    if (input == "0") break;

    if (int.TryParse(input, out int productId))
    {
        var selectedProduct = products.Find(p => p.Id == productId);

        if (selectedProduct != null)
        {
            cart.AddProduct(selectedProduct);
        }
        else
        {
            Console.WriteLine("Invalid ID. Please try again.");
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid number.");
    }
}

// Create the path for the Desktop
string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
string filePath = Path.Combine(desktopPath, "cart.xml");

// Save the file to the Desktop
cart.SaveToXml(filePath);
