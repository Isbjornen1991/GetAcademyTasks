using System;
using System.Collections.Generic;
using System.Text;

namespace GetAcademyTasks
{
    public class TextHelper
    {
        public static string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            // Convert string to a character array, reverse it, and build a new string
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}