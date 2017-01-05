namespace Timer
{
    public class Startup
    {
        public static void Main()
        {
            Timer timer = new Timer(3); // <-- Change seconds here
            timer.Invoke();
        }
    }
}
