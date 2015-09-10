using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using LottoApi.Areas.HelpPage;
using LottoApi.Models;
using LottoApi.Services.Tests;

namespace LottoApi.Services
{
    public class LottoService
    {


      

        public List<LottoResult> GetTodaysNumbers(string path)
        {
           

            string[] lines = System.IO.File.ReadAllLines(path);
            var finalLines = lines.ToList();
            finalLines.RemoveRange(0,5);
            var finalFinal = finalLines.GetRange(0, 200).ToList();
            var finalResultList = new List<LottoResult>();
            for (var x = 0; x < 200; x ++)
            {
                var row = finalFinal[x].Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

                var lottoResult = new LottoResult(){DrawNumber = Int32.Parse(row[0]), NUM1 =  Int32.Parse(row[5]), NUM2 =  Int32.Parse(row[6]), NUM3 =  Int32.Parse(row[7])};

                 finalResultList.Add(lottoResult);
            }


            const int sampleSize = 10;
            var testSample = finalResultList.GetRange(0, sampleSize).ToList();
            var highPercentile = sampleSize *.55;
            var ascendTest = new AscendingNumbers();

            var firstSecondThird = testSample.Count(t => ascendTest.FirstSecondThird(t.NUM1, t.NUM2, t.NUM3));

            var firstThirdSecond = testSample.Count(t => ascendTest.FirstThirdSecond(t.NUM1, t.NUM2, t.NUM3));

            var secondFirstThird = testSample.Count(t => ascendTest.SecondFirstThird(t.NUM1, t.NUM2, t.NUM3));

            var secondThirdFirst = testSample.Count(t => ascendTest.SecondThirdFirst(t.NUM1, t.NUM2, t.NUM3));

            var thirdFirstSecond = testSample.Count(t => ascendTest.ThirdFirstSecond(t.NUM1, t.NUM2, t.NUM3));

            var thirdSecondFirst = testSample.Count(t => ascendTest.ThirdSecondFirst(t.NUM1, t.NUM2, t.NUM3));

            var repeatingNumbers = new RepeatingNumbers();

            var noRepeatNoRepeatNoRepeat = testSample.Count(t => repeatingNumbers.NoRepeatNoRepeatNoRepeat(t.NUM1, t.NUM2, t.NUM3));

            var noRepeatRepeatRepeat = testSample.Count(t => repeatingNumbers.NoRepeatRepeatRepeat(t.NUM1, t.NUM2, t.NUM3));

            var repeatNoRepeatRepeat = testSample.Count(t => repeatingNumbers.RepeatNoRepeatRepeat(t.NUM1, t.NUM2, t.NUM3));

            var repeatRepeatNoRepeat = testSample.Count(t => repeatingNumbers.RepeatRepeatNoRepeat(t.NUM1, t.NUM2, t.NUM3));

            var repeatRepeatRepeat = testSample.Count(t => repeatingNumbers.RepeatRepeatRepeat(t.NUM1, t.NUM2, t.NUM3));


            var evenOdd = new EvenOdd();
            var evenEvenEven = testSample.Count(t => evenOdd.EvenEvenEven(t.NUM1, t.NUM2, t.NUM3));

            var evenEvenOdd = testSample.Count(t => evenOdd.EvenEvenOdd(t.NUM1, t.NUM2, t.NUM3));

            var evenOddEven = testSample.Count(t => evenOdd.EvenOddEven(t.NUM1, t.NUM2, t.NUM3));

            var evenOddOdd = testSample.Count(t => evenOdd.EvenOddOdd(t.NUM1, t.NUM2, t.NUM3));

            var oddEvenEven = testSample.Count(t => evenOdd.OddEvenEven(t.NUM1, t.NUM2, t.NUM3));

            var oddEvenOdd = testSample.Count(t => evenOdd.OddEvenOdd(t.NUM1, t.NUM2, t.NUM3));

            var oddOddEven = testSample.Count(t => evenOdd.OddOddEven(t.NUM1, t.NUM2, t.NUM3));

            var oddOddOdd = testSample.Count(t => evenOdd.OddOddOdd(t.NUM1, t.NUM2, t.NUM3));

            int total = 0;
            var consecutiveDraws = new ConsecutiveDraws();
            for (var c = 0; c < testSample.Count; c ++)
            {
                if (c + 1 < testSample.Count)
                {
                    var current = testSample[c];
                    var next = testSample[c + 1];
                    if (consecutiveDraws.NextDrawHasOnlyOneNumberFromPrevious(current, next))
                    {
                        total ++;
                    }
                }
                


            }



            return finalResultList;
           



        }
    }
}