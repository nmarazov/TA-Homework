﻿namespace DefiningClasses
{
    using Model.DefiningClasses;
    using System;

    class StartUp
    {
        static void Main()
        {
            Gsm myPhone = new Gsm("THL", "China", "Niki", 200.5M,
                new Battery(BatteryType.Li_Ion, 60, 20),
                new Display(5.5M, 16000000));
            Console.WriteLine(myPhone);

            Console.WriteLine(Gsm.IPhone4S);

            GsmTest.GsmTestPrint();

            myPhone.AddCall(DateTime.Now, 0883363636, 95);
            myPhone.AddCall(DateTime.Now, 0883363688, 150);

            Console.WriteLine(myPhone.CallHistory);
        }
    }
}
