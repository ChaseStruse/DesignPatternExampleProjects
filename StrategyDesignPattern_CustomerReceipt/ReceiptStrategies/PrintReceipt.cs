using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern_CustomerReceipt
{
    class PrintReceipt : IReceiptStrategy
    {
        public void Receipt()
        {
            Console.WriteLine("Printing receipt");
        }
    }
}
