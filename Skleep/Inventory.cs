using System;
using System.Collections.Generic;
using System.Text;


namespace Skleep;

public class Inventory
{
    private int stock;

    public Inventory(int initialStock)
    {
        stock = initialStock;
    }

    public bool Sell(int quantity)
    {
        if (quantity <= 0 || quantity > stock)
            return false;

        stock -= quantity;
        return true;
    }

    public int GetStock()
    {
        return stock;
    }
}
