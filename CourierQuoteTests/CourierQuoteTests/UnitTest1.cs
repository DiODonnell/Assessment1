using System;
using FastwayCourier;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CourierQuoteTests
{

    [TestClass]
    public class GettingDestinationZone_Should
    {

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void ThrowAnExceptionWhenEmptyString()
        {
            //arrange
            ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
            string destination = "";
            string result;


            //act
            result = pq.GetDestinationZone(destination);

            //assert
        }

        [TestMethod]
        public void ReturnPink_WhenDestinationIsNelson()
        {
            //arrange
            ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
            string destination = "Nelson";
            string expected = "Pink";
            string actual;


            //act
            actual = pq.GetDestinationZone(destination);

            //assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void ReturnPink_WhenDestinationIsMapua()
        {
            //arrange
            ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
            string destination = "Mapua";
            string expected = "Pink";
            string actual;


            //act
            actual = pq.GetDestinationZone(destination);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ReturnPink_WhenDestinationIsAtawhai()
        {
            //arrange
            ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
            string destination = "Atawhai";
            string expected = "Pink";
            string actual;

            //act
            actual = pq.GetDestinationZone(destination);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ReturnPink_WhenDestinationIsMatai()
        {
            //arrange
            ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
            string destination = "Maitai";
            string expected = "Pink";
            string actual;

            //act
            actual = pq.GetDestinationZone(destination);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ReturnPink_WhenDestinationIsMotueka()
        {
            //arrange
            ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
            string destination = "Motueka";
            string expected = "Pink";
            string actual;

            //act
            actual = pq.GetDestinationZone(destination);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnPink_WhenDestinationIsHope()
        {
            //arrange
            ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
            string destination = "Hope";
            string expected = "Pink";
            string actual;

            //act
            actual = pq.GetDestinationZone(destination);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ReturnPink_WhenDestinationIsBrightwater()
        {
            //arrange
            ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
            string destination = "Brightwater";
            string expected = "Pink";
            string actual;

            //act
            actual = pq.GetDestinationZone(destination);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ReturnPink_WhenDestinationIsWakefield()
        {
            //arrange
            ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
            string destination = "Wakefield";
            string expected = "Pink";
            string actual;

            //act
            actual = pq.GetDestinationZone(destination);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ReturnPink_WhenDestinationIsPicton()
        {
            //arrange
            ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
            string destination = "Picton";
            string expected = "Pink";
            string actual;

            //act
            actual = pq.GetDestinationZone(destination);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ReturnPink_WhenDestinationIsBlemheim()
        {
            //arrange
            ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
            string destination = "Blenheim";
            string expected = "Pink";
            string actual;

            //act
            actual = pq.GetDestinationZone(destination);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ReturnPink_WhenDestinationIsRenwick()
        {
            //arrange
            ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
            string destination = "Renwick";
            string expected = "Pink";
            string actual;

            //act
            actual = pq.GetDestinationZone(destination);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ReturnBlue_WhenDestinationIsRiwaka()
        {
            //arrange
            ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
            string destination = "Riwaka";
            string expected = "Blue";
            string actual;

            //act
            actual = pq.GetDestinationZone(destination);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ReturnBlue_WhenDestinationIsWaihopai()
        {
            //arrange
            ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
            string destination = "Waihopai Valley";
            string expected = "Blue";
            string actual;

            //act
            actual = pq.GetDestinationZone(destination);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnBlue_WhenDestinationIsHavelock()
        {
            //arrange
            ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
            string destination = "Havelock";
            string expected = "Blue";
            string actual;

            //act
            actual = pq.GetDestinationZone(destination);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnBlue_WhenDestinationIsTakaka()
        {
            //arrange
            ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
            string destination = "Takaka";
            string expected = "Blue";
            string actual;

            //act
            actual = pq.GetDestinationZone(destination);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnBlue_WhenDestinationIsSeddon()
        {
            //arrange
            ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
            string destination = "Seddon";
            string expected = "Blue";
            string actual;

            //act
            actual = pq.GetDestinationZone(destination);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnBlue_WhenDestinationIsWard()
        {
            //arrange
            ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
            string destination = "Ward";
            string expected = "Blue";
            string actual;

            //act
            actual = pq.GetDestinationZone(destination);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnLime_WhenDestinationIsMurchison()
        {
            //arrange
            ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
            string destination = "Murchison";
            string expected = "Lime";
            string actual;

            //act
            actual = pq.GetDestinationZone(destination);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnLime_WhenDestinationIsNelsonNationalPark()
        {
            //arrange
            ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
            string destination = "Nelson Lakes National Park";
            string expected = "Lime";
            string actual;

            //act
            actual = pq.GetDestinationZone(destination);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnOrange_WhenDestinationIsKaikoura()
        {
            //arrange
            ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
            string destination = "Kaikoura";
            string expected = "Orange";
            string actual;

            //act
            actual = pq.GetDestinationZone(destination);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnOrange_WhenDestinationIsReefton()
        {
            //arrange
            ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
            string destination = "Reefton";
            string expected = "Orange";
            string actual;

            //act
            actual = pq.GetDestinationZone(destination);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnOrange_WhenDestinationIsHanmerSprings()
        {
            //arrange
            ParcelQuoteFromNelson pq = new ParcelQuoteFromNelson();
            string destination = "Hanmer Springs";
            string expected = "Orange";
            string actual;

            //act
            actual = pq.GetDestinationZone(destination);

            //assert
            Assert.AreEqual(expected, actual);
        }

         }
    }



