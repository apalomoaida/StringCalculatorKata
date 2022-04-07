using NUnit.Framework;
using FluentAssertions;

namespace StringCalculatorKata.Test {
    public class Tests {
        [SetUp]
        public void Setup() {
        }
        //retun 0 when string is empty 
        [Test]
        public void return_zero_when_string_is_empty() {
            StringCalculator stringCalculator = new StringCalculator();
            stringCalculator.Should().Be(0);
        }
    }
}