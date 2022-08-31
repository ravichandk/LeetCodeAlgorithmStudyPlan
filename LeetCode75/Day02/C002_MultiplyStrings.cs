namespace LeetCode75.Day02
{
    public class C002_MultiplyStrings
    {
        public static void Solution()
        {
            decimal v1 = 498828660196;
            decimal v2 = 840477629533;
            var m = (v1 * v2).ToString("N0");

            //var result = Multiply("123", "6");    //738
            //var result = Multiply("123", "456");    //56088
            //var result = Multiply("881095803", "61");     //53746843983
            var result = Multiply("498828660196", "840477629533");    //419254329864656431168468

            //var add = Add("123456", "24");

            var x = result;
        }

        private static string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0") return "0";
            if (num1 == "1" ) return num2;
            if (num2 == "1") return num1;

            var result = "";
            var zeroes = "";

            for (var i = 0; i < num2.Length; i++)
            {
                var value = Multiply(num1, num2[num2.Length - 1 - i]) + zeroes;
                result = Add(value, result);
                //System.Console.WriteLine($"{num1} * {num2[num2.Length - 1 - i]} = {value}; result: {result}");

                zeroes += "0";
            }

            return result.ToString();
        }

        private static string Multiply(string num1, char ch)
        {
            var charInt = (int)ch - (int)'0';
            var carry = 0;

            if (charInt == 0) return "0";

            var j = 0;
            var result = "";

            for (var i = num1.Length - 1; i >= 0; i--)
            {
                var value = ((int)num1[i] - (int)'0') * charInt + carry;
                var lastDigit = value % 10;
                carry = value / 10;
                result = lastDigit.ToString() + result;
            }

            if (carry > 0)
            {
                result = carry.ToString() + result;
            }

            return result;
        }

        private static string Add(string num1, string num2)
        {
            if (string.IsNullOrWhiteSpace(num1)) return num2;
            if (string.IsNullOrWhiteSpace(num2)) return num1;

            if (num2 == "0") return num1;
            if (num1 == "0") return num2;

            var result = "";
            var lastIndex = num1.Length <= num2.Length ? num1.Length : num2.Length;
            var carry = 0;

            for (var i = 0; i < lastIndex; i++)
            {
                //var value = Add(num1, num2[num2.Length - 1 - i]);
                //result = value + result;

                var digit1 = num1[num1.Length - 1 - i] - '0';
                var digit2 = num2[num2.Length - 1 - i] - '0';

                var digitSum = digit1 + digit2 + carry;
                var lastDigit = digitSum % 10;
                carry = digitSum / 10;

                result = lastDigit.ToString() + result;
            }

            for (var i = num1.Length - lastIndex - 1; i >= 0; i--)
            {
                var digit1 = num1[i] - '0';
                var digitSum = digit1 + carry;
                var lastDigit = digitSum % 10;
                carry = digitSum / 10;

                result = lastDigit.ToString() + result;
            }

            for (var i = num2.Length - lastIndex - 1; i >= 0; i--)
            {
                var digit1 = num2[i] - '0';
                var digitSum = digit1 + carry;
                var lastDigit = digitSum % 10;
                carry = digitSum / 10;

                result = lastDigit.ToString() + result;
            }

            if (carry > 0)
            {
                result = carry.ToString() + result;
            }

            return result.ToString();
        }
    }
}
