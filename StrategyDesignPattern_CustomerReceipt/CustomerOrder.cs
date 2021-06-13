using System;
using System.Collections.Generic;
using System.Text;

// This is the context 
namespace StrategyDesignPattern_CustomerReceipt
{
    public class CustomerOrder
    {
        private ICustomerReceiptStrategy CustomerReceiptStrategy { get; set; } = new CustomerReceiptStrategy();
        public string ReceiptType { get; set; }

        public void FinalizeOrder(CustomerOrder order)
        {
            Console.WriteLine(CustomerReceiptStrategy.GetReceiptStrategy(order.ReceiptType));
        }
    }
}
