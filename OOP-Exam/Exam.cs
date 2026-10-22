using System;
namespace ExamSystem
{
    public abstract class Exam
    {
        public int TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }

        protected Exam(int time, int numOfQuestions)
        {
            TimeOfExam = time;
            NumberOfQuestions = numOfQuestions;
        }

        public abstract void ShowExam();
    }
}
