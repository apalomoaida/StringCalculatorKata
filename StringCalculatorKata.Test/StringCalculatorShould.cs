using NUnit.Framework;
using FluentAssertions;
using System;
using System.Threading.Tasks;

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
        [Test]
        public void string_separated_comma_returns_sum() {
            stringCalculator.Add("1,1,1,1").Should().Be(4);
        }
        [Test]
        public void string_one_enter_two_comma_three_returns_number_six() {
            stringCalculator.Add("1\n2,3").Should().Be(6);
        }

        [Test]
        public void double_slash_set_extra_delimiter() {
            stringCalculator.Add("//;\n1;2").Should().Be(3);
        }
        [Test]
        public void negative_not_allowed() {

            Func<int> delete = () => stringCalculator.Add("-1,-1,-4,5,6");

            delete.Should().Throw<Exception>().And.Message.Should().Be("Negatives not allowed: -1,-1,-4");
        }
        [Test]
        public void greater_than_thousand_ignored() {
            stringCalculator.Add("1,1001,2").Should().Be(3);
        } 
        [Test]
        public void separator_delimited() {
            stringCalculator.Add("//[***]\n1***2***3").Should().Be(6);
        }
        [Test]
        public void multiple_separator_delimited() {
            stringCalculator.Add("//[*][%]\n1*2%3").Should().Be(6);
        }

    }
}