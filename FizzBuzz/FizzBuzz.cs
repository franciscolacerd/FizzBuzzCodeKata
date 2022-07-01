namespace FizzBuzzCodeKata
{
    internal class FizzBuzz
    {
        public FizzBuzz()
        {
        }

        internal string ConvertStep1(int number)
        {
            return 1.ToString();//faking it
        }

        internal string ConvertStep2(int number)
        {
            if (number.Equals(2)) return 2.ToString();//Obvious Implementation

            return 1.ToString();//faking it
        }

        internal string ConvertStep3(int number)
        {
            if (number.Equals(4)) return 4.ToString();// Rule Of Three - Only refactor after three obvious Implementations

            if (number.Equals(2)) return 2.ToString();//Obvious Implementation

            return 1.ToString();//faking it
        }

        //Refactor
        internal string ConvertStep4(int number)
        {
            return number.ToString();
        }

        //triangulation
        internal string ConvertStep5(int number)
        {
            if (number.Equals(3)) { return "Fizz"; }

            return number.ToString();
        }

        internal string ConvertStep6(int number)
        {
            if (number.Equals(3)) { return "Fizz"; }

            if (number.Equals(5)) { return "Buzz"; }

            return number.ToString();
        }

        internal string ConvertStep7(int number)
        {
            if (number.Equals(3)) { return "Fizz"; }

            if (number.Equals(5)) { return "Buzz"; }

            if (number.Equals(15)) { return "FizzBuzz"; }

            return number.ToString();
        }

        internal string Convert(int number)
        {
            if (number % 15 == 0) { return "FizzBuzz"; }

            if (number % 3 == 0) { return "Fizz"; }

            if (number % 5 == 0) { return "Buzz"; }

            return number.ToString();
        }
    }
}