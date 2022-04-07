using NUnit.Framework;
using FluentAssertions;

namespace StringCalculatorKata.Test {
    public class Tests {
        private StringCalculator stringCalculator;

        [SetUp]
        public void Setup() {
            stringCalculator = new StringCalculator();
        }
       
        [Test]
        public void return_zero_when_string_is_empty() {
            stringCalculator.Add("").Should().Be(0);
        }

        [Test]
        public void string_one_returns_number_one() {
            stringCalculator.Add("1").Should().Be(1);
        }  
        [Test]
        public void string_one_comma_two_returns_number_three() {
            stringCalculator.Add("1,2").Should().Be(3);
        }
    }
}