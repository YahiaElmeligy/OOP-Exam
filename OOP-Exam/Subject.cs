using System;

namespace ExamSystem
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam ExamOfSubject { get; set; }

        public Subject(int id, string name)
        {
            SubjectId = id;
            SubjectName = name;
        }

        public void CreateExam()
        {
            Console.WriteLine("Enter the type of exam (1 for Practical, 2 for Final):");
            int examType = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the time for the exam (30 to 180 minutes):");
            int time = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the number of questions:");
            int numQ = int.Parse(Console.ReadLine());

            Question[] questions = new Question[numQ];

            for (int i = 0; i < numQ; i++)
            {
                if (examType == 2) // Final Exam
                {
                    Console.WriteLine($"Enter details for question {i + 1}:");
                    Console.WriteLine("Choose question type: 1 for MCQ, 2 for True/False:");
                    int qType = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter the question body:");
                    string body = Console.ReadLine();

                    Console.WriteLine("Please enter the question mark:");
                    int mark = int.Parse(Console.ReadLine());

                    if (qType == 1) // MCQ
                    {
                        Console.WriteLine("Choices of Question:");
                        Answer[] mcqAnswers = new Answer[4];
                        for (int a = 0; a < 4; a++)
                        {
                            Console.WriteLine($"Please enter choice number {a + 1}:");
                            mcqAnswers[a] = new Answer(a + 1, Console.ReadLine());
                        }

                        Console.WriteLine("Please enter the ID of the correct answer (1 to 4):");
                        int rightId = int.Parse(Console.ReadLine());

                        questions[i] = new McqQuestion("", body, mark, mcqAnswers, mcqAnswers[rightId - 1]);
                    }
                    else // True / False
                    {
                        Answer[] tfAnswers = new Answer[]
                        {
                            new Answer(1, "True"),
                            new Answer(2, "False")
                        };

                        Console.WriteLine("Please enter the ID of the correct answer (1 for True, 2 for False):");
                        int rightId = int.Parse(Console.ReadLine());

                        questions[i] = new TrueOrFalseQuestion("", body, mark, tfAnswers, tfAnswers[rightId - 1]);
                    }
                }
                else // Practical Exam
                {
                    Console.WriteLine("Please enter the question body:");
                    string body = Console.ReadLine();

                    Console.WriteLine("Please enter the question mark:");
                    int mark = int.Parse(Console.ReadLine());

                    Console.WriteLine("Choices of Question:");
                    Answer[] mcqAnswers = new Answer[4];
                    for (int a = 0; a < 4; a++)
                    {
                        Console.WriteLine($"Please enter choice number {a + 1}:");
                        mcqAnswers[a] = new Answer(a + 1, Console.ReadLine());
                    }

                    Console.WriteLine("Please enter the ID of the correct answer (1 to 4):");
                    int rightId = int.Parse(Console.ReadLine());

                    questions[i] = new McqQuestion("", body, mark, mcqAnswers, mcqAnswers[rightId - 1]);
                }
            }

            ExamOfSubject = examType == 2 ? new FinalExam(time, numQ) : new PracticalExam(time, numQ);
            ExamOfSubject.Questions = questions;
        }
    }
}