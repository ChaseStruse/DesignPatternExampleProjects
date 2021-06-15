using System;
using System.Collections.Generic;
using System.Text;

// This is the context 
namespace StrategyDesignPattern_CustomerReceipt
{
    public class CustomerOrder
    {
        private IReceiptStrategy _receiptStrategy;

        public CustomerOrder(IReceiptStrategy receiptStrategy)
        {
            _receiptStrategy = receiptStrategy;
        }
        public void FinalizeOrder()
        {
            Console.WriteLine("Finalizing order");
            _receiptStrategy.Receipt();
        }
    }
}
