namespace LottoApi.Services.Tests
{
    public class AscendingNumbers
    {

        public bool FirstSecondThird(int num1, int num2, int num3)
        {

            return (num1 + 1 == num2) && (num2 + 1 == num3);

        }

        public bool FirstThirdSecond(int num1, int num2, int num3)
        {

            return (num1 + 1 == num3) && (num3 + 1 == num2);

        }


        public bool ThirdSecondFirst(int num1, int num2, int num3)
        {

            return (num3 + 1 == num2) && (num2 + 1 == num1);
        }

        public bool ThirdFirstSecond(int num1, int num2, int num3)
        {

            return (num2 + 1 == num3) && (num3 + 1 == num1);
        }

        public bool SecondFirstThird(int num1, int num2, int num3)
        {

            return (num2 + 1 == num1) && (num1 + 1 == num3);
        }

        public bool SecondThirdFirst(int num1, int num2, int num3)
        {

            return (num3 + 1 == num1) && num1 + 1 == num2;
        }

    }
}