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
        public static bool endApp = false;
        public static int _transation = 0;
        


        public static void option1()
        {

            Console.WriteLine("Choose an operation from the following list:");
            Console.WriteLine("\tc - Open Checking Account");
            Console.WriteLine("\tb - Open Business Account");
            Console.WriteLine("\tl - Loan Account");
            Console.WriteLine("\tt - Term Deposit Account");
            Console.WriteLine("\te - Exit");

            Console.Write("Your option? : ");
            string option1 = Console.ReadLine();

            while (string.IsNullOrEmpty(option1))
            {
                Console.WriteLine("Your Selection can't be empty! Input your selection once more");
                option1 = Console.ReadLine();
            }


            if (option1 == "c")
            {
                AccountCreation.AccountNumber();
                option2();
                checking++;

            }
            else if (option1 == "b")
            {
                AccountCreation.AccountNumber();
                option2();
                businessAcc++;
            }
            else if (option1 == "l")
            {
                AccountCreation.AccountNumber();
                option2();
                loan++;
            }
            else if (option1 == "t")
            {
                AccountCreation.AccountNumber();
                option2();
                cd++;
            }
            else if (option1 == "e")
            {
                Console.WriteLine("\n\n THANKS FOR USING OUT ATM SERVICE");
                endApp = true;
            }
            else
            {
                while (!(option1 == "c") || (option1 == "b") || (option1 == "l") || (option1 == "t") || (option1 == "e"))

                {
                    Console.WriteLine("Please Enter the above option. ");
                    option1 = Console.ReadLine();
                }



            }


        }

        public static void option2()
        {



            Console.WriteLine("Choose an operation from the following list:");
            Console.WriteLine("\tw - Withdraw");
            Console.WriteLine("\td - Deposit Balance");
            Console.WriteLine("\tt - Transfer Balance");
            Console.WriteLine("\tc - Closed Account");
            Console.WriteLine("\ti - Display Information");


            Console.Write("Your option? ");
            string option2 = Console.ReadLine();
            while (string.IsNullOrEmpty(option2))
            {
                Console.WriteLine("Your Selection can't be empty! Input your selection once more");
                option2 = Console.ReadLine();
            }

            while (!(option2 == "w") || (option2 == "d") || (option2 == "t") || (option2 == "c") || (option2 == "i"))
            {

                if (option2 == "w")
                {
                    Withdraw.Withdraw1();
                    option3();

                }
                else if (option2 == "d")
                {
                    Deposit.AmtDeposit();
                    option3();
                }
                else if (option2 == "t")
                {

                    Transfer.TransferAmt();
                    option3();
                }
                else if (option2 == "c")
                {
                    CloseAccount.closed();
                    option3();

                }

                else if (option2 == "i")
                {
                    DisplayInfo.accountList();
                    option3();

                }
                else
                {
                    Console.WriteLine("Please Select the right word.");
                }

            }
        }

        public static void option3()
        {


            Console.WriteLine("\ta - Do you want to open account? ");
            Console.WriteLine("\tt - Do you want to make a transaction ");
            Console.WriteLine("\te - Exit from application. ");
            Console.Write("Your option? : ");
            string option3 = Console.ReadLine();

            while (string.IsNullOrEmpty(option3))
            {
                Console.WriteLine("Your Selection can't be empty! Input your selection once more");
                option3 = Console.ReadLine();
            }
            while (!(option3 == "a") || (option3 == "t") || (option3 == "e"))
            {

                if (option3 == "a")
                {
                    option1();
                }
                else if (option3 == "t")
                {
                    option2();

                }
                else if (option3 == "e")
                {
                    endApp = true;
                }
                else
                {
                    Console.WriteLine("Please Enter from the above option.  ");

                }
            }

        }

        public static void option0()
        {

            Console.WriteLine("Please Select from following option: ");


            Console.WriteLine("\tc - Do you want to continue with Registration ");

            Console.WriteLine("\te - Exit from application. ");

            Console.Write("Your option? : ");
            string optiono = Console.ReadLine();

            while (string.IsNullOrEmpty(optiono))
            {
                Console.WriteLine("Your Selection can't be empty! Input your selection once more");
                optiono = Console.ReadLine();
            }
            if ((optiono == "c") || (optiono == "e"))
            {

                if (optiono == "c")
                {
                    UserRegister.userDetails();
                }
                else if (optiono == "e")
                {
                    endApp = true;
                }



            }
        }
        public static void option4()
        {
            Console.WriteLine("Please Select from following option: ");


            Console.WriteLine("\tc - Do you want to make a transfer between your account.  ");

            Console.WriteLine("\te - Exit from application. ");

            Console.Write("Your option? : ");
            string option4 = Console.ReadLine();

            while (string.IsNullOrEmpty(option4))
            {
                Console.WriteLine("Your Selection can't be empty! Input your selection once more");
                option4 = Console.ReadLine();
            }
            if (option4=="c")
            {
                if (AccountCreation._totalAccount >= 2)
                {

                    Transfer.TransferAmt();
                }


                else if (option4 == "e")
                {
                    endApp = true;
                }

                }else
                {
                    Console.WriteLine(  "You Must have two or more account to do this transaction.");

                }

        }
    }
}
