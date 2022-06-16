using System;

namespace CalculatorUsingEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("num1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("num2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("operation (+, -, *, /, %): ");
            string operationString = Console.ReadLine();
            // string operationString을 char형으로 parse
            char operationChar = char.Parse(operationString);

            // 열거형으로 캐스팅
            EOperator operation = (EOperator)operationChar;

            switch (operation)
            {
                case EOperator.Plus:
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;

                case EOperator.Minus:
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;

                case EOperator.Multiply:
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;

                case EOperator.Divide:
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;

                case EOperator.Mod:
                    Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                    break;

                default:
                    Console.WriteLine($"You entered wrong operator: {operationChar}");
                    break;
            }
        }
    }
}