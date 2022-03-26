using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            if (IsLongEnough(password) && HasOnlyLettersAndNumbers(password) && HasTwoNumbers(password))
            {
                Console.WriteLine("Password is valid");
            }
            if (IsLongEnough(password) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (HasOnlyLettersAndNumbers(password) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (HasTwoNumbers(password) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }
        public static bool IsLongEnough(string a)
        {
            bool isLongEnough = false;
            char[] length = a.ToCharArray();
            if (length.Length >= 6 && length.Length <= 10)
            {
                isLongEnough = true;
            }
            return isLongEnough;
        }
        public static bool HasOnlyLettersAndNumbers(string a)
        {
            bool hasOnlyLettersAndNumbers = false;
            char[] length = a.ToCharArray();
            for (int i = 0; i < length.Length; i++)
            {
                if ((length[i] >= 48 && length[i] <= 57) || (length[i] >= 65 && length[i] <= 90) || (length[i] >= 97 && length[i] <= 122))
                {
                    hasOnlyLettersAndNumbers = true;
                }
                else
                {
                    hasOnlyLettersAndNumbers = false;
                    break;
                }
            }
            return hasOnlyLettersAndNumbers;
        }
        public static bool HasTwoNumbers(string a)
        {
            bool hasTwoNumbers = false;
            char[] length = a.ToCharArray();
            int counter = 0;
            for (int i = 0; i < length.Length; i++)
            {
                if ((length[i] >= 48 && length[i] <= 57))
                {
                    counter++;
                }
                if (counter >=2)
                {
                    hasTwoNumbers = true;
                    break;
                }
            }
            return hasTwoNumbers;
        }
    }
}
