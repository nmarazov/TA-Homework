using System;

namespace Exceptions_Homework
{
    public class ExamResult
    {
        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            if (grade < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(grade), "Grade can not be negative.");
            }

            if (minGrade < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(minGrade), "MinGrade can not be negative.");
            }

            if (maxGrade <= minGrade)
            {
                throw new ArgumentOutOfRangeException(nameof(maxGrade), "MaxGrade can not less than MinGrade.");
            }

            if (string.IsNullOrEmpty(comments))
            {
                throw new ArgumentNullException(nameof(comments), "Comment for ExamResult can not be null or empty.");
            }

            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade { get; private set; }

        public int MinGrade { get; private set; }

        public int MaxGrade { get; private set; }

        public string Comments { get; private set; }
    }
}
