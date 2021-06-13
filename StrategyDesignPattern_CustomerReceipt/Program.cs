using System;

namespace StrategyDesignPattern_CustomerReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerOrder order = new CustomerOrder();

            Console.WriteLine("Enter 1 for Email Receipt");
            Console.WriteLine("Enter 2 for Print Receipt");
            Console.WriteLine("Enter 3 for No Receipt");
            
            string input = Console.ReadLine();
            
            switch (input)
            {
                case "1":
                    order.ReceiptType = "EMAIL";
                    break;
                case "2":
                    order.ReceiptType = "PRINT";
                    break;
                case "3":
                    order.ReceiptType = "NORECEIPT";
                    break;
                default:
                    order.ReceiptType = "PRINT";
                    break;
            }

            order.FinalizeOrder(order);
        }
    }
}
