using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern_MovieLicense.MovieLicenses
{
    public interface IMovieLicense
    {
        double GetCorePrice();
        double GetPrice();
        int? GetExpriation();

    }
}
