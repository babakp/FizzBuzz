using System;


namespace FizzBuzzLibrary
{
    public class FizzBuzz
    {
        public FizzBuzz()
        {
        }

        public string MultipleThree(int num)
        {
            if (num % 3 == 0)
                return "Fizz";
            else
                return "";

        }

        public string MultipleFive(int num)
        {
            if (num % 5 == 0)
                return "Buzz";
            else
                return "";
        }

        public string Output(int num)
        {
            if ((MultipleFive(num).Trim() + MultipleThree(num).Trim()) == "")
                return (num.ToString());
             else
                return (MultipleThree(num) + MultipleFive(num) ).Trim();
        }
    }
}