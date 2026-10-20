
using Skleep;

namespace Skleep.Tests;

public class UnitTest1
{
    [Fact]
    public void PlaceOrder_ReturnsCorrectTotal()
    {
        Product product = new Product("Klawiatura", 150m);
        Inventory inventory = new Inventory(10);
        OrderService orderService = new OrderService(inventory);

        decimal total = orderService.PlaceOrder(product, 3);

        Assert.Equal(450m, total);
    }


    [Fact]
    public void PlaceOrder_ReducesInventoryStock()
    {
        Product product = new Product("Klawiatura", 150m);
        Inventory inventory = new Inventory(10);
        OrderService orderService = new OrderService(inventory);

        orderService.PlaceOrder(product, 3);

        Assert.Equal(7, inventory.GetStock());
    }


    [Fact]
    public void PlaceOrder_RejectsOrderWhenStockIsInsufficient()
    {
        Product product = new Product("Klawiatura", 150m);
        Inventory inventory = new Inventory(5);
        OrderService orderService = new OrderService(inventory);

        decimal total = orderService.PlaceOrder(product, 8);

        Assert.Equal(0m, total);
        Assert.Equal(5, inventory.GetStock());
    }


    [Fact]
    public void PlaceOrder_RejectsInvalidQuantity()
    {
        Product product = new Product("Klawiatura", 150m);
        Inventory inventory = new Inventory(10);
        OrderService orderService = new OrderService(inventory);

        decimal total = orderService.PlaceOrder(product, 0);

        Assert.Equal(0m, total);
        Assert.Equal(10, inventory.GetStock());
    }
}
