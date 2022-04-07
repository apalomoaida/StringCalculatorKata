namespace StringCalculatorKata {
    public class StringCalculator {

        public int Add(string input) {
            if (string.IsNullOrEmpty(input)) return 0;
            
            var result = 0;
            var numbers = input.Split(',', '\n');
            foreach (var number in numbers) {
                result += int.Parse(number);
            }
            return result;
        }
    }
}
