/*
    byte = 8비트 정수
    short = 16비트 정수
    int = 32비트 정수
    long = 62비트 정수

    float = 32비트 실수
    double = 64비트 실수

    char = 16비트 문자
*/

using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int int1 = 33;
            int int2 = 77;

            float float1 = 12.4f;
            float float2 = 5.55f;

            double double1 = 99.999;
            double double2 = 5.43;

            char char1 = '!';

            Console.WriteLine(int1 + "+" + int2 + "=" + (int1 + int2));
            Console.WriteLine(float1 + "-" + float2 + "=" + (float1 + float2));
            Console.WriteLine(double1 + "+" + double2 + "=" + (double1 + double2));
            Console.WriteLine(char1);
        }
    }
}