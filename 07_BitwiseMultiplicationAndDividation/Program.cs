using System;

namespace BitwiseMultiplicationAndDividation
{
    class Program
    {
        static void Main(string[] args)
        {
            // int n의 비트를 왼쪽으로 m칸 이동 = n * 2^m
            int num1 = 3;

            int result1 = num1 << 2; // 3 * 2^2 = 12
            int result2 = num1 << 5; // 3 * 2^5 = 96

            Console.WriteLine("result1: " + result1);
            Console.WriteLine("result2: " + result2);

            // int n의 비트를 오른쪽으로 m칸 이동 = n // 2^m
            int num2 = 33;

            int result3 = num2 >> 2; // 33 // 2^2 = 8
            int result4 = num2 >> 4; // 33 // 2^4 = 2
            int result5 = num2 >> 6; // 33 // 2^6 = 0
            
            Console.WriteLine("result3: " + result3);
            Console.WriteLine("result4: " + result4);
            Console.WriteLine("result5: " + result5);
        }
    }
}