using System;

namespace StrategyDesignPattern_CustomerReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerOrder customerOrderEmail = new CustomerOrder(new EmailReceipt());
            customerOrderEmail.FinalizeOrder();

            CustomerOrder customerOrderNoReceipt = new CustomerOrder(new NoReceipt());
            customerOrderNoReceipt.FinalizeOrder();

            CustomerOrder customerOrderPrintReceipt = new CustomerOrder(new PrintReceipt());
            customerOrderPrintReceipt.FinalizeOrder();
        }
    }
}
