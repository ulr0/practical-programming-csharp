using System;
using System.IO;

namespace ParseTextMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            // ReadAllLines 메서드도 있다.
            // string textMessage = File.ReadAllLines(@"TextMessage.txt");
            // ReadAllLines() : 각 줄마다 분리해서 배열 반환
            string textMessage = File.ReadAllText(@"TextMessage.txt");

            // textMessage를 여러 줄로 분리
            string[] lines = textMessage.Split('\n');

            // 날짜, 시간 저장
            string[] dateTimeString = lines[1].Split(' '); // [ "Sunday", "2022-06-19", "17:00:00.000" ]
            string nameOfDay = dateTimeString[0]; // "Sunday"
            string[] date = dateTimeString[1].Split('-'); // [ "2022", "06", "19" ]

            int year = int.Parse(date[0]);
            int month = int.Parse(date[1]);
            int day = int.Parse(date[2]);

            string[] time = dateTimeString[2].Split(':'); // [ "17", "00", "00.000" ]

            int hours = int.Parse(time[0]);
            int mins = int.Parse(time[1]);
            float seconds = float.Parse(time[2]);

            string email = lines[2].Trim();

            string courseCode = lines[3].Replace("Course", "").Trim();
            string term = lines[4].Replace("Term", "").Trim();

            Console.WriteLine($"Name of Day: {nameOfDay}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"Month: {month}");
            Console.WriteLine($"Day: {day}");
            Console.WriteLine($"Hours: {hours}");
            Console.WriteLine($"Minutes: {mins}");
            Console.WriteLine($"Seconds: {seconds}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Course Code: {courseCode}");
            Console.WriteLine($"Term: {term}");
        }
    }
}