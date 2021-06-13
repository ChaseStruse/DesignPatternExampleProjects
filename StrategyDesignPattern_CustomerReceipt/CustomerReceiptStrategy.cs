using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern_CustomerReceipt
{
    public interface ICustomerReceiptStrategy
    {
        public string GetReceiptStrategy(string strategyType);
    }
    public class CustomerReceiptStrategy : ICustomerReceiptStrategy
    {
        public string EmailReceipt()
        {
            return ("Receipt will be emailed");
        }

        public string GetReceiptStrategy(string strategyType)
        {
            string receiptMessage;
            if (strategyType.ToUpper() == "EMAIL")
            {
                receiptMessage = EmailReceipt();
            }
            else if (strategyType.ToUpper() == "NORECEIPT")
            {
                receiptMessage = NoReceipt();
            }
            else
            {
                receiptMessage = PrintReceipt();
            }

            return (receiptMessage);
        }

        public string NoReceipt()
        {
            return ("Receipt will not be printed nor emailed");
        }

        public string PrintReceipt()
        {
            return ("Receipt will be printed");
        }
    }
}
