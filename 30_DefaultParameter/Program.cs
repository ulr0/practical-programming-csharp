using System;

namespace DefaultParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Bar("hi");
            Bar("hi", "roo");
            Bar("hi", "roo", "bye");
        }

        static void Bar(string s1, string s2 = "", string s3 = "")
        {
            Console.WriteLine($"{s1}, {s2}, {s3}");
        }
    }
}