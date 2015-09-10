using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaLottoApi.Services.Tests
{
    public class RepeatingNumbers
    {


        public bool RepeatRepeatRepeat(int num1, int num2, int num3)
        {
            return (num1 == num2) && (num3 == num2);

        }

        public bool RepeatRepeatNoRepeat(int num1, int num2, int num3)
        {
            return (num1 == num2) && (num3 != num2);

        }

        public bool RepeatNoRepeatRepeat(int num1, int num2, int num3)
        {
            return (num1 != num2) && (num1 == num3);

        }

        public bool NoRepeatRepeatRepeat(int num1, int num2, int num3)
        {
            return (num1 != num2) && (num2 == num3);

        }

        public bool NoRepeatNoRepeatNoRepeat(int num1, int num2, int num3)
        {
            return (num1 != num2) && (num2 != num3) && (num3 != num1);

        }

    }
}