using System;

namespace PartialClass
{
    public partial class Robot
    {
        // Robot.LeftArm.cs에 생성자가 이미 정의되어 있어서
        // 이 파일에서 생성자 정의 불가 
        // public Robot(string name)
        // {
        //     Name = name;
        // }

        // Robot.LeftArm.cs에 이미 정의된 함수라서 이 파일에서 정의 불가
        // 결국 하나의 Class이기 때문에 동일한 이름의 함수, 변수 만들 수 없음
        // public void ShootLaserBeem()
        // {
        //     Console.WriteLine($"{Name} shooting laser beem!");
        // }

        public void Nuke()
        {
            Console.WriteLine($"{Name}: Nuclear launch detected!");
        }
    }
}