using System;

namespace RandomShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SEED = 0;
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            
            Console.WriteLine("Before shuffling: ");
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
            
            Random random = new Random(SEED);

            // 반복문 뒤에서 앞으로 돌기
            for (int i = numbers.Length - 1; i > 0; --i)
            {
                // j를 랜덤으로 생성해서 배열의 i와 j 위치에 있는 요소를 서로 바꾸려고 함
                int j = random.Next(0, i);
                // 배열 속에서 두 요소 교환하기
                // 임시 변수 반드시 필요
                int temp = numbers[j];
                numbers[j] = numbers[i];
                numbers[i] = temp;
            }

            // seed값을 0으로 고정시켰기 때문에 출력값은 언제나 같다.
            // 값 바꾸려면 seed값 안 넣으면 됨
            Console.WriteLine("After shuffling: ");
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}