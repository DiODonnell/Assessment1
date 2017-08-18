using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FastwayCourier;

namespace CourierQuoteTests
{
    [TestClass]
    public class GettingCalculateQuote_Should
    {
        [TestMethod]
                 public void Return4dollars15cents_WhenWeightIsUpTo25KgAndZoneIsPink()
            {
                //arrange
                ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
            ParcelQuoteResult Result = null;
                decimal weight = 0.01M;
                string zone = "Pink";
                decimal expected = 4.15M;
                decimal actual;

            //act
            Result = pq.CalculateQuote(weight,zone);
                actual = Result.Price;

                //assert
                Assert.AreEqual(expected, actual);
            }
        }
    }

