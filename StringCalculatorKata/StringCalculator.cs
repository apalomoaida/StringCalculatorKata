namespace StringCalculatorKata {
    public class StringCalculator {
        public StringCalculator() {

        }

        public int Add(string number) {
            var result = 0;
            if (string.IsNullOrEmpty(number))
                result = 0;
            return result;
        }
    }
}
