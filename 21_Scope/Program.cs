using System;

namespace Scope
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, -3, -4, 7, 10, 42, -9, 99 };
            double average = GetAverage(numbers);

            Console.WriteLine($"average: {average}");

            // 중괄호를 이용하여 새 범위를 만들 수 있다.
            // scope1
            {
                // 컴파일 오류
                // 부모 범위 안에 정의된 변수를 재정의할 수 없다.
                // int average = 0;
                string message = "Message in the first child scope";
                Console.WriteLine($"{message}");
            } // 여기서 scope1 끝 

            //scope2
            {
                // 컴파일 오류
                // int average = 0;

                // 컴파일 에러 안 나는 이유
                // scope1과 scope2는 다른 범위이기 때문에
                // 서로 소속되지 않음
                string message = "Message in the second child scope";
                Console.WriteLine($"{message}");
            }
        }
    
        static double GetAverage(int[] inputs)
        {
            int sum = 0;

            // numbers 변수는 이 함수 안에 정의되어 있지 않으므로 사용하려 하면 컴파일 오류 발생
            // 이 함수 안에 numbers라는 변수가 있었더라도 Main() 함수 안에 정의된 numbers 변수와 같지 않음 
            // for (int i = 0; i < numbers.Length; ++i)
            // {
            //     sum += numbers[i];
            // }

            for (int i = 0; i < inputs.Length; ++i)
            {
                sum += inputs[i];
            }

            return (double)sum / inputs.Length;
        }
    }
}