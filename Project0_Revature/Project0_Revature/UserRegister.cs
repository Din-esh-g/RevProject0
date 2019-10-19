using System;
using System.Collections.Generic;
using System.Text;

namespace Project0_Revature
{
    
    public static class UserRegister
    {

        public static int _userId;
        public static string _firstName;
        public static string _lastName;
        public static string _emailAddress;
        public static int _numberOfUser = 0;
        public static void  userDetails()
        {
            Console.WriteLine("Please Enter Your Firstname");
            _firstName = Console.ReadLine();

            Console.WriteLine("Please Enter Your Lasttname");
            _lastName = Console.ReadLine();

            Console.WriteLine("Please Enter Your Email Address");
            _emailAddress = Console.ReadLine();

           
            Random random = new System.Random();
            _userId = random.Next(500, 2500);

            _numberOfUser++;

        }


    }
}
