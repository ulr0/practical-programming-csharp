using System;

namespace LogicalExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 1;
            int num3 = 3;

            bool expression1 = !(num1 == num2 && num1 != num3); // false
            bool expression2 = num1 != num2 || num1 == num3; // false

            Console.WriteLine($"expression1: {expression1}");
            Console.WriteLine($"expression2: {expression2}");

            bool expression3 = num1 > num2 || num1 == num3 || ++num1 > num2; // true, num1 = 2
            Console.WriteLine($"expression3: {expression3}");
            
            // || 연산에서 num3 >= num2 가 true 이므로 num1-- == num2 는 실행 안 함
            bool expression4 = num3 >= num2 || num1-- == num2; // true, num1 = 2
            Console.WriteLine($"expression4: {expression4}");

            // && 연산에서 num3 == num1 이 false 이므로 --num2 > num1 은 실행 안 함
            bool expression5 = num3 == num1 && --num2 > num1; // false, num2 = 1
            Console.WriteLine($"expression5: {expression5}");

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
        }
    }
}