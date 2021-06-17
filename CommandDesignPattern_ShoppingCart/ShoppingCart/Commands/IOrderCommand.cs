using ShoppingCart.Models;
using System;

namespace ShoppingCart.Commands
{
    public interface IOrderCommand
    {
        void Execute();
    }
}
