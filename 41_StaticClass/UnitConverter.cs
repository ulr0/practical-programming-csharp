using System;

namespace StaticClass
{
    public static class UnitConverter
    {
        public static double GetInchesFromCentimeters(double centimeters)
        {
            return centimeters * 0.393701;
        }

        public static double GetCentimetersFromInches(double inches)
        {
            return inches / 0.393701;
        }

        public static double GetMetersFromCentimeters(double centimeters)
        {
            return centimeters / 100;
        }

        public static double GetFeetFromInches(double inches)
        {
            return inches / 12;
        }

        // 컴파일 오류
        // 정적 클래스는 개체를 만들 수 없기 때문에 개체 인스턴스에 속한 함수 만들거나 쓸 수 없음
        // public void SomeMethod()
        // {
        //     Console.WriteLine("Won't Compile!");
        // }
    }
}