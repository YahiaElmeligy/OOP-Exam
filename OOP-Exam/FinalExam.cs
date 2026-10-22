using System;
using System.Diagnostics;

namespace ExamSystem
{
    public class FinalExam : Exam
    {
        public FinalExam(int time, int numOfQuestions) : base(time, numOfQuestions) { }

        public override void ShowExam()
        {
            Console.WriteLine("Final Exam");
            Stopwatch sw = Stopwatch.StartNew();

            int[] userAnswers = new int[Questions.Length];
            int obtainedMarks = 0;
            int totalMarks = 0;

            for (int i = 0; i < Questions.Length; i++)
            {
                Questions[i].DisplayQuestion();
                userAnswers[i] = int.Parse(Console.ReadLine());
                totalMarks += Questions[i].Mark;
                Console.WriteLine();
            }

            sw.Stop();

            Console.WriteLine("Final Exam Results:");
            for (int i = 0; i < Questions.Length; i++)
            {
                bool isCorrect = userAnswers[i] == Questions[i].RightAnswer.AnswerId;
                if (isCorrect) obtainedMarks += Questions[i].Mark;

                Console.WriteLine($"Question {i + 1}: {Questions[i].Body}");
                Console.WriteLine($"Your Answer => {Questions[i].AnswerList[userAnswers[i] - 1].AnswerText}");
                Console.WriteLine($"Correct Answer => {Questions[i].RightAnswer.AnswerText}\n");
            }

            Console.WriteLine($"Your Grade is {obtainedMarks} from {totalMarks}");
            Console.WriteLine($"Time = {sw.Elapsed}");
            Console.WriteLine("Thank you");
        }
    }
}