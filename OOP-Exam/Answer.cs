using System;
namespace ExamSystem
{
    public class Answer : ICloneable, IComparable<Answer>
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answer(int id, string text)
        {
            AnswerId = id;
            AnswerText = text;
        }

        public object Clone() => new Answer(this.AnswerId, this.AnswerText);

        public int CompareTo(Answer other) => other == null ? 1 : this.AnswerId.CompareTo(other.AnswerId);

        public override string ToString() => $"ID: {AnswerId}, Answer: {AnswerText}";
    }
}
