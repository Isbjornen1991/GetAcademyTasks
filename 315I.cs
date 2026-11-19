namespace GetAcademyTasks
{
    internal class _315I
    {

        public static void RandomPasswordGenerator()
        {

            int passwordLength = 5;

            bool isValidLength = false;

            while (!isValidLength)
            {
                Console.WriteLine("How long would you like your generated password to be?");
                if (int.TryParse(Console.ReadLine(), out passwordLength))
                {
                    isValidLength = true;
                }
                else
                {
                    Console.WriteLine("Invalid length or input type. Please enter a whole number.");
                }
            }

            Console.WriteLine("""
                              Please enter which elements you want to include in your password. 
                              - l = lower case letter
                              - L = upper case letter
                              - d = number
                              - s = special character(!"#¤%&/(){}[]
                              """);

            bool isValidComponents = false;

            while (!isValidComponents)
            {
                string requestedPasswordComponents = Console.ReadLine();
            }

        }



    }
}
