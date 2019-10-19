using System;

namespace Project0_Revature
{
    public class Program
    {
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



                }



                    DisplayInfo.accountList();

            }
        }
    }
}
