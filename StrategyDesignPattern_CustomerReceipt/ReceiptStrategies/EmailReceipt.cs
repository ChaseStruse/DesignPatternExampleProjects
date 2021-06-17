using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern_CustomerReceipt
{
    public class EmailReceipt : IReceiptStrategy
    {
        public void Receipt()
        {
            Console.WriteLine("Sending emailed receipt");
        }
    }
}
