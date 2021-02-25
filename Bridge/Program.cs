using System;

namespace Bridge
{
    public static class Program
    {
        private static void Main()
        {
            AppleProduct IPhone = new IPhone(new Software(), new Hardware());
            Console.WriteLine("---- IPhone Details ----");
            Console.WriteLine($"Product: {IPhone.SetProductName()} \nPrice: {IPhone.SetProductPrice()}");
            IPhone.SetHardwareAndSoftware();

            Console.WriteLine();

            AppleProduct macBook = new MacBook(new Software(), new Hardware());
            Console.WriteLine("---- MacBook Details ----");
            Console.WriteLine($"Product: {macBook.SetProductName()} \nPrice: {macBook.SetProductPrice()}");
            macBook.SetHardwareAndSoftware();
        }
    }
}