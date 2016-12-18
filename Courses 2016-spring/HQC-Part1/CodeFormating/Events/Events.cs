﻿namespace Events
{
    using System;
    using System.Text;

    public class Event : IComparable
    {
        private DateTime date;
        private string title;
        private string location;

        public Event(DateTime date, string title, string location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            int byDate = this.date.CompareTo(other.date);
            int byTitle = this.title.CompareTo(other.title);

            int byLocation = this.location.CompareTo(other.location);
            if (byDate == 0)
            {
                if (byTitle == 0)
                {
                    return byLocation;
                }
                else
                {
                    return byTitle;
                }
            }
            else
            {
                return byDate;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));
            result.Append(" | " + this.title);

            if (!string.IsNullOrEmpty(this.location))
            {
                result.Append(" | " + this.location);
            }

            return result.ToString();
        }
    }
}