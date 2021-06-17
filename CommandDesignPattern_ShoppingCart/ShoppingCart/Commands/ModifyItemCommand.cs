using ShoppingCart.Models;
using System;

namespace ShoppingCart.Commands
{
    public class ModifyItemCommand : IOrderCommand
    {
        private readonly Order _order;
        private readonly Item _newItem;
        private readonly Item _itemToModify;

        public ModifyItemCommand(Order order, Item itemToModify, Item newItem)
        {
            _order = order;
            _itemToModify = itemToModify;
            _newItem = newItem;
        }

        public Order Execute()
        {
            // Might be able to refactor...
            var index = _order.OrderItems.FindIndex(x => x.Equals(_itemToModify));
            _order.OrderItems[index] = _newItem;
            return _order;
        }
    }
}
