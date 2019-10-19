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
                    Selection.option1();
                }

                if (AccountCreation._totalAccount != 0)
                {
                    Selection.option2();
                }

               Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                DisplayInfo.accountList();

               
                }

            





        }
        }
    }

