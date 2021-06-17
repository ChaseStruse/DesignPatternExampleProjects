using ShoppingCart.Models;
using System;

namespace ShoppingCart.Commands
{
    public class RemoveItemCommand : IOrderCommand
    {
        private Order _order;
        private Item _item;

        public RemoveItemCommand (Order order, Item item)
        {
            _order = order;
            _item = item;
        }
        public Order Execute()
        {
            _order.OrderItems.Remove(_item);
            return _order;
        }
    }
}
