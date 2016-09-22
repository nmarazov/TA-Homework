using System;
using System.Collections.Generic;
using System.Linq;

namespace Exceptions_Homework
{
    public class Student
    {
        public Student(string firstName, string lastName, IList<Exam> exams = null)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                throw new ArgumentNullException(nameof(firstName), "First name can not be null or empty!");
            }

            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentNullException(nameof(lastName), "Last name can not be null or empty!");
            }

            this.FirstName = firstName;
            this.LastName = lastName;
            this.Exams = exams;
        }

        public string FirstName { get; }

        public string LastName { get; }

        public IList<Exam> Exams { get; }

        public IList<ExamResult> CheckExams()
        {
            if (this.Exams == null)
            {
                throw new ArgumentNullException(nameof(this.Exams), "Exams can not be null!");
            }

            if (this.Exams.Count == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(this.Exams.Count), $"Student {this.FirstName} {this.LastName} has 0 exams!");
            }

            IList<ExamResult> results = new List<ExamResult>();
            foreach (Exam exam in this.Exams)
            {
                results.Add(exam.Check());
            }

            return results;
        }

        public double CalcAverageExamResultInPercents()
        {
            if (this.Exams == null)
            {
                // Cannot calculate average on missing exams
                throw new ArgumentNullException($"Exams list for {this.FirstName} {this.LastName} is null.");
            }

            if (this.Exams.Count == 0)
            {
                // No exams --> return -1;
                throw new ArgumentOutOfRangeException(nameof(this.Exams.Count), $"There is no exams added for {this.FirstName} {this.LastName}.");
            }

            double[] examScore = new double[this.Exams.Count];
            IList<ExamResult> examResults = this.CheckExams();
            for (int i = 0; i < examResults.Count; i++)
            {
                examScore[i] = 
                    ((double)examResults[i].Grade - examResults[i].MinGrade) / 
                    (examResults[i].MaxGrade - examResults[i].MinGrade);
            }

            return examScore.Average();
        }
    }
}
