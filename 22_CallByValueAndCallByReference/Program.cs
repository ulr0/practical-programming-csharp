using System;

namespace CallByValueAndCallByReference
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;

            // 값에 의한 전달
            // num1의 복사본을 전달
            // IncrementByValue()의 인자 값이 변경되어도 원본(num1)에 반영되지 않음
            IncrementByValue(num1, 5, 3);

            Console.WriteLine($"num1 after IncrementByValue: {num1}");

            // 참조에 의한 전달
            // num1 원본을 전달
            // IncrementByReference()의 인자 값이 변하면 원본(num1)에 반영됨
            IncrementByReference(ref num1, 5, 3);

            Console.WriteLine($"num1 after IncrementByReference: {num1}");
        }

        static void IncrementByValue(int num, int increment, int incrementCount)
        {
            for (int i = 0; i < incrementCount; ++i)
            {
                num += increment;
            }
        }

        static void IncrementByReference(ref int num, int increment, int incrementCount)
        {
            for (int i = 0; i < incrementCount; ++i)
            {
                num += increment;
            }
        }
    }
}