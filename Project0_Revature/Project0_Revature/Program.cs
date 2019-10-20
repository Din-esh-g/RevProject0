using System;

namespace Project0_Revature
{
    public class Program
    {
      
        public static char transaction = 'y';

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            bool endApp = false;
            Console.WriteLine("Welcome to Fun Bank App! ");


            while (!endApp)

            {


                Selection.option0();

                if (UserRegister._numberOfUser > 0)

                {
                    Selection.option1();
                }
                else
                {
                    //Console.WriteLine("Registration is not sucesss. Please try after some time.");
                    UserRegister.userDetails();
                }
                

                if (AccountCreation._totalAccount != 0)
                {
                    Selection.option2();
                }
                else
                {
                    Console.WriteLine("Please Register First");
                    UserRegister.userDetails();
                }

               //Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
              // DisplayInfo.accountList();

               
                }

            





        }
        }
    }

