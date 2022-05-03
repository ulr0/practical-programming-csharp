using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 15;
            int num2 = 17;

            int result1 = num1 + num2;
            int result2 = num1 - num2;

            Console.WriteLine("result1: " + result1);
            Console.WriteLine("result2: " + result2);

            // 언더플로우
            uint result3 = (uint)num1 - (uint)num2; // 4294967294

            Console.WriteLine("result3: " + result3);
            
            int num3 = int.MaxValue;
            // 오버플로우
            int result4 = num3 + 1; // -2147483648

            Console.WriteLine("result4: " + result4);

            float num4 = 7.7f;

            // 컴파일러가 승격(Promotion) 해줘서 float으로 계산됨
            float result5 = num1 + num4;
            float result6 = num4 - num1;

            Console.WriteLine("result5: " + result5);
            Console.WriteLine("result6: " + result6);

            float result7 = num1 * num4;

            Console.WriteLine("result7: " + result7);

            // num2 / num1 = int / int 계산을 int로 함
            // 계산 결과인 1을 float result8에 대입해 줌
            float result8 = num2 / num1; // 1
            // 명시적 형 변환
            // 둘 중 하나만 해도 되는 이유 : 승격
            // 둘 다 형 변환 해줘도 되지만 보통은 둘 중 하나만 형 변환
            float result9 = num2 / (float)num1; // 1.1333333

            Console.WriteLine("result8: " + result8);
            Console.WriteLine("result9: " + result9);

            int result10 = num1 % num2;
            int result11 = num2 % num1;

            Console.WriteLine("result10: " + result10);
            Console.WriteLine("result11: " + result11);
        }
    }
}