using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;

namespace EntityLayer
{
    class DebitCardValidator
    {
        [CreditCard]
        public string DebitCardNumber { get; set; }

        public bool ValidateDebitCard(string Generators)
        {
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

        //public string CardGenerator(CardType cardType)
        //{
        //    string card = default;
        //    switch (cardType)
        //    {
        //        case CardType.VISA:
        //            card = "4";

        //            randomNumbers = 
        //            break;
        //        case CardType.MASTERCARD:
        //        default:
        //            break;
        //    }
        //}


        
    }
    public enum CardType
    {
        VISA,
        MASTERCARD
    }
}
