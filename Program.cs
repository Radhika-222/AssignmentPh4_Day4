// See https://aka.ms/new-console-template for more information
using Assignment_Day4;
SortedList<int, Product> products = new SortedList<int, Product>(); 
products.Add (1,new Product { PName = "TV", PPrice = 50000.90, PBrand = "Sony", ManufacturingDate = new DateTime(day: 23, month: 01, year: 2022), ExpiryDate = new DateTime(day: 12, month: 03, year: 2030)});
products.Add(2, new Product { PName = "Laptop", PPrice = 60000.00, PBrand = "HP", ManufacturingDate = new DateTime(day: 22, month: 09, year: 2021), ExpiryDate = new DateTime(day: 05, month: 09, year: 2025)});
products.Add(3, new Product { PName = "Fridge", PPrice = 35000.99, PBrand = "Samsung", ManufacturingDate = new DateTime(day: 08, month: 03, year: 2019), ExpiryDate = new DateTime(day: 09, month: 02, year: 2026) });
products.Add(4, new Product { PName = "Mobile", PPrice = 25000.89, PBrand = "Vivo", ManufacturingDate = new DateTime(day: 28, month: 11, year: 2020), ExpiryDate = new DateTime(day: 30, month: 12, year: 2023) });
products.Add(5, new Product { PName = "Washing Machine", PPrice = 30000.33, PBrand = "LG", ManufacturingDate = new DateTime(day: 11, month: 01, year: 2024), ExpiryDate = new DateTime(day: 15, month: 04, year: 2028) });
products.Add(6, new Product { PName = "EarBuds", PPrice = 3000.33, PBrand = "One+", ManufacturingDate = new DateTime(day: 10, month: 03, year: 2024), ExpiryDate = new DateTime(day: 11, month: 04, year: 2027) });

DisplayProductDetails(products);
static void DisplayProductDetails(SortedList<int,Product> products)
{
    Console.WriteLine("PName \t     PPrice \t     PBrand \t      ManufatcuringDate \t     ExpiryDate ");
    foreach (var product in products)
    {
        Console.Write(product.Value.PName + "\t \t");
        Console.Write(product.Value.PPrice + "\t \t ");
        Console.Write(product.Value.PBrand + "\t\t  ");
        Console.Write(product.Value.ManufacturingDate.ToLongDateString() + "\t \t ");
        Console.Write(product.Value.ExpiryDate.ToLongDateString());
        Console.WriteLine("\n");
       
    }
}

