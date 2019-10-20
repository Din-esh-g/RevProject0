using System;
using System.Collections.Generic;
using System.Text;

namespace Project0_Revature
{
    
    public static class Checking
    {
        public static double _chkDepo { get; set; }
        public static double _chkWithdraw { get; set; }
        public static double _chkTransfer { get; set; }
        public static double _chkTransferOut { get; set; }
        public static double _chkBalance { get; set; }
        public static void chekingAccount()

        {
            var newAccountN = AccountCreation.AccountNumber();
            var chAccount = "CHK-" + newAccountN;


        }
      
        public static double depositChk()
        {
            Console.WriteLine("Please Enter your amount to deposit");
            _chkDepo = Convert.ToDouble(Console.ReadLine());
            return _chkDepo;

           
        }

        public static double withdrawChk()
        {
            Console.WriteLine("Please Enter your amount to Withdraw");
            _chkWithdraw = Convert.ToDouble(Console.ReadLine());
            return _chkWithdraw;
            
        }

        public static double transferinChk()
        {
            Console.WriteLine("Please Enter your amount to transfer in");
            _chkTransfer = Convert.ToDouble(Console.ReadLine());
            return _chkTransfer;

        }
        public static double transferoutChk()
        {
            Console.WriteLine("Please Enter your amount to transfer Out");
            _chkTransferOut = Convert.ToDouble(Console.ReadLine());
            return _chkTransferOut;

        }
        public static double balanceChk()
        {

            _chkBalance = _chkDepo + _chkTransfer - _chkTransferOut - _chkWithdraw;
            return _chkBalance;

        }




    }


}
