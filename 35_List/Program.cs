using System;
using System.Collections.Generic;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ELEMENTS_COUNT = 10;

            // 리스트에 들어갈 데이터의 개수를 미리 알고 있다면 용량을 처음부터 정하는 게 좋다.
            List<int> list = new List<int>();
            for (int i = 0; i < ELEMENTS_COUNT; ++i)
            {
                list.Add(i);
            }

            Console.WriteLine($"[ {string.Join(",", list)}] ");

            // 리스트 생성하면서 값 넣기
            List<int> list2 = new List<int> { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine($"[ {string.Join(",", list2)}] ");

            Console.WriteLine($"First element: {list[0]}");
            Console.WriteLine($"Last element: {list[list.Count - 1]}");

            list.Insert(2, 2);

            Console.WriteLine($"[ {string.Join(",", list)} ]");

            // 처음 찾는 2만 지움
            // index 2번을 지우는 게 아니고 2라는 값을 가진 요소를 지움
            list.Remove(2);

            Console.WriteLine($"[ {string.Join(",", list)} ]");

            bool bContains5 = list.Contains(5);

            Console.WriteLine($"Contains 5? {bContains5}");

            bool bContains10 = list.Contains(10);

            Console.WriteLine($"Contains 10? {bContains10}");

            int sum = 0;
            for (int i = 0; i < list.Count; ++i)
            {
                sum += list[i];
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}