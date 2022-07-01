using FluentAssertions;

namespace FizzBuzzCodeKata
{
    public class FizzBuzzShould
    {
        /// <summary>
        ///If the number is a multiple of three, return the string "Fizz".
        ///If the number is a multiple of five, return the string "Buzz".
        ///If the number is a multiple of both three and five, return the string "FizzBuzz".
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FizzBuzz_Convert_1_to_1_Return_1()
        {
            var result = new FizzBuzz().ConvertStep1(1);

            result.Should().Be("1");
        }

        [Test]
        public void FizzBuzz_Convert_2_to_2_Return_2()
        {
            var result = new FizzBuzz().ConvertStep2(2);

            result.Should().Be("2");
        }

        [Test]
        public void FizzBuzz_Convert_4_to_4_Return_4()
        {
            var result = new FizzBuzz().ConvertStep3(4);

            result.Should().Be("4");
        }

        [Test]
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(4, "4")]
        public void FizzBuzz_ConvertNumberToNumbersString_ReturnString(int input, string expectedOutput)
        {
            var result = new FizzBuzz().ConvertStep4(input);

            expectedOutput.Should().Be(result);
        }

        [Test]
        public void FizzBuzz_Convert_3_To_Fizz_ReturnFizz()
        {
            var result = new FizzBuzz().ConvertStep5(3);

            result.Should().Be("Fizz");
        }

        [Test]
        public void FizzBuzz_Convert_5_To_Fizz_ReturnBuzz()
        {
            var result = new FizzBuzz().ConvertStep6(5);

            result.Should().Be("Buzz");
        }

        [Test]
        public void FizzBuzz_Convert_15_To_FizzBuzz_ReturnFizzBuzz()
        {
            var result = new FizzBuzz().ConvertStep7(15);

            result.Should().Be("FizzBuzz");
        }

        [Test]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        public void FizzBuzz_ConvertNumberToFizzBuzzString_ReturnString(int input, string expectedOutput)
        {
            var result = new FizzBuzz().Convert(input);

            expectedOutput.Should().Be(result);
        }
    }
}