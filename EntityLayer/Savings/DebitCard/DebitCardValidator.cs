using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;

namespace EntityLayer
{
    public class DebitCardValidator
    {
        [CreditCard]
        public string DebitCardNumber { get; set; }

        /// <summary>
        /// This class uses Luhr's algorithm to test generated debit card numbers, whether they are valid or not. 
        /// </summary>
        /// <param name="Generators"></param>
        /// <returns></returns>

        public static bool ValidateDebitCard(string Generators)
        {
            if( Generators == null)
            {
                throw new ArgumentNullException();

            }
            if(Generators.Length != 16)
            {
                throw new ArgumentException();
            }
            var splittedValues = Generators.ToCharArray().ToList().Skip(1).Take(1).ToList();
            int summation = default;
            for (int index = 0; index < splittedValues.Count; index ++)
            {
                var currentValue = splittedValues[index] * 2;
                if (currentValue > 9)
                {
                    currentValue = currentValue - 9;

                }
                summation += currentValue;

            }

            var splittedValue2 = Generators.ToCharArray();

            int summation2 = default;

            for (int i = 0; i < splittedValue2.Length; i+=2)
            {
                var currentValue2 = splittedValue2[i];
                
                summation2 += currentValue2;
            }

            var aggregate = (summation + summation2) % 10 == 0;

            return aggregate;

            

        }

        public string CardGenerator(CardType cardType)
        {
            string card = default;
            switch (cardType)
            {
                case CardType.VISA:
                    card =CardEngine("4");
                    break;
                case CardType.MASTERCARD:
                    card = CardEngine("5");
                    break;
                default:
                    
                    break;
            }

            return card;
        }

        /// <summary>
        /// This class validates the numbers generated and confirms whether it is a valid debit card. The loop continues to run until a valid number is generated.
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>

        private static string CardEngine(string card)
        {
            var returnCard = Randomizer(card);
            var isValid = ValidateDebitCard(returnCard);
            while (!isValid)
            {
                returnCard = Randomizer(card);
                isValid = ValidateDebitCard(returnCard);
            }

            return returnCard;
        }

        /// <summary>
        /// The purpose of this class is to generate random strings that contains numbers that are upto 16 character long.
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        private static string Randomizer(string card)
        {
            var randomNumbers = new Random();
            var randomNumbers2 = new Random();
            string cardNumber = $"{card}{randomNumbers.Next(1000000, 9999999)}{randomNumbers2.Next(10000000, 99999999)}";
            return cardNumber;
        }
    }
    public enum CardType
    {
        VISA,
        MASTERCARD
    }
}
