using BridgeDesignPattern_MovieLicense.Discounts;
using BridgeDesignPattern_MovieLicense.Models;
using BridgeDesignPattern_MovieLicense.MovieLicenses;
using System;

namespace BridgeDesignPattern_MovieLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie() { Name = "Avatar",  Genre = "Action"};

            SeniorDiscount seniorDiscount = new SeniorDiscount();
            LifetimeLicense lifetimeLicense = new LifetimeLicense(movie, seniorDiscount.GetDiscount(), DateTime.Now);

            Console.WriteLine("Lifetime License Price Prior to Senior Discount: " + lifetimeLicense.GetCorePrice());
            Console.WriteLine("Lifetime License Price After Senior Discount: " + lifetimeLicense.GetPrice());
            Console.WriteLine("");

            MilitaryDiscount militaryDiscount = new MilitaryDiscount();
            LifetimeLicense lifetimeLicenseMilitaryDiscount = new LifetimeLicense(movie, militaryDiscount.GetDiscount(), DateTime.Now);

            Console.WriteLine("Lifetime License Price Prior to Military Discount: " + lifetimeLicenseMilitaryDiscount.GetCorePrice());
            Console.WriteLine("Lifetime License Price After Military Discount: " + lifetimeLicenseMilitaryDiscount.GetPrice());
            Console.WriteLine("");

            TwoDayLicense twoDayLicense = new TwoDayLicense(movie, seniorDiscount.GetDiscount(), DateTime.Now);

            Console.WriteLine("Two Day License Price Prior to Senior Discount: " + twoDayLicense.GetCorePrice());
            Console.WriteLine("Two Day License Price After Senior Discount: " + twoDayLicense.GetPrice());
            Console.WriteLine("");

            TwoDayLicense twoDayLicenseMilitaryDiscount = new TwoDayLicense(movie, militaryDiscount.GetDiscount(), DateTime.Now);

            Console.WriteLine("Two Day License Price Prior to Military Discount: " + twoDayLicenseMilitaryDiscount.GetCorePrice());
            Console.WriteLine("Two Day License Price After Military Discount: " + twoDayLicenseMilitaryDiscount.GetPrice());
            Console.WriteLine("");
        }
    }
}
