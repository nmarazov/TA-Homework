using Model.DefiningClasses.Models;
using Model.DefiningClasses.Models.Enums;

namespace DefiningClasses
{
    using System;
    using System.Text;
    using Model.DefiningClasses;

    public class CallHistoryTest
    {
        public static void CallHistoryTestPrint()
        {
            var myPhone = new Gsm(
                "THL", "China", "Niki", 200.5M, new Battery(BatteryType.Li_Ion, 60, 20), new Display(5.5M, 16000000));

            Console.WriteLine(myPhone);

            myPhone.AddCall(DateTime.Now, 0885998877, 65);
            myPhone.AddCall(DateTime.UtcNow, 0885665544, 98);
            myPhone.AddCall(DateTime.Now, 0885552277, 158);
            myPhone.AddCall(DateTime.Now, 0885996857, 112);
            myPhone.AddCall(DateTime.Now, 0885995827, 87);

            Console.WriteLine(myPhone.CallHistory);

            var priceInfo = new StringBuilder();

            priceInfo.AppendFormat("Total price: {0:C2}", myPhone.CallPrice());

            myPhone.RemoveLongestCall();

            priceInfo.AppendFormat(Environment.NewLine);
            priceInfo.AppendFormat("Longest Call removed");
            priceInfo.AppendFormat(Environment.NewLine);
            priceInfo.AppendFormat("Total price: {0:C2}", myPhone.CallPrice());

            myPhone.ClearCallHistory();

            Console.WriteLine(priceInfo);
            Console.WriteLine(myPhone.CallHistory);
        }
    }
}
