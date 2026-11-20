namespace GetAcademyTasks
{
    internal class _315I
    {

        public static string PasswordGenerator(string pwLength, string pwContents)
        {
            // Variables

            // Output
            string output = "";

            string onFail = "PasswordGenerator\r\nOptions:\r\n-l = liten bokstav\r\n- L = stor bokstav\r\n- d = siffer\r\n- s = spesialtegn(!\"#¤%&/(){}[]\r\nEksempel: PasswordGenerator 14 lLssdd\r\n    betyr\r\n        Min. 1 liten bokstav\r\n        Min. 1 1 stor bokstav\r\n        Min. 2 spesialtegn\r\n        Min. 2 sifre\r\n        Lengde på passordet skal være 14";

            //Password Contents
            char[] lowerCaseChars =
                                    [
                                        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                                        'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
                                    ];

            char[] upperCaseChars = new char[lowerCaseChars.Length];

            char[] digits = ['1', '2', '3', '4', '5', '6', '7', '8', '9'];

            char[] specialChars = ['(', '!', '"', '#', '¤', '%', '&', '/', '(', ')', '{', '}', '[', ']', ']', ';'];

            for (int i = 0; i < lowerCaseChars.Length; i++)
            {
                upperCaseChars[i] = char.ToUpper(lowerCaseChars[i]);
            }



            // Checks

            if (pwLength.Length == 0)
            {
                return onFail;
            }

            bool hasValidLength;
            bool hasValidContents;
            bool contentsTooShort = false;

            int passwordLength;


            // First Param Checks
            foreach (char c in pwLength)
            {
                if (!char.IsDigit(c))
                {
                    return onFail;
                }
            }

            if (int.TryParse(pwLength, out passwordLength))
            {
                hasValidLength = true;
            }
            else
            {
                return onFail;
            }

            if (passwordLength <= 0)
            {
                return onFail;
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
                    return onFail;
                }
            }

        }
    }
}


