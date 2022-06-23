using System;

namespace FunctionOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo();
            Foo(10);
            Foo("hi");
            Foo("hi", "C#", "programming");
        }

        static void Foo()
        {
            Console.WriteLine("Foo with no arguments.");
        }

        static void Foo(int x)
        {
            Console.WriteLine($"Foo with {typeof(int).Name}: {x} as arguments.");
        }

        // 오버로딩 불가능
        // 함수 시그니처(함수 이름, 매개변수 목록)가 같은 함수가 이미 존재하기 때문에 컴파일 오류 발생
        // static int Foo(int x)
        // {
        //     return x + 1;
        // }

        static void Foo(string s)
        {
            Console.WriteLine($"Foo with {typeof(string).Name}: {s} as an argument.");
        }

        static void Foo(string s1, string s2, string s3)
        {
            Console.WriteLine($"Foo with {typeof(string).Name}: {s1}, {typeof(string).Name}: {s2}, {typeof(string).Name}: {s3} as an argument.");
        }
    }
}