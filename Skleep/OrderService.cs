using System;
using System.Collections.Generic;
using System.Text;


namespace Skleep;

public class OrderService
{
    private Inventory inventory;

    public OrderService(Inventory inventory)
    {
        this.inventory = inventory;
    }

    public decimal PlaceOrder(Product product, int quantity)
    {
        if (inventory.Sell(quantity))
            return product.Price * quantity;

        return 0;
    }
}
