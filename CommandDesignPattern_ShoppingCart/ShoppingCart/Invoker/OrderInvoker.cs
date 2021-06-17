using ShoppingCart.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
