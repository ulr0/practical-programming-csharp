using System;

namespace ArrayOfArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MONTHS_IN_A_YEAR = 12;
            int[] daysInEachMonth = new int[MONTHS_IN_A_YEAR] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            string[][] calender = new string[MONTHS_IN_A_YEAR][];

            for (int i = 0; i < calender.Length; ++i)
            {
                calender[i] = new string[daysInEachMonth[i]];
            }

            while (true)
            {
                Console.Write("Enter the Month(1 - 12): ");
                int month = int.Parse(Console.ReadLine());

                if (month <= 0 || month > 12)
                {
                    Console.WriteLine("Invalid range of month. Terminating program.");
                    break;
                }

                Console.Write($"Enter the day(1 - {calender[month - 1].Length}): ");
                int day = int.Parse(Console.ReadLine());

                if (day <= 0 || day > calender[month - 1].Length)
                {
                    Console.WriteLine("Invalid range of day. Terminating program.");
                    break;
                }

                Console.Write("Enter your schedule: ");
                string schedule = Console.ReadLine();
                calender[month - 1][day - 1] = schedule;

                Console.WriteLine("-----------------------------------------------------------");

                for (int i = 0; i < calender.Length; ++i)
                {
                    for (int j = 0; j < calender[i].Length; ++j)
                    {
                        if (!string.IsNullOrEmpty(calender[i][j]))
                        {
                            Console.WriteLine($"Your schedule on {i + 1} / {j + 1}: {calender[i][j]}");
                        }
                    }
                }

                Console.WriteLine("------------------------------------------------------------");
            }
        }
    }
}