using System;

namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot("Vision");

            Console.WriteLine(robot.Name);

            robot.ShootLaserBeem();
            robot.ShootMissiles();
            robot.Nuke();
        }
    }
}