using System;
namespace ExamSystem
{
    public abstract class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }

        protected Question(string header, string body, int mark, Answer[] answers, Answer rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = answers;
            RightAnswer = rightAnswer;
        }

        public abstract void DisplayQuestion();

        public object Clone() => this.MemberwiseClone();

        public int CompareTo(Question other) => other == null ? 1 : this.Mark.CompareTo(other.Mark);

        public override string ToString() => $"{Header} (Mark: {Mark})\n{Body}";
    }
}
