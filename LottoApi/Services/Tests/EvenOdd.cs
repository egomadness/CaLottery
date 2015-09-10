namespace LottoApi.Services.Tests
{
    public class EvenOdd
    {



        public static bool IsEven(int value)
        {
            return value % 2 == 0;
        }



        public bool EvenEvenEven(int num1, int num2, int num3)
        {
            return IsEven(num1) && IsEven(num2) && IsEven(num3);

        }

        public bool EvenEvenOdd(int num1, int num2, int num3)
        {
            return IsEven(num1) && IsEven(num2) && !IsEven(num3);

        }

        public bool EvenOddOdd(int num1, int num2, int num3)
        {
            return IsEven(num1) && !IsEven(num2) && !IsEven(num3);

        }




        public bool OddOddOdd(int num1, int num2, int num3)
        {
            return !IsEven(num1) && !IsEven(num2) && !IsEven(num3);

        }

        public bool OddEvenEven(int num1, int num2, int num3)
        {
            return !IsEven(num1) && IsEven(num2) && IsEven(num3);

        }

        public bool OddOddEven(int num1, int num2, int num3)
        {
            return !IsEven(num1) && !IsEven(num2) && IsEven(num3);

        }



        public bool EvenOddEven(int num1, int num2, int num3)
        {
            return IsEven(num1) && !IsEven(num2) && IsEven(num3);

        }


        public bool OddEvenOdd(int num1, int num2, int num3)
        {
            return !IsEven(num1) && IsEven(num2) && !IsEven(num3);

        }



       
      
    }
}