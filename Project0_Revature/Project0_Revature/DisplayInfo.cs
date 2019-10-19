using System;
using System.Collections.Generic;
using System.Text;

namespace Project0_Revature
{
    public static class DisplayInfo
    {
        public static void accountList()
        {
            Console.WriteLine("The User " + UserRegister._firstName + " " + UserRegister._lastName + " has Following Accounts Details.");
            Console.WriteLine("The User Id :\t" + UserRegister._userId);
            Console.WriteLine("The Balance $:\t" + Balance.endBalance());

            Console.WriteLine("Number Account: \t" + AccountCreation._totalAccount);

            Console.WriteLine("Account Number: \t" + AccountCreation._accountNumber);
            if (Selection.businessAcc != 0)
            {
                Console.WriteLine("The Toltal Busines Account is : " + Selection.businessAcc);
            }



        }
       

    }
}
