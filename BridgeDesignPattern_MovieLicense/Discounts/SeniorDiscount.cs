using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern_MovieLicense.Discounts
{
    public class SeniorDiscount : IDiscount
    {
        public double GetDiscount()
        {
            return .2;
        }
    }
}
