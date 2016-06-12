namespace Model.DefiningClasses
{
    using System;
    using System.Text;

    public class Display
    {
        private decimal? size;
        private int? numberOfColors;

        public Display()
        {
        }

        public Display(decimal? size, int? numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }
        
        public decimal? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value < 1 || value > 7)
                {
                    throw new ArgumentOutOfRangeException("Size of the display must be between 1 and 7 inch");
                }

                this.size = value;
            }
        }

        public int? NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value < 2)
                {
                    throw new ArgumentOutOfRangeException("Number of colors must be more than 2 because even 1 bit color scheme has 2 colors");
                }

                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            var print = new StringBuilder();

            if (Size != null)
            {
                print.AppendFormat("    Size: {0:F1}inch\n\r", this.Size);
            }

            if (NumberOfColors != null)
            {
                print.AppendFormat("    Number of colors: {0:N0}\n\r", this.NumberOfColors);
            }
            return print.ToString();
        }
    }
}
