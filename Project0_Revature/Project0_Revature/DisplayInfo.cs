using System;
using System.Collections.Generic;
using System.Text;

namespace Project0_Revature
{
    public static class DisplayInfo
    {
        public static void  accountList()
        {
            Console.WriteLine("The User " + UserRegister._firstName + " " + UserRegister._lastName +" has Following Accounts Details.");
            Console.WriteLine("The User Id :\t" + UserRegister._userId);
            Console.WriteLine("The Balance $:\t" + Deposit.Balance1());
            Console.WriteLine("");


        }

        }
}
