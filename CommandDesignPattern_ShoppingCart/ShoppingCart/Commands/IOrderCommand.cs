using ShoppingCart.Models;
using System;

namespace ShoppingCart.Commands
{
    public interface IOrderCommand
    {
        Order Execute();
    }
}
