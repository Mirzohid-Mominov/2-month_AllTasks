using System.Text.RegularExpressions;

namespace StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define a regular expression pattern
            string pattern = @"^\d{3}-\d{2}-\d{4}$"; // Matches US Social Security numbers in the format xxx-xx-xxxx

            // Test a string against the regular expression pattern
            string input = "123-45-6789";
            bool isMatch = Regex.IsMatch(input, pattern);

            // Print the result
            Console.WriteLine(isMatch); // Output: True
        }
    }
}