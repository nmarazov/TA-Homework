namespace Model.DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Gsm
    {
        private static readonly Gsm iPhone4S = new Gsm("iPhone 4S", "Apple", "Ivan", 500,  
            new Battery(BatteryType.Li_Ion, 48, 24), 
            new Display(4.5M, 16000000));

        private string model;
        private string manufacturer;
        private decimal? price;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;

        public Gsm(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.callHistory = new List<Call>();
        }

        public Gsm(string model, string manufacturer, string owner, decimal? price, Battery battery, Display display)
            :this(model, manufacturer)
        {
            this.Owner = owner;
            this.Price = price;
            this.battery = battery;
            this.display = display;
        }

        public static Gsm IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Model must be set");
                }
                if (value.Length < 3 || value.Length > 12)
                {
                    throw new FormatException("Model must be longer than 3 and shorter than 12 characters");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Manufacturer must be set");
                }
                if (value.Length < 3)
                {
                    throw new FormatException("Manufacturer must be at least 3 characters long");
                }

                this.manufacturer = value;
            }
        }

        public string Owner { get; set; }

        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Price must be a positive number");
                }

                this.price = value;
            }
        }

        public string CallHistory
        {
            get
            {
                var callInfo = new StringBuilder();
                callInfo.AppendFormat("{0} calls in CallHistory\n\r", callHistory.Count);

                for (int i = 0; i < callHistory.Count; i++)
                {
                    callInfo.AppendFormat("Call {0} from {1} at {2}\n\r", i + 1, callHistory[i].Date, callHistory[i].Time);
                    callInfo.AppendFormat("Number: {0}\n\r", callHistory[i].PhoneNumber);
                    callInfo.AppendFormat("Duration: {0}\n\r", callHistory[i].Duration);
                }

                return callInfo.ToString();
            }
            set
            {    
            }
        }

        public void AddCall(DateTime dateTime, int phoneNumber, int duration)
        {
            callHistory.Add(new Call(dateTime,phoneNumber,duration));
        }

        public void DeleteCall(int Id)
        {
            this.callHistory.RemoveAt(Id - 1);
        }

        public void ClearCallHistory()
        {
            callHistory = new List<Call>();
        }

        public override string ToString()
        {
            var print = new StringBuilder();

            print.AppendFormat("Model: {0}\n\r", this.Model);
            print.AppendFormat("Manufacturer: {0}\n\r", this.Manufacturer);

            if (Owner != null)
            {
                print.AppendFormat("Owner: {0}\n\r", this.Owner);
            }
            if (Price != null)
            {
                print.AppendFormat("Price: {0:C}\n\r", this.Price);
            }

            print.AppendFormat("Battery:\n\r{0}", this.battery);
            print.AppendFormat("Display:\n\r{0}", this.display);

            return print.ToString();
        }
    }
}
