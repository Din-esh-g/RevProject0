using System;
using System.Collections.Generic;
using System.Text;

namespace Project0_Revature
{
    public static class Deposit
    {
        public static double _openBalance;
        public static double _deposit;
       
     

        public static double AmtDeposit()
        {
            Console.WriteLine("Please Enter your Amount to deposit");
            _deposit = Convert.ToDouble(Console.ReadLine());
            return _deposit;
        }


       
    }
}
