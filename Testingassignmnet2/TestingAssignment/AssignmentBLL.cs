using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TestingAssignment
{
    public static class AssignmentBLL
    {

        // lowercase characters converted to uppercase.
        public static String AddUpperCase(String str)
        {

            str = str.ToUpper();
            return str;
        }


        //uppercase characters converted to     lowercase and vice versa.
        public static String AddLowerCase(String str)
        {
            str = str.ToLower();
            return str;

        }

        //string to title case 
        public static string TitleCase(string str)
        {
           str = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
            return str;
        }


        //lower case or not

        public static bool CheckLowerCase(this String str)
        {
            int ln = str.Length;

            for (int i = 0; i < ln; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    return false;
                }
            }
            return true;
        }

        //first character have upper case and the rest lower case.
        public static string FirstUpperLetter(String str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }
        //upper case or not
        public static bool CheckUpperCase(this String str)
        {
            foreach (char input in str)
            {
                if (Char.IsUpper(input))
                    return str;
            }
            return str;
        }
<<<<<<< HEAD

        //valid numeric value or not.
        public static bool NumberValidation(this String input)
        {
            int n;
            bool isNumeric = int.TryParse(input, out n);
            return isNumeric;
        }

=======

        //valid numeric value or not.
        public static bool NumberValidation(this String input)
        {
            int n;
            bool isNumeric = int.TryParse(input, out n);
            return isNumeric;
        }

>>>>>>> f424c21c6d4bb9146d5efc073f740de34d4c5987
        //remove the last character from given the string
        public static String LastCharacterRemove(this String str)
        {
            if (str == null)
                return null;
            else
                return str.Remove(str.Length - 1);
<<<<<<< HEAD
        }


        //    word count from an input string.
        public static int WordCount(this String input)
        {


            int ln = input.Length;
            String[] words = input.Split(' ');

            return words.Length;
        }

=======
        }


        //    word count from an input string.
        public static int WordCount(this String input)
        {


            int ln = input.Length;
            String[] words = input.Split(' ');

            return words.Length;
        }

>>>>>>> f424c21c6d4bb9146d5efc073f740de34d4c5987
        // input string to integer.
        public static int StringToInt(this String input)
        {
            int x = 0;

            Int32.TryParse(input, out x);
            return x;
        }
    }
}

