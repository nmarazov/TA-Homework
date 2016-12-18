namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using Model.DefiningClasses;

    public class GsmTest
    {
        public static void GsmTestPrint()
        {
            var phoneCollection = new List<Gsm>();

            phoneCollection.Add(new Gsm(
                "Galaxy5S", "Samsung", "Pesho", 400M, new Battery(BatteryType.Li_Po, 70, 24), new Display(5.5M, 16000000)));
            phoneCollection.Add(new Gsm(
                "Lumia510", "Nokia", "Gosho", 100M, new Battery(BatteryType.NiCd, 62, 18), new Display(5M, 254000)));
            phoneCollection.Add(new Gsm(
                "Wl8", "THL", "Niki", 200M, new Battery(BatteryType.NiMH, 60, 20), new Display(5M, 16000000)));
            phoneCollection.Add(new Gsm(
                "IPhone6S", "Apple", "Penka", 600M, new Battery(BatteryType.Li_Ion, null, 24), new Display(4.7M, 16000000)));

            foreach (Gsm phone in phoneCollection)
            {
                Console.WriteLine(phone);
            }

            Console.WriteLine(Gsm.IPhone4S);
        }
    }
}
