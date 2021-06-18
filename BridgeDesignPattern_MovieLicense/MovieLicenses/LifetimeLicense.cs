using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern_MovieLicense.MovieLicenses
{
    public class LifetimeLicense : IMovieLicense
    {
        public double GetCorePrice()
        {
            throw new NotImplementedException();
        }

        public int GetExpriation()
        {
            throw new NotImplementedException();
        }

        public double GetPrice()
        {
            throw new NotImplementedException();
        }
    }
}
