using System;
using System.Collections.Generic;
using System.Text;

namespace Project0_Revature
{
    public static class Transfer
    {
        public static double _transferAmt;
        public static List<object> transferList = new List<object>();
        public static double _transferOut = 0;
        public static double _transferIn = 0;

        public static void TransferAmt()
        {       
           
                if (AccountCreation._totalAccount >= 2)
                {

                Console.WriteLine("Please Enter Your Amount You Want To Transfer. ");
                Console.WriteLine();
                Console.WriteLine();

                _transferAmt = Convert.ToDouble(Console.ReadLine());
                transferList.Add(_transferAmt);


            }
           else{  
                Console.WriteLine("You Must need atleast 2 Account to transfer Balance. " );
            }
            

        }


    }
}
