namespace StringCalculatorKata {
    public class StringCalculator {

        public int Add(string input) {
            var result = 0;
            if (string.IsNullOrEmpty(input)) return result;

            var separators = new char[] { ',', '\n' };
            if (input.Contains("//")) {
                separators.ToList().Add(';');
                input = input.Substring(input.IndexOf("//") + 3);
            }
            var numbers = input.Split(separators);
            foreach (var number in numbers) {
                if (number.Length > 0) {
                    result += int.Parse(number);
                }
            }
            return result;
        }
    }
}
