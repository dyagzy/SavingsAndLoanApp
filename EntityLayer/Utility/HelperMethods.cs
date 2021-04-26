﻿using EntityLayer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Utility
{
   public class HelperMethods
    {

        SavingsAccountDto savings = new SavingsAccountDto();

        //Handles deposit of funds by counter draft
        public static decimal DepositFunds(decimal amount)
        {
            decimal currentBalance = 0.00m;


            //decimal initialBal = 0.00m;
            currentBalance += amount;

            return currentBalance;
        }


        //This method just displays a welcome message and the savings account of the customer
        public static string SavingsAccountWelcomeMessage()
        {
            SavingsAccountDto savingsDto = new SavingsAccountDto();

            string message;
            message = string.Format($"Your savings account number is : {savingsDto.AccountNumber}");

            return message;
        }

       

        //checks account balance

        public static decimal CheckAccountBalance()
        {
            return 0.00m;
        }
    }
}
