using System;

namespace ValueTypeVsReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            Increment(num);

            // int는 값형. 값형을 함수의 인자로 전달하면 언제나 복사본 전달.
            // 복사본의 값을 바꾼다고 원본이 바뀌진 않는다.
            Console.WriteLine(num); // 0

            int[] nums = new int[] { 1, 2, 3, 4, 5 };

            Increment(nums);
            
            // 배열은 참조형. 원본 전달 -> 원본 변경
            Console.WriteLine(string.Join(", ", nums)); // 2, 3, 4, 5, 6

            Vector vector = new Vector(0, 0);

            Increment(vector);

            // class는 참조형. 원본 전달 -> 원본 변경
            Console.WriteLine($"{vector.X} {vector.Y}"); // 1, 1
        }

        public static void Increment(int num)
        {
            num++;
        }

        public static void Increment(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i]++;
            }
        }

        public static void Increment(Vector vector)
        {
            vector.X++;
            vector.Y++;
        }
    }
}