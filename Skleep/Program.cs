using Skleep;

Product product = new Product("Klawiatura", 150m);
Inventory inventory = new Inventory(10);

Console.WriteLine($"Produkt: {product.Name}");
Console.WriteLine($"Cena: {product.Price} zł");
Console.WriteLine($"Stan magazynu: {inventory.GetStock()}");

inventory.Sell(3);

Console.WriteLine($"Stan po sprzedaży: {inventory.GetStock()}");