using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject1.UnitTestbyChiamaka
{
    class TestforDebitCardValidator1
    {
        public class TestforDebitCardValidator
        {
            [Fact]
            private void ValidateDebitCardShouldThrowErrorWhenDebitCardValueIsNullOrInvalid()
            {

                Assert.Throws<ArgumentNullException>(() => DebitCardValidator.ValidateDebitCard(null));
                Assert.Throws<ArgumentException>(() => DebitCardValidator.ValidateDebitCard(""));
            }

            [Fact]
            private void ValidateDebitCardShouldReturnFasleWhenWrongDebitCardIsInputed()
            {
                Assert.True(DebitCardValidator.ValidateDebitCard("1234567890123456") == false);
            }

            [Fact]
            private void ValidateDebitCardShouldReturnTrueWhenCorrectDebitCardIsInputed()
            {
                Assert.True(DebitCardValidator.ValidateDebitCard("4682190121149161") == true);
            }

        }
    }
}