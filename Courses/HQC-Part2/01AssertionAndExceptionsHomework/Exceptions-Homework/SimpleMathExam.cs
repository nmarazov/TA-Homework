using System;

namespace Exceptions_Homework
{
    public class SimpleMathExam : Exam
    {
        public SimpleMathExam(int problemsSolved)
        {
            if (problemsSolved < 0 || 10 < problemsSolved)
            {
                throw new ArgumentOutOfRangeException(nameof(problemsSolved), "Problem solved in SimpleMathExam must be between 0 and 10");
            }

            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved { get; private set; }

        public override ExamResult Check()
        {
            switch (this.ProblemsSolved)
            {
                case 0:
                    return new ExamResult(2, 2, 6, "Bad result: nothing done.");
                case 1:
                    return new ExamResult(4, 2, 6, "Average result: nothing done.");
                case 2:
                    return new ExamResult(6, 2, 6, "Average result: nothing done.");
                default:
                    return new ExamResult(0, 0, 0, "Invalid number of problems solved!");
            }
        }
    }
}
