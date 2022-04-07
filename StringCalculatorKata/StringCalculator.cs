namespace StringCalculatorKata {
    public class StringCalculator {        

        public int Add(string input) {
            var result = 0;
            if (string.IsNullOrEmpty(input))
                result = 0;
            var numbers = input.Split(',');
            foreach (var number in numbers) {
                result += int.Parse(number);
            }
            return result;
        }
    }
}
