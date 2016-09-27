using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2MethodPrintStatistics
{
    public class PrintStatistics
    {
        private readonly double[] numbers;

        public PrintStatistics(double[] numbers)
        {
            this.numbers = numbers;
        }

        public double MaxNumber => this.numbers.Max();

        public double MinNumber => this.numbers.Min();

        public double Avarage => this.numbers.Average();

        public double[] Numbers => numbers;

        public void Print()
        {
            
        }
    }
}
