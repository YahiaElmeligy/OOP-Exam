using System;

namespace ExamSystem
{
    public class McqQuestion : Question
    {
        public McqQuestion(string header, string body, int mark, Answer[] answers, Answer rightAnswer)
            : base(header, body, mark, answers, rightAnswer) { }

        public override void DisplayQuestion()
        {
            Console.WriteLine($"Question 1: {Body}");
            Console.WriteLine($"MCQ Question:     Mark {Mark}");
            foreach (var ans in AnswerList)
            {
                Console.WriteLine($"{ans.AnswerId}- {ans.AnswerText}");
            }
            Console.Write("Enter your answer ID: ");
        }
    }
}