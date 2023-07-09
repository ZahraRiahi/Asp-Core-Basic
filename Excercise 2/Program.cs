
using System;

class Program
{
    static void Main(string[] args)
    {
        // The first method
    Console.WriteLine("The first method");

      string[] studentNames = new string[5];
        double[] studentGrades = new double[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter student name #{0}: ", i+1);
            studentNames[i] = Console.ReadLine();

            Console.Write("Enter grade for {0}: ", studentNames[i]);
            studentGrades[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nStudent names and grades entered:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("{0}. {1} - {2}", i+1, studentNames[i], studentGrades[i]);
        }
    
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("The second method");
               string[,] students = new string[5, 2];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter student name #{0}: ", i+1);
            students[i, 0] = Console.ReadLine();

            Console.Write("Enter grade for {0}: ", students[i, 0]);
            students[i, 1] = Console.ReadLine();
        }

        Console.WriteLine("\nStudent names and grades entered:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("{0}. {1} - {2}", i+1, students[i, 0], students[i, 1]);
        }
    }



    
}