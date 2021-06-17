using ShoppingCart.Models;
using System;

namespace ShoppingCart.Commands
{
    public class InsertItemCommand : IOrderCommand
    {
        private Order _order;
        private Item _item;

        public InsertItemCommand(Order order, Item item)
        {
            _order = order;
            _item = item;
        }
        public void Execute()
        {
            _order.OrderItems.Add(_item);
        }
    }
}
