using System;

namespace ExamSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub = new Subject(101, "OOP Programming");
            sub.CreateExam();

            Console.WriteLine("\nDo You Want To Start Exam (Y | N)");
            char choice = char.Parse(Console.ReadLine());

            if (choice == 'y' || choice == 'Y')
            {
                Console.Clear();
                sub.ExamOfSubject.ShowExam();
            }

            Console.WriteLine("\nPress any key to close this window . . .");
            Console.ReadKey();
        }
    }
}