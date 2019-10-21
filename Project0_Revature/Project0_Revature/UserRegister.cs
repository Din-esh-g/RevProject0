using System;
using System.Collections.Generic;
using System.Text;

namespace Project0_Revature
{
    
    public static class UserRegister
    {




        public static List<string> userList = new List<string>();
        public static int _userId;
        public static string _firstName;
        public static string _lastName;
        public static string _emailAddress;
        public static int _numberOfUser = 0;
        public static void userDetails()
        {
            Console.WriteLine("Please Enter Your Firstname: ");
            _firstName = Console.ReadLine();

            while (string.IsNullOrEmpty(_firstName))
            {
                Console.WriteLine("Name can't be empty! Input your  First name once more");
                _firstName = Console.ReadLine();
            }
            userList.Add(_firstName);

            Console.WriteLine("Please Enter Your Lasttname");
            _lastName = Console.ReadLine();

            while (string.IsNullOrEmpty(_lastName))
            {
                Console.WriteLine(" Last Name can't be empty! Input your Last name once more");
                _lastName = Console.ReadLine();
            }
            userList.Add(_lastName);

            Console.WriteLine("Please Enter Your Email Address");
            _emailAddress = Console.ReadLine();

            while (string.IsNullOrEmpty(_emailAddress))
            {
                Console.WriteLine("Email Field can't be empty! Input your email address once more");


                bool ValidateEmail = ValidaterEmail(_emailAddress);

                if (ValidateEmail)
                {
                    _emailAddress = Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Please Enter your Valid Email");


                }
            }
                userList.Add(_emailAddress);
            


                Random random = new System.Random();
                _userId = random.Next(500, 2500);
            
                userList.Add(_userId.ToString());

                _numberOfUser++;

                Console.WriteLine("Thank you for Registration !!! \n\n");

            Console.WriteLine("Your Registration Detais\n Full Name : {0} Email i: {1}  UserId:  {2} ", _firstName + " "+ _lastName, _emailAddress, _userId);
            Console.WriteLine("\n\n");
            Selection.option1();

            
        }


        public static bool ValidaterEmail(string email)
        {
            System.Text.RegularExpressions.Regex emailRegex = new System.Text.RegularExpressions.Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            System.Text.RegularExpressions.Match emailMatch = emailRegex.Match(_emailAddress);
            return emailMatch.Success;
        }


    }
}
