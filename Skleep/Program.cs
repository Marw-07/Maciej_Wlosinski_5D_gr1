
using Skleep;

Product product = new Product("Klawiatura", 150m);
Inventory inventory = new Inventory(10);
OrderService orderService = new OrderService(inventory);

decimal total = orderService.PlaceOrder(product, 3);

Console.WriteLine($"Produkt: {product.Name}");
Console.WriteLine($"Cena za sztukę: {product.Price} zł");
Console.WriteLine($"Wartość zamówienia: {total} zł");
Console.WriteLine($"Pozostało w magazynie: {inventory.GetStock()}");
