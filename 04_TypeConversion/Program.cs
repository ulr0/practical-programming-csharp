using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = 'A';
            char char2 = 'a';

            // char는 16비트 int는 32비트
            // char -> int 묵시적 변환 가능
            int int1 = char1;
            int int2 = char2;
            Console.WriteLine("int1: " + int1);
            Console.WriteLine("int2: " + int2);

            long long1 = char1;
            long long2 = char2;
            Console.WriteLine("long1: " + long1);
            Console.WriteLine("long2: " + long2);

            ulong ulong1 = char1;
            ulong ulong2 = char2;
            Console.WriteLine("ulong1: " + ulong1);
            Console.WriteLine("ulong2: " + ulong2);

            float float1 = char1;
            float float2 = char2;
            Console.WriteLine("float1: " + float1);
            Console.WriteLine("float2: " + float2);

            double double1 = char1;
            double double2 = char2;
            Console.WriteLine("double1: " + double1);
            Console.WriteLine("double2: " + double2);
            // 'A'의 ASCII 코드는 65
            // 'a'의 ASCII 코드는 97

            // long은 int로 묵시변 변환 불가능
            // 명시적 변환해야 함
            long long3 = long.MaxValue;
            int long3ToInt = (int)long3;
            Console.WriteLine("long3: " + long3);
            Console.WriteLine("long3ToInt: " + long3ToInt);
            // long.MaxValue의 이진수 : 0111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111 1111
            // int로 변환했을 때의 이진수(왼쪽의 32비트 사라짐) : 1111 1111 1111 1111 1111 1111 1111 1111 => -1

            // float도 int로 바꾸려면 명시적 변환
            float float3 = 3.14f;
            int float3ToInt = (int)float3;
            Console.WriteLine("float3: " + float3);
            Console.WriteLine("float3ToInt: " + float3ToInt);

            int int3 = -1;
            uint int3ToUInt = (uint)int3;
            Console.WriteLine("int3ToUInt: " + int3ToUInt);
            // int3 이진수 : 1111 1111 1111 1111 1111 1111 1111 1111
            // unsigned로 바꾸면 양의 정수 최댓값이 된다
        }
    }
}