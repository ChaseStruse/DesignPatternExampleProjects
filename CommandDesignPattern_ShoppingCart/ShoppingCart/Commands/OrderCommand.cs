﻿using System;

namespace ShoppingCart.Commands
{
    public interface IOrderCommand
    {
        void Execute();
    }
    public class OrderCommand : IOrderCommand
    {
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
