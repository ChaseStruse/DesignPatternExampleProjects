using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern_MovieLicense.Discounts
{
    public class MilitaryDiscount : IDiscount
    {
        public double GetDiscount()
        {
            return .1;
        }
    }
}
