using System;
using System.Globalization;

using LottoApi.Services.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LottoTesting
{
    [TestClass]
    public class UnitTest1
    {


        #region Repeating
        
       

        [TestMethod]
        public void RepeatRepeatRepeat()
        {

            var repeatingNumbers = new RepeatingNumbers();
            var pass = repeatingNumbers.RepeatRepeatRepeat(3, 3, 3);
            var fail = repeatingNumbers.RepeatRepeatRepeat(3, 3, 1);
            Assert.IsTrue(pass);
            Assert.IsFalse(fail);

        }



        [TestMethod]
        public void RepeatRepeatNoRepeat()
        {

            var repeatingNumbers = new RepeatingNumbers();
            var pass = repeatingNumbers.RepeatRepeatNoRepeat(3, 3, 1);
            var fail = repeatingNumbers.RepeatRepeatNoRepeat(3, 3, 3);
            Assert.IsTrue(pass);
            Assert.IsFalse(fail);

        }


        [TestMethod]
        public void RepeatNoRepeatRepeat()
        {

            var repeatingNumbers = new RepeatingNumbers();
            var pass = repeatingNumbers.RepeatNoRepeatRepeat(3, 1, 3);
            var fail = repeatingNumbers.RepeatNoRepeatRepeat(3, 3, 3);
            Assert.IsTrue(pass);
            Assert.IsFalse(fail);

        }


        [TestMethod]
        public void NoRepeatRepeatRepeat()
        {

            var repeatingNumbers = new RepeatingNumbers();
            var pass = repeatingNumbers.NoRepeatRepeatRepeat(1, 3, 3);
            var fail = repeatingNumbers.NoRepeatRepeatRepeat(3, 3, 1);
            Assert.IsTrue(pass);
            Assert.IsFalse(fail);

        }



        [TestMethod]
        public void NoRepeatNoRepeatNoRepeat()
        {

            var repeatingNumbers = new RepeatingNumbers();
            var pass = repeatingNumbers.NoRepeatNoRepeatNoRepeat(1, 3, 9);
            var fail = repeatingNumbers.NoRepeatNoRepeatNoRepeat(3, 3, 3);
            Assert.IsTrue(pass);
            Assert.IsFalse(fail);

        }

        #endregion


        #region Ascending
        
      

        [TestMethod]
        public void FirstSecondThird()
        {

            var ascendingNumbers = new AscendingNumbers();
            var pass = ascendingNumbers.FirstSecondThird(4, 5, 6);
            var fail = ascendingNumbers.FirstSecondThird(4, 8, 6);
            Assert.IsTrue(pass);
            Assert.IsFalse(fail);

        }


        [TestMethod]
        public void FirstThirdSecond()
        {

            var ascendingNumbers = new AscendingNumbers();
            var pass = ascendingNumbers.FirstThirdSecond(4, 6, 5);
            var fail = ascendingNumbers.FirstThirdSecond(4, 8, 6);
            Assert.IsTrue(pass);
            Assert.IsFalse(fail);

        }



        [TestMethod]
        public void ThirdSecondFirst()
        {

            var ascendingNumbers = new AscendingNumbers();
            var pass = ascendingNumbers.ThirdSecondFirst(6, 5, 4);
            var fail = ascendingNumbers.ThirdSecondFirst(6, 5, 1);
            Assert.IsTrue(pass);
            Assert.IsFalse(fail);

        }



        [TestMethod]
        public void ThirdFirstSecond()
        {

            var ascendingNumbers = new AscendingNumbers();
            var pass = ascendingNumbers.ThirdFirstSecond(6, 4, 5);
            var fail = ascendingNumbers.ThirdFirstSecond(6, 5, 1);
            Assert.IsTrue(pass);
            Assert.IsFalse(fail);

        }


        [TestMethod]
        public void SecondFirstThird()
        {

            var ascendingNumbers = new AscendingNumbers();
            var pass = ascendingNumbers.SecondFirstThird(4, 3, 5);
            var fail = ascendingNumbers.SecondFirstThird(6, 5, 1);
            Assert.IsTrue(pass);
            Assert.IsFalse(fail);

        }


        [TestMethod]
        public void SecondThirdFirst()
        {

            var ascendingNumbers = new AscendingNumbers();
            var pass = ascendingNumbers.SecondThirdFirst(4, 5, 3);
            var fail = ascendingNumbers.SecondThirdFirst(6, 5, 1);
            Assert.IsTrue(pass);
            Assert.IsFalse(fail);

        }

        #endregion

        #region EvenOdd  
   

        [TestMethod]
        public void EvenEvenEven()
        {

            var evenOdd = new EvenOdd();
            var pass = evenOdd.EvenEvenEven(2,4,6);
            var fail = evenOdd.EvenEvenEven(5, 7, 4);
            Assert.IsTrue(pass);
            Assert.IsFalse(fail);

        }

        [TestMethod]
        public void EvenEvenOdd()
        {

            var evenOdd = new EvenOdd();
            var pass = evenOdd.EvenEvenOdd(2, 4, 7);
            var fail = evenOdd.EvenEvenOdd(5, 7, 4);
            Assert.IsTrue(pass);
            Assert.IsFalse(fail);

        }

        [TestMethod]
        public void EvenOddOdd()
        {

            var evenOdd = new EvenOdd();
            var pass = evenOdd.EvenOddOdd(2, 7, 7);
            var fail = evenOdd.EvenOddOdd(5, 7, 4);
            Assert.IsTrue(pass);
            Assert.IsFalse(fail);

        }


        [TestMethod]
        public void OddOddOdd()
        {

            var evenOdd = new EvenOdd();
            var pass = evenOdd.OddOddOdd(1, 1, 7);
            var fail = evenOdd.OddOddOdd(5, 7, 4);
            Assert.IsTrue(pass);
            Assert.IsFalse(fail);

        }

        [TestMethod]
        public void OddEvenEven()
        {

            var evenOdd = new EvenOdd();
            var pass = evenOdd.OddEvenEven(1, 2, 2);
            var fail = evenOdd.OddEvenEven(5, 7, 4);
            Assert.IsTrue(pass);
            Assert.IsFalse(fail);

        }



        [TestMethod]
        public void OddOddEven()
        {

            var evenOdd = new EvenOdd();
            var pass = evenOdd.OddOddEven(1, 1, 2);
            var fail = evenOdd.OddOddEven(5, 8, 4);
            Assert.IsTrue(pass);
            Assert.IsFalse(fail);

        }


        [TestMethod]
        public void EvenOddEven()
        {

            var evenOdd = new EvenOdd();
            var pass = evenOdd.EvenOddEven(8, 1, 2);
            var fail = evenOdd.EvenOddEven(5, 8, 4);
            Assert.IsTrue(pass);
            Assert.IsFalse(fail);

        }


        [TestMethod]
        public void OddEvenOdd()
        {

            var evenOdd = new EvenOdd();
            var pass = evenOdd.OddEvenOdd(1, 6, 9);
            var fail = evenOdd.OddEvenOdd(5, 8, 4);
            Assert.IsTrue(pass);
            Assert.IsFalse(fail);

        }









        #endregion

    }
}
