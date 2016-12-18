using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions_Homework
{
    public class ExceptionsHomework
    {
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            if (startIndex < 0 || arr.Length - 1 < startIndex)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), $"Start index must be bwtween {0} and {arr.Length - 1}");
            }

            if (arr.Length < count || startIndex + count > arr.Length - 1)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "Number of elements to display is too much.");
            }

            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }

            return result.ToArray();
        }

        public static string ExtractEnding(string str, int count)
        {
            if (count > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "Count for extracting string can not be bigger than string length!");
            }

            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }

        public static void CheckPrime(int number)
        {
            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    throw new ArgumentException($"The number {number} is not prime!");
                }
            }
        }

        public static void Main()
        {
            try
            {
                var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
                Console.WriteLine(substr);

                var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
                Console.WriteLine(string.Join(" ", subarr));

                var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
                Console.WriteLine(string.Join(" ", allarr));

                var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
                Console.WriteLine(string.Join(" ", emptyarr));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Extracting Substring
            try
            {
                Console.WriteLine(ExtractEnding("I love C#", 2));
                Console.WriteLine(ExtractEnding("Nakov", 4));
                Console.WriteLine(ExtractEnding("beer", 4));
                Console.WriteLine(ExtractEnding("Hi", 100));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Prime Check
            int numberToCheck = 3;
            try
            {
                CheckPrime(numberToCheck);
                Console.WriteLine($"{numberToCheck} is prime.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Creating new student and calculating average result
            try
            {
                List<Exam> peterExams = new List<Exam>()
                {
                    new SimpleMathExam(2),
                    new CSharpExam(55),
                    new CSharpExam(100),
                    new SimpleMathExam(1),
                    new CSharpExam(0),
                };

                Student peterStudent = new Student("Peter", "Petrov", peterExams);
                double peterAverageResult = peterStudent.CalcAverageExamResultInPercents();
                Console.WriteLine($"Average results = {peterAverageResult:p0}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            try
            {
                List<Exam> ivanExams = new List<Exam>()
                {
                };
                Student ivanStudent = new Student("Ivan", "Ivanov", ivanExams);
                ivanStudent.CheckExams();
                double ivanAverageResult = ivanStudent.CalcAverageExamResultInPercents();
                Console.WriteLine($"Average results = {ivanAverageResult:p0}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}