﻿namespace StringCalculatorKata {
    public class StringCalculator {

        public int Add(string input) {
            var result = 0;
            if (string.IsNullOrEmpty(input)) return result;
            var separators = new List<char> { ',', '\n' };

            if (input.Contains("//")) {
                separators.Add(input[2]);
                input = input.Substring(input.IndexOf("//") + 3);
            }
            var numbers = input.Split(separators.ToArray());
            var negativeNumbers = numbers.Where(n => int.Parse(n) < 0).ToList();
            if (negativeNumbers.Any()) {
                throw new Exception("Negatives not allowed: " + string.Join(",", negativeNumbers));
            }
            foreach (var number in numbers) {
                result += int.Parse(number);
            }

            return result;
        }
    }
}
