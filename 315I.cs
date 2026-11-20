namespace GetAcademyTasks
{
    internal class _315I
    {

        public static string PasswordGenerator(string pwLength, string pwContents)
        {
            // Variables
            Random random = new Random();
            // Output
            string output = "";

            string onFail = "Invalid input. Please check the options above and try again.";

            //Password Contents
            char[] lowerCaseChars =
                                    [
                                        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                                        'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
                                    ];

            // Digits Array
            char[] digits = ['1', '2', '3', '4', '5', '6', '7', '8', '9'];

            // Lowercase Array
            char[] specialChars = ['(', '!', '"', '#', '¤', '%', '&', '/', '(', ')', '{', '}', '[', ']', ']', ';'];

            // Uppercase Array
            char[] upperCaseChars = new char[lowerCaseChars.Length];
            for (int i = 0; i < lowerCaseChars.Length; i++)
            {
                upperCaseChars[i] = char.ToUpper(lowerCaseChars[i]);
            }

            // Checks
            if (!IsValid(pwLength, pwContents, out int passwordLength, out bool contentsTooShort))
            {
                return onFail;
            }
            else
            {
                string pattern = pwContents;

                pattern = fixMissingLength(passwordLength, contentsTooShort, pattern);

                output = BuildPasswordFromPattern(
                    pattern,
                    random,
                    lowerCaseChars,
                    upperCaseChars,
                    digits,
                    specialChars);
            }

            output = ShufflePassword(output, random);

            return output;
        }

        private static string BuildPasswordFromPattern(
            string pattern,
            Random random,
            char[] lowerCaseChars,
            char[] upperCaseChars,
            char[] digits,
            char[] specialChars)
        {
            string generated = "";

            foreach (char c in pattern)
            {
                if (c == 'l')
                {
                    int index = random.Next(0, lowerCaseChars.Length);
                    generated += lowerCaseChars[index];
                }
                else if (c == 'L')
                {
                    int index = random.Next(0, upperCaseChars.Length);
                    generated += upperCaseChars[index];
                }
                else if (c == 'd')
                {
                    int index = random.Next(0, digits.Length);
                    generated += digits[index];
                }
                else if (c == 's')
                {
                    int index = random.Next(0, specialChars.Length);
                    generated += specialChars[index];
                }
            }

            return generated;
        }

        private static string fixMissingLength(int passwordLength, bool contentsTooShort, string pattern)
        {
            if (contentsTooShort == true)
            {
                int missingCount = passwordLength - pattern.Length;

                for (int i = 0; i < missingCount; i++)
                {
                    pattern += 'l';
                }
            }

            return pattern;
        }

        private static bool IsValid(string pwLength, string pwContents, out int passwordLength, out bool contentsTooShort)
        {
            passwordLength = 0;
            contentsTooShort = false;

            if (pwLength.Length == 0)
            {
                return false;
            }


            // First Param Checks
            foreach (char c in pwLength)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            if (!int.TryParse(pwLength, out passwordLength))
            {
                return false;
            }

            if (passwordLength <= 0)
            {
                return false;
            }

            if (passwordLength < pwContents.Length)
            {
                return false;
            }

            // Second Param Checks
            if (pwContents.Length < passwordLength)
            {
                contentsTooShort = true;
            }

            char[] validPwContents = ['l', 'L', 'd', 's'];

            foreach (char c in pwContents)
            {
                if (Array.IndexOf(validPwContents, c) == -1)
                {
                    return false;
                }
            }

            return true;
        }

        private static string ShufflePassword(string password, Random random)
        {
            char[] characters = password.ToCharArray();

            for (int i = characters.Length - 1; i > 0; i--)
            {
                int swapIndex = random.Next(0, i + 1);

                char temp = characters[i];
                characters[i] = characters[swapIndex];
                characters[swapIndex] = temp;
            }

            return new string(characters);
        }
    }
}