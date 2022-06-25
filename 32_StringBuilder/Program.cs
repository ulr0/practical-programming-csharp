using System;
using System.Text;

namespace StringBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CAPACITY = 1024;
            // StringBuilder가 만드는 실제 문자열의 길이는 CAPACITY를 넘어설 수 있다.
            StringBuilder builder = new StringBuilder(CAPACITY);
            builder.Append("Hello!");
            builder.AppendLine(" Hi~~~");
            builder.AppendLine("Bye~");

            Console.WriteLine(builder.ToString());

            builder.Insert(6, " Going to insert this here.");

            Console.WriteLine(builder.ToString());

            builder.Replace(" Going to insert this here.", " And replace this.");

            Console.WriteLine(builder.ToString());

            // index 6번부터 18개 글자를 지운다.
            // index 6번부터 18번까지 지우는 거 아님.
            builder.Remove(6, 18);

            Console.WriteLine(builder.ToString());

            builder.Clear();

            Console.WriteLine(builder.ToString());
        }
    }
}