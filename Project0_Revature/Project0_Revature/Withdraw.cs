using System;
using System.Collections.Generic;
using System.Text;

namespace Project0_Revature
{
   public static class Withdraw
    {
      
                
        public static double _withdraw;
       
        
        public static double Withdraw1()
        {
            Console.WriteLine("Please Enter Your Amount You Want To Withdraw. ");
            //Console.ReadLine();
           _withdraw = Convert.ToDouble(Console.ReadLine());            

            return _withdraw;
        }
        
    }
}
