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
            // Figure out why must char be an array here
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}