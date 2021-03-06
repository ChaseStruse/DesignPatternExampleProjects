using BridgeDesignPattern_MovieLicense.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern_MovieLicense.MovieLicenses
{
    public class TwoDayLicense : IMovieLicense
    {
        private Movie _movie;
        private double _discount;
        private DateTime _purchaseDate;

        public TwoDayLicense(Movie movie, double discount, DateTime purchaseDate)
        {
            _movie = movie;
            _discount = discount;
            _purchaseDate = purchaseDate;
        }

        public double GetCorePrice()
        {
            return 4.0;
        }

        public int? GetExpriation()
        {
            return 2;
        }

        public double GetPrice()
        {
            if (_discount != null)
            {
                var pricePriorToDiscount = GetCorePrice();
                var priceAfterDiscount = pricePriorToDiscount * (1 - _discount);
                return priceAfterDiscount;
            }
            return GetCorePrice();
        }
    }
}
