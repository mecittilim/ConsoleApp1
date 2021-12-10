using Odev6Products;

Products product1 = new Products();

product1.Adi = "Ayakkabı";
product1.Id = "Yung1";
product1.Fiyati = 580.75;
product1.Stok = 10;

Products product2 = new Products();

product2.Adi = "Ayakkabı";
product2.Id = "SuperStar";
product2.Fiyati = 750.99;
product2.Stok = 20;

Products product3 = new Products();

product3.Adi = "Ayakkabı";
product3.Id = "Samoa";
product3.Fiyati = 850.99;
product3.Stok = 30;

Products[] products = new Products[] { product1, product2, product3 };

foreach (Products product in products)
{
    Console.WriteLine(product1.Adi + product1.Id);
    Console.WriteLine(product2.Adi + product3.Fiyati);
}

Console.WriteLine("BREAK");

for (int i = 0; i < products.Length; i++)
{
    Console.WriteLine(products[i]);
}

Console.WriteLine("bREK 2");