using ShoppingCart.Commands;
using ShoppingCart.Models;

namespace ShoppingCart.Invoker
{
    public class OrderInvoker
    {
        private IOrderCommand _orderCommand;

        public void SetOrderCommand(IOrderCommand command) => _orderCommand = command;

        public void Invoke()
        {
            _orderCommand.Execute();
        }

    }
}
