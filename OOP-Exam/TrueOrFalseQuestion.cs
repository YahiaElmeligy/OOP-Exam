using System;

namespace ExamSystem
{
    public class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion(string header, string body, int mark, Answer[] answers, Answer rightAnswer)
            : base(header, body, mark, answers, rightAnswer) { }

        public override void DisplayQuestion()
        {
            Console.WriteLine($"True | False Question:     Mark {Mark}");
            Console.WriteLine($"True/False Question: {Body}");
            foreach (var ans in AnswerList)
            {
                Console.WriteLine($"{ans.AnswerId}- {ans.AnswerText}");
            }
            Console.Write("Enter your answer ID: ");
        }
    }
}