namespace Model.DefiningClasses
{
    using System;
    using System.Collections.Generic;

    public class Call
    {
        public Call(DateTime dateTime, int phoneNumber, int duration)
        {
            this.Date = dateTime.ToShortDateString();
            this.Time = dateTime.ToShortTimeString();
            this.PhoneNumber = phoneNumber;
            this.Duration = duration;
        }

        public string Date { get; set; }

        public string Time { get; set; }

        public int PhoneNumber { get; set; }

        public int Duration { get; set; }
    }
}
