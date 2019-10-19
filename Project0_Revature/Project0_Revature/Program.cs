using System;

namespace Project0_Revature
{
    public class Program
    {
        public static int checking = 0;
        public static int cd = 0;
        public static int loan = 0;
        public static int businessAcc = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            bool endApp = false;
            Console.WriteLine("Welcome to Fun Bank App! ");
            while (!endApp)

            {
                UserRegister.userDetails();
                if (UserRegister._numberOfUser != 0)

                {
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

               
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
               // if (Console.ReadLine() == "n") endApp = true;
                if (AccountCreation._totalAccount != 0)
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
                    DisplayInfo.accountList();



                }

            }

            





        }
        }
    }

