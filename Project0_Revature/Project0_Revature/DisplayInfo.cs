﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Project0_Revature
{
    public static class DisplayInfo
    {
        public static void accountList()
        {
            //Console.WriteLine("The User " + UserRegister._firstName + " " + UserRegister._lastName + " has Following Accounts Details.");
            //Console.WriteLine("The User Id :\t" + UserRegister._userId);
            //Console.WriteLine("The Balance $:\t" + Balance.endBalance());

            //Console.WriteLine("Number Account: \t" + AccountCreation._totalAccount);


            //Console.WriteLine("Account Number: \t" + AccountCreation._accountNumber);
            //if (Selection.businessAcc != 0)
            //{
            //    Console.WriteLine("The Toltal Busines Account is : " + Selection.businessAcc);
            //}
            Console.WriteLine( "The Register User Details " );
            disUser();
            Console.WriteLine("Following are Account Details");
            Console.Write("Your List of Account/Accounts are: ");
            disaccountList();
            Console.WriteLine("Your Transfer Transation is/are: \t");
            disTransfer();
            Console.WriteLine("Your Withdraw Records are: \t ");
            disWithdraw();
            Console.WriteLine("Your Deposit Records are");
            disDeposit();
            Console.WriteLine("Your Balance: \t");
            Balance.endBalance();





        }
        public static void disaccountList()
        {
            foreach (int i in AccountCreation.accountCollection)
            {
                Console.WriteLine(i);
            }
        }

        public static void disTransfer()
        {
            foreach (double i in Transfer.transferList)
            {
                Console.WriteLine(i);
            }
        }
        public static void disDeposit()
        {
            foreach (double i in Deposit.depositList)
            {
                Console.WriteLine(i);
            }
        }

        public static void disWithdraw()
        {
            foreach (double i in Withdraw.withdrawList)
            {
                Console.WriteLine(i);
            }
        }

        public static void disUser()
        {
            foreach (object i in UserRegister.userList)
            {
                Console.WriteLine(i);
            }
        }





    }
}
