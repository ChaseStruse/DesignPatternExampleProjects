using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern_CustomerReceipt
{
    public class NoReceipt : IReceiptStrategy
    {
        public void Receipt()
        {
            Console.WriteLine("No receipt will be sent");
        }
    }
}
