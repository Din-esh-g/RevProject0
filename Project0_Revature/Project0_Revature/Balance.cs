using System;
using System.Collections.Generic;
using System.Text;

namespace Project0_Revature
{
   public static class Balance
    {
       
       
        public static double _closeBalance;
        
      
        public static double endBalance()
        {
            _closeBalance = Deposit._openBalance + Deposit._deposit - Withdraw._withdraw - Transfer._transferAmt;
            return _closeBalance;

        }
        public static double endBalanceWithTransferIn()
        {
            _closeBalance = Deposit._openBalance + Deposit._deposit - Withdraw._withdraw + this.Transfer._transferAmt;
            return _closeBalance;

        }
    }
}
