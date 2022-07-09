using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior("David");

            warrior.Introduce();
            warrior.GetStatus();


            // 컴파일 오류
            // Name 프로퍼티는 private set을 사용하기 때문에
            // Warrior 클래스 밖에서 설정(set)할 수 없다.
            // warrior.Name = "Peter";

            warrior.SwordStrike();
            warrior.UseWhirlwind();
            warrior.UseWhirlwind();
            warrior.UseWhirlwind();
            warrior.Rest();

            warrior.GetStatus();

            // Health 프로퍼티 public set
            warrior.Health -= 200;

            // 컴파일 오류
            // mHealth 멤버 변수는 private
            // warrior.mHealth = 5000;

            warrior.GetStatus();
        }
    }
}