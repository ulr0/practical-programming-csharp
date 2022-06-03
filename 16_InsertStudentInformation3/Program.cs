using System;

namespace InsertStudentInformation3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's fill out student information.");
            string[] names = new string[3];
            string[] studentNumbers = new string[3];
            int[] grades = new int[3];

            Console.WriteLine("Let's fill out information for student1");

            Console.Write("Name: ");
            names[0] = Console.ReadLine();

            Console.Write("Student Number: ");
            studentNumbers[0] = Console.ReadLine();

            Console.Write("Grade: ");
            grades[0] = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Let's fill out information for student2");

            Console.Write("Name: ");
            names[1] = Console.ReadLine();

            Console.Write("Student Number: ");
            studentNumbers[1] = Console.ReadLine();

            Console.Write("Grade: ");
            grades[1] = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Let's fill out information for student3");

            Console.Write("Name: ");
            names[2] = Console.ReadLine();

            Console.Write("Student Number: ");
            studentNumbers[2] = Console.ReadLine();

            Console.Write("Grade: ");
            grades[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"1    {names[0], -20}    {studentNumbers[0], -20}    {grades[0]}%");
            Console.WriteLine($"2    {names[1], -20}    {studentNumbers[1], -20}    {grades[1]}%");
            Console.WriteLine($"3    {names[2], -20}    {studentNumbers[2], -20}    {grades[2]}%");
        }
    }
}