using System;

namespace StaticMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CourseCode courseCode1 = new CourseCode(ESubject.COMP, 3200);

            Console.WriteLine($"{courseCode1.Subject} {courseCode1.Number}");

            // static method 사용
            CourseCode courseCode2 = CourseCode.Parse("MATH1100");
            Console.WriteLine($"{courseCode2.Subject} {courseCode2.Number}");

            // 예외 발생
            // CourseCode.Parse("Not CourseCode");

            CourseCode courseCode3;
            bool bParsed = CourseCode.TryParse("Not CourseCode", out courseCode3);

            Console.WriteLine($"Parsed: {bParsed}");

            CourseCode courseCode4;
            bParsed = CourseCode.TryParse("MATH9999", out courseCode4);

            Console.WriteLine($"Parsed: {bParsed}");
            Console.WriteLine($"{courseCode4.Subject} {courseCode4.Number}");
        }
    }
}