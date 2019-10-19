using System;
using System.Collections.Generic;
using System.Text;

namespace Project0_Revature
{
    public static class Deposit
    {
        public static double _openBalance;
        public static double _deposit;
        public static double _closeBalance;
        public static double _loanRepay;
        public static double _interest;
        public static double _withdraw;

        public static double AmtDeposit()
        {
            Console.WriteLine("Please Enter your Amount to deposit");
            _deposit = Convert.ToDouble(Console.ReadLine());
            return _deposit;
        }


        public static double Balance1()
        {
            _closeBalance = _openBalance + _deposit - _withdraw;
            return _closeBalance;
        }
    }
}
