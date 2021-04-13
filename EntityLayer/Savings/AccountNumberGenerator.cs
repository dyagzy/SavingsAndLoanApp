using EntityLayer.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class AccountNumberGenerator
    {

        public static string NewSavingAccountNumbers()
        {
            var start = "01";
            var end = "";
            var random = new Random();
            var otherdigits = random.Next(10000000, 99999999);
            

            var accountNumber = (start + otherdigits + end).ToString();
            return accountNumber;
        }

        public static string RoundUpSavingAccountNumbers()
        {
            var roundUpSavingsIdentifier = "12";
            var random = new Random();
            var otherdigits = random.Next(10000000, 99999999);

            var accountNumber = roundUpSavingsIdentifier + otherdigits.ToString();
            return accountNumber;
        }


       

       
    }
}
