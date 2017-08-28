using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FastwayCourier;

namespace CourierQuoteTests
{
    
    }
    [TestClass]
    public class GettingCalculateQuote_Should
    {

    [TestMethod]
    [ExpectedException(typeof(KeyNotFoundException))]
    public void ThrowAnExceptionWhenEmptyString()
    {
        //arrange
        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
        ParcelQuoteResult Result = null;
        decimal weight = 0M;
        string zone = "";
           decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.Price;

        //assert
    }

    [TestMethod]
   
    public void ArgumentOutOfRangeExceptionThrowAnExceptionWhenWeightIsZero()
    {
        //arrange
        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
        ParcelQuoteResult Result = null;
        decimal weight = 0M;
        string zone = "Pink";
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.Price;

        //assert
   
    }

    [TestMethod]
    
    public void ArgumentOutOfRangeExceptionThrowAnExceptionWhenWeightIsOver25kg()
    
        {
        //arrange
        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
        ParcelQuoteResult Result = null;
        decimal weight = 25.01M;
        string zone = "Pink";
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.Price;

        //assert
        
    }
       
    [TestMethod]
    public void Return4dollars15cents_WhenWeightIsZeroPointZeroOneKgAndZoneIsPink()
    {
        //arrange
        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();

        ParcelQuoteResult Result = null;
        decimal weight = 0.01M;
        string zone = "Pink";
        decimal expected = 4.15M;
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.Price;

        //assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Return4dollars15cents_WhenWeightIs25KgAndZoneIsPink()
    {
        //arrange
        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();

        ParcelQuoteResult Result = null;
        decimal weight = 25M;
        string zone = "Pink";
        decimal expected = 4.15M;
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.Price;

        //assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Return6dollars95cents_WhenWeightIsZeroPointZeroOneAndZoneIsBlue()
    {
        //arrange
        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();

        ParcelQuoteResult Result = null;
        decimal weight = 0.01M;
        string zone = "Blue";
        decimal expected = 6.95M;
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.Price;

        //assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Return6dollars95cents_WhenWeightIs25KgAndZoneIsBlue()
    {
        //arrange
        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();

        ParcelQuoteResult Result = null;
        decimal weight = 25M;
        string zone = "Blue";
        decimal expected = 6.95M;
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.Price;

        //assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Return8dollars70cents_WhenWeightIsZeroPointZeroOneKgAndZoneIsLime()
    {
        //arrange
        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();

        ParcelQuoteResult Result = null;
        decimal weight = 0.01M;
        string zone = "Lime";
        decimal expected = 8.70M;
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.Price;

        //assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Return8dollars70cents_WhenWeightIs15KgAndZoneIsLime()
    {
        //arrange
        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();

        ParcelQuoteResult Result = null;
        decimal weight = 15M;
        string zone = "Lime";
        decimal expected = 8.70M;
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.Price;

        //assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Return14dollars90cents_WhenWeightIsFifteenPointZeroOneKgAndZoneIsLime()
    {
        //arrange
        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();

        ParcelQuoteResult Result = null;
        decimal weight = 15.01M;
        string zone = "Lime";
        decimal expected = 14.90M;
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.Price;

        //assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Return14dollars90cents_WhenWeightIs25KgAndZoneIsLime()
    {
        //arrange
        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();

        ParcelQuoteResult Result = null;
        decimal weight = 25M;
        string zone = "Lime";
        decimal expected = 14.90M;
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.Price;

        //assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Return12Dollars95cents_WhenWeightIsZeroPointZeroOneKgAndZoneIsOrange()
    {
        //arrange
        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();

        ParcelQuoteResult Result = null;
        decimal weight = 0.01M;
        string zone = "Orange";
        decimal expected = 12.95M;
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.Price;

        //assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Return12Dollars95cents_WhenWeightIs15KgAndZoneIsOrange()
    {
        //arrange
        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();

        ParcelQuoteResult Result = null;
        decimal weight = 15M;
        string zone = "Orange";
        decimal expected = 12.95M;
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.Price;

        //assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Return19dollars15cents_WhenWeightIsFifteenPointZeroOneKgAndZoneIsOrange()
    {
        //arrange
        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();

        ParcelQuoteResult Result = null;
        decimal weight = 15.01M;
        string zone = "Orange";
        decimal expected = 19.15M;
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.Price;

        //assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
                 public void Return19dollars15cents_WhenWeightIs20KgAndZoneIsOrange()
            {
                //arrange
                ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();

            ParcelQuoteResult Result = null;
                decimal weight = 20M;
                string zone = "Orange";
                decimal expected = 19.15M;
                decimal actual;

            //act
            Result = pq.CalculateQuote(weight,zone);
                actual = Result.Price;

                //assert
                Assert.AreEqual(expected, actual);
            }
    [TestMethod]
    public void Return25dollars35cents_WhenWeightIsTwentypointZeroOneKgAndZoneIsOrange()
    {
        //arrange
        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();

        ParcelQuoteResult Result = null;
        decimal weight = 20.01M;
        string zone = "Orange";
        decimal expected = 25.35M;
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.Price;

        //assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void Return25dollars35cents_WhenWeightIs25KgAndZoneIsOrange()
    {
        //arrange
        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();

        ParcelQuoteResult Result = null;
        decimal weight = 19.15M;
        string zone = "Orange";
        decimal expected = 19.15M;
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.Price;

        //assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ReturnZeroExcessTickets_WhenWeightIsZeroPointZeroOneKgAndZoneIsPink()
    {
        //arrange

        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
         ParcelQuoteResult Result = null;
        decimal weight = 0.01M;
        string zone = "Pink";
        int expected = 0;
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.ExcessTickets;

        //assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void ReturnZeroExcessTickets_WhenWeightIs25KgAndZoneIsPink()
    {
        //arrange

        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
        ParcelQuoteResult Result = null;
        decimal weight = 25M;
        string zone = "Pink";
        int expected = 0;
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.ExcessTickets;

        //assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void ReturnZeroExcessTickets_WhenWeightIsZeroPointZeroOneKgAndZoneIsBlue()
    {
        //arrange

        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
        ParcelQuoteResult Result = null;
        decimal weight = 0.01M;
        string zone = "Blue";
        int expected = 0;
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.ExcessTickets;

        //assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void ReturnZeroExcessTickets_WhenWeightIs25KgAndZoneIsBlue()
    {
        //arrange

        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
        ParcelQuoteResult Result = null;
        decimal weight = 25M;
        string zone = "Blue";
        int expected = 0;
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.ExcessTickets;

        //assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void ReturnZeroExcessTickets_WhenWeightIsZeroPointZeroOneKgAndZoneIsLime()
    {
        //arrange

        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
        ParcelQuoteResult Result = null;
        decimal weight = 0.01M;
        string zone = "Lime";
        int expected = 0;
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.ExcessTickets;

        //assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void ReturnZeroExcessTickets_WhenWeightIs15KgAndZoneIsLime()
    {
        //arrange

        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
        ParcelQuoteResult Result = null;
        decimal weight = 15M;
        string zone = "Lime";
        int expected = 0;
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.ExcessTickets;

        //assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
        public void ReturnOneExcessTickets_WhenWeightIsFifteenPointZeroOneKgAndZoneIsLime()
    {
        //arrange

        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
        ParcelQuoteResult Result = null;
        decimal weight = 15.01M;
        string zone = "Lime";
        int expected = 1;
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.ExcessTickets;

        //assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void ReturnOneExcessTickets_WhenWeightIs25KgAndZoneIsLime()
    {
        //arrange

        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
        ParcelQuoteResult Result = null;
        decimal weight = 25M;
        string zone = "Lime";
        int expected = 1;
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.ExcessTickets;

        //assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void ReturnZeroExcessTickets_WhenWeightIsZeroPointZeroOneKgAndZoneIsOrange()
    {
        //arrange

        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
        ParcelQuoteResult Result = null;
        decimal weight = 0.01M;
        string zone = "orange";
        int expected = 0;
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.ExcessTickets;

        //assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void ReturnZeroExcessTickets_WhenWeightIs15KgAndZoneIsOrange()
    {
        //arrange

        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
        ParcelQuoteResult Result = null;
        decimal weight = 15M;
        string zone = "orange";
        int expected = 0;
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.ExcessTickets;

        //assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void ReturnOneExcessTickets_WhenWeightIsFifteenPointZeroOneKgAndZoneIsOrange()
    {
        //arrange

        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
        ParcelQuoteResult Result = null;
        decimal weight = 15.01M;
        string zone = "orange";
        int expected = 1;
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.ExcessTickets;

        //assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void ReturnOneExcessTickets_WhenWeightIs20KgAndZoneIsOrange()
    {
        //arrange

        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
        ParcelQuoteResult Result = null;
        decimal weight = 20M;
        string zone = "orange";
        int expected = 1;
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.ExcessTickets;

        //assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void ReturnTwoExcessTickets_WhenWeightIsTwentyPointZeroOneKgAndZoneIsOrange()
    {
        //arrange

        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
        ParcelQuoteResult Result = null;
        decimal weight = 20.01M;
        string zone = "orange";
        int expected = 2;
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.ExcessTickets;

        //assert
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void ReturnTwoExcessTickets_WhenWeightIs25KgAndZoneIsOrange()
    {
        //arrange

        ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
        ParcelQuoteResult Result = null;
        decimal weight = 25M;
        string zone = "orange";
        int expected = 2;
        decimal actual;

        //act
        Result = pq.CalculateQuote(weight, zone);
        actual = Result.ExcessTickets;

        //assert
        Assert.AreEqual(expected, actual);
    }
    private class KeyNotFoundException
    {
    }
}
   

