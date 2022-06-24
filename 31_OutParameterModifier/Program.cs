using System;

namespace OutParameterModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter \"true\" or \"false\": ");
            string booleanString = Console.ReadLine();

            bool b;
            if (bool.TryParse(booleanString, out b))
            {
                Console.WriteLine($"Successfully parsed: {b}");
            }
            else
            {
                Console.WriteLine("Cannot be parsed to boolean");
            }

            Console.Write("Enter an integer: ");
            string intString = Console.ReadLine();

            int number;
            if (int.TryParse(intString, out number))
            {
                Console.WriteLine($"Successfully parsed: {number}");
            }
            else
            {
                Console.WriteLine("Cannot be parsed to integer");
            }

            // TryParse() 함수는 char, float, double, enum 등 다양한 자료형에 존재

            int someNumber = 7;
            int randomNumber;

            if (TryGetIntegerGreaterThan(someNumber, out randomNumber))
            {
                Console.WriteLine($"{randomNumber} > {someNumber}");
            }
            // Try 함수가 false를 반환한 경우에는 out 변수를 쓰지 않는 것이 좋다. 쓰지 마셈.
            else
            {
                Console.WriteLine($"Failed to get an integer greater than {someNumber}");
            }
        }

        // TryParse() 처럼 동작하는 함수 만들기
        static bool TryGetIntegerGreaterThan(int input, out int output)
        {
            var random = new Random();

            output = random.Next(0, 10);

            return output > input;
        }
    }
}