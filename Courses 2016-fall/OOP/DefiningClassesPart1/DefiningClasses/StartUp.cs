﻿using Ninject;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            var kernel = new StandardKernel(new GsmModule());
            

            ////Gsm myPhone = new Gsm("THL", "China", "Niki", 200.5M,
            ////    new Battery(BatteryType.Li_Ion, 60, 20),
            ////    new Display(5.5M, 16000000));
            ////Console.WriteLine(myPhone);

            ////Console.WriteLine(Gsm.IPhone4S);

            ////GsmTest.GsmTestPrint();

            CallHistoryTest.CallHistoryTestPrint();
        }
    }
}
