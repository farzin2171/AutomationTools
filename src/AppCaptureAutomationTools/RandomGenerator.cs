using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCaptureAutomationTools
{
    public static class RandomGenerator
    {
        public static string GenerateApplicationNumber(string prefix)
        {
             prefix = $"{prefix}-";
            const string fixedChar = "X";
            const int randomLettersCount = 4; // Number of random letters (YYZT)

            // Generate random letters
            var random = new Random();
            var randomLetters = new StringBuilder();
            for (int i = 0; i < randomLettersCount; i++)
            {
                char randomChar = (char)random.Next('A', 'Z' + 1); // Generate a random uppercase letter
                randomLetters.Append(randomChar);
            }

            // Combine all parts
            return $"{prefix}{fixedChar}{randomLetters}";
        }
    }
}
