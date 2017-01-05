namespace Timer
{
    using System;
    using System.Diagnostics;

    public class Timer
    {
        private int seconds;

        public Timer(int seconds)
        {
            this.Seconds = seconds;
        }

        private delegate void SayTime();

        public int Seconds
        {
            get
            {
                return this.seconds;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Second interval cannot be negative!");
                }

                this.seconds = value;
            }
        }

        public static void SayTheTime()
        {
            Console.WriteLine("The time is : " + DateTime.Now.TimeOfDay);
        }

        public void Invoke()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            var printTime = new SayTime(SayTheTime);

            while (true)
            {
                if (timer.Elapsed.Seconds != this.seconds)
                {
                    continue;
                }

                printTime.Invoke();
                timer.Restart();
            }
        }
    }
}
