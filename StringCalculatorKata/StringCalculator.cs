namespace StringCalculatorKata {
    public class StringCalculator {

        public int Add(string input) {
            var result = 0;
            if (string.IsNullOrEmpty(input)) return result;
            var separators = new List<string> { ",", "\n" };

            if (input.Contains("//")) {
                if (input.Contains("[") && input.Contains("]")) {
                    var customSeparator = input.Substring(3, input.IndexOf("]") - 3);
                    separators.Add(customSeparator);
                    input = input.Replace("//[" + customSeparator + "]", "");                    
                    while (input.Contains("[")) {
                        var start = input.IndexOf("[");
                        var end = input.IndexOf("]");
                        var separator = input.Substring(start + 1, end - start - 1);
                        separators.Add(separator);
                        input = input.Remove(start, end - start + 1);                        
                    }
                   
                }
                else {

                    separators.Add(input[input.IndexOf("//") + 2].ToString());
                    input = input.Substring(input.IndexOf("//") + 3);
                }
            }
            var numbers = input.Split(separators.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            var negativeNumbers = numbers.Where(n => n.Contains("-")).ToList();
            if (negativeNumbers.Any()) {
                throw new Exception("Negatives not allowed: " + string.Join(",", negativeNumbers));
            }
            foreach (var number in numbers) {
                if (number.Length > 0) {
                    if (int.Parse(number) <= 1000)
                        result += int.Parse(number);
                }
            }

            return result;
        }
    }
}
