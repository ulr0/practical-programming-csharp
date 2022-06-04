using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 100;

            Console.WriteLine($"sum of 1 - {MAX}");

            int sum = 0;
            // i를 1 증가시킨 후 대입하지 않기 때문에 i++ 이든, ++i 이든 차이 없음
            for (int i = 0; i < MAX; ++i)
            {
                sum += (i + 1);
            }
            
            // 또는
            // for (int i = 1; i <= MAX; ++i)
            // {
            //     sum += i;
            // }

            Console.WriteLine(sum);
        }
    }
}