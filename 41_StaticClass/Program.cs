using System;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            double centimeters = UnitConverter.GetCentimetersFromInches(24.4);
            double feet = UnitConverter.GetFeetFromInches(77);
            double inches = UnitConverter.GetInchesFromCentimeters(100.1);
            double meters = UnitConverter.GetMetersFromCentimeters(2456.89);

            Console.WriteLine($"{centimeters}");
            Console.WriteLine($"{feet}");
            Console.WriteLine($"{inches}");
            Console.WriteLine($"{meters}");
        }
    }
}