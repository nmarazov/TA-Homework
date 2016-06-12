namespace Model.DefiningClasses
{
    using System;
    using System.Text;

    public class Battery
    {
        private int? hoursIdle;
        private int? hoursTalk;

        public Battery()
        {
        }

        public Battery(BatteryType? batteryType, int? hoursIdle, int? hoursTalk)
        {
            this.Type = batteryType;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }
        
        public BatteryType? Type { get; set; }

        public int? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Must be positive number");
                }

                this.hoursIdle = value;
            }
        }

        public int? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Must be positive number");
                }

                this.hoursTalk = value;
            }
        }

        public override string ToString()
        {
            var print = new StringBuilder();

            if (Type != null)
            {
                print.AppendFormat("    Type: {0}\n\r", this.Type);
            }

            if (HoursIdle != null)
            {
                print.AppendFormat("    HoursIdle: {0}\n\r", this.HoursIdle);
            }

            if (HoursTalk != null)
            {
                print.AppendFormat("    HoursTalk: {0}\n\r", this.HoursTalk);
            }

            return print.ToString();
        }
    }
}
