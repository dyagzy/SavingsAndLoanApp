using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
   public abstract class AccountNumberGenerator
    {

        public static string NewSavingAccountNumbers()
        {
            var savingsIdentifier = "01";
            var random = new Random();
            var otherdigits = random.Next(10000000, 99999999);

            var accountNumber = savingsIdentifier + otherdigits.ToString();
            return accountNumber;
        }
    }
}
