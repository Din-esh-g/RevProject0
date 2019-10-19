using System;
using System.Collections.Generic;
using System.Text;

namespace Project0_Revature
{
    public static class Selection
    {
        public static int checking = 0;
        public static int cd = 0;
        public static int loan = 0;
        public static int businessAcc = 0;
        public static void option1(){
            Console.WriteLine("Choose an operation from the following list:");
            Console.WriteLine("\tc - Open Checking Account");
            Console.WriteLine("\tb - Open Business Account");
            Console.WriteLine("\tl - Loan Account");
            Console.WriteLine("\tt - Term Deposit Account");

            Console.Write("Your option? ");



            string option1 = Console.ReadLine();
            if (option1 == "c")
            {
                AccountCreation.AccountNumber();
                checking++;

            }
            else if (option1 == "b")
            {
                AccountCreation.AccountNumber();
                businessAcc++;
            }
            else if (option1 == "l")
            {
                AccountCreation.AccountNumber();
                loan++;
            }
            else if (option1 == "t")
            {
                AccountCreation.AccountNumber();
                cd++;
            }
            else
            {
                Console.WriteLine("Please Enter the above option. ");

            }

        }

        public static void option2()
        {
           
                Console.WriteLine("Choose an operation from the following list:");
                Console.WriteLine("\tw - Withdraw");
                Console.WriteLine("\td - Deposit Balance");
                Console.WriteLine("\tt - Transfer Balance");
                Console.WriteLine("\tc - Closed Account");

                Console.Write("Your option? ");



                string option2 = Console.ReadLine();
                if (option2 == "w")
                {
                    Withdraw.Withdraw1();
                }
                else if (option2 == "d")
                {
                    Deposit.AmtDeposit();
                }
                else if (option2 == "t")
                {

                    Transfer.TransferAmt();
                }
                else if (option2 == "c")
                {
                    CloseAccount.closed();

                }
                else
                {
                    Console.WriteLine("Please Select the right word.");
                }

            }

    }
}
