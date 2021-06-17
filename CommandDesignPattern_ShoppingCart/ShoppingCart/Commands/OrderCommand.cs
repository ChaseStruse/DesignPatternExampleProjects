using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
