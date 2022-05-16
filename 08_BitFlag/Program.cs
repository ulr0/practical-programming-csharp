using System;

namespace BitFlasg
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1바이트 안에 몇 개의 비트가 들어갈 수 있는지 정의
            const int BIT_FLAG_SIZE = 8;

            byte bitFlags = 0; // 0000 0000

            // bitFlasg의 오른쪽에서부터 세 번째 비트를 참(1)으로 설정하려면?

            byte mask1 = 1 << 2; // 0000 0100

            bitFlags |= mask1;
            /*
            bitFlasgs   0000 0000
            mask1       0000 0100
            |(or) 연산   0000 0100  
            */

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));

            // 오른쪽에서 4번째, 6번째 비트를 참(1)으로 설정하려면?

            byte mask2 = 1 << 3 | 1 << 5; // 0010 1000

            bitFlags |= mask2;
            /*
            bitFlags    0000 0100
            mask2       0010 1000
            |(or) 연산   0010 1100
            */

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));
            
            // 오른쪽에서 3번째 비트를 거짓(0)으로 설정하려면?

            bitFlags &= (byte)~mask1;
            /*
            bitFlags       0010 1100
            (byte)~mask1   1111 1011
            &(and) 연산     0010 1000
            */

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));

            // 모든 비트를 거짓(0)으로 변경하려면 ?
            
            bitFlags &= 0;
            /*
            bitFlags     0010 1000
            0            0000 0000
            &(and) 연산   0000 0000
            */

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));

            char char1 = 'A';
            int result1 = char1 | ' ';
            /*
                        ASCII CODE  Binary
            char1       65          0000 0000 0000 0000 0000 0000 0100 0001             
            ' '         32          0000 0000 0000 0000 0000 0000 0010 0000
            |(or)연산    97          0000 0000 0000 0000 0000 0000 0110 0001  
            */

            Console.WriteLine("result1: " + (char)result1); // 'a'

            char char2 = 'a';
            int result2 = char2 & '_';
            /*
                        ASCII CODE  Binary
            char2       97          0000 0000 0000 0000 0000 0000 0110 0001             
            '_'         95          0000 0000 0000 0000 0000 0000 0101 1111
            &(and)연산   65          0000 0000 0000 0000 0000 0000 0100 0001  
            */

            Console.WriteLine("result2: " + (char)result2); // 'A'
        }
    }
}