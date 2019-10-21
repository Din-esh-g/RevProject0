using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Project0_Revature
{
    public static class AccountCreation
    {
        public static int _accountNumber;
        public static int _totalAccount;
        public static int _noOfChecking;
        public static int _noOfLoan;
        public static int _noOfCD;
        //public static IList<int, string> accountCollection = new IList<int, string>();
        public static Dictionary<double, string> accountCollection = new Dictionary<double, string>();

        public static int AccountNumber()
        {
            Console.WriteLine("Please Enter the amount you want put in the open: ");
            Deposit._openBalance = Convert.ToDouble(Console.ReadLine());
            Random random = new System.Random();
            _accountNumber = random.Next(100907, 2100907);

            var test = _accountNumber.ToString();
            accountCollection.Add(Deposit._openBalance, "_accountNumber");


            _totalAccount++;
            return _accountNumber;
        }


    }
}
