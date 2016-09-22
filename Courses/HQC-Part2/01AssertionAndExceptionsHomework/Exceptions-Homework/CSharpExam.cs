using System;

namespace Exceptions_Homework
{
    public class CSharpExam : Exam
    {
        public CSharpExam(int score)
        {
            if (score < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(score), "Points for C# exam must be positive number.");
            }

            this.Score = score;
        }

        public int Score { get; private set; }

        public override ExamResult Check()
        {
            if (this.Score < 0 || 100 < this.Score)
            {
                throw new ArgumentOutOfRangeException(nameof(this.Score), "Score must be between 0 and 100.");
            }
            else
            {
                return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
            }
        }
    }
}
