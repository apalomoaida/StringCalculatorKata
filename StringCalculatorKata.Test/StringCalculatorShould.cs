using NUnit.Framework;
using FluentAssertions;

namespace StringCalculatorKata.Test {
    public class Tests {
        [SetUp]
        public void Setup() {
        }
       
        [Test]
        public void return_zero_when_string_is_empty() {
            StringCalculator stringCalculator = new StringCalculator();
            stringCalculator.Add("").Should().Be(0);
        }
    }
}