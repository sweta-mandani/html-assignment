using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TestingAssignment
{
    public static class AssignmentBLL
    {
<<<<<<< HEAD

        // 1. lowercase characters converted to uppercase.
        public static String AddUpperCase(this String input)
=======

        // lowercase characters converted to uppercase.
        public static String AddUpperCase(String str)
        {

            str = str.ToUpper();
            return str;
        }


        //uppercase characters converted to     lowercase and vice versa.
        public static String AddLowerCase(String str)
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
        {
            str = str.ToLower();
            return str;

<<<<<<< HEAD
            for (int i = 0; i < ln; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                    str[i] = (char)(str[i] - 32);
            }
            return str.ToString();
        }

        //2.uppercase characters converted to     lowercase and vice versa.
        public static String AddLowerCase(this String input)
        {
            StringBuilder str = new StringBuilder(input);
            int ln = str.Length;

            for (int i = 0; i < ln; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                    str[i] = (char)(str[i] + 32);
            }
            return str.ToString();
        }

        //3.string to title case 
        public static string TitleCase(this string str)
        {
            str = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
            return str;
        }

        //4.lower case or not
        public static bool CheckLowerCase(this String str)
        {
            int ln = str.Length;
=======
        }

        //string to title case 
        public static string TitleCase(string str)
        {
           str = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
            return str;
        }

>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812

        //lower case or not

<<<<<<< HEAD
        // 5.first character have upper case and the rest lower case.
        public static string FirstUpperLetter(this string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }


        //6.upper case or not
        public static bool CheckUpperCase(this String str)
=======
        public static bool CheckLowerCase(this String str)
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
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

<<<<<<< HEAD
        //7.valid numeric value or not.
=======
        //first character have upper case and the rest lower case.
        public static string FirstUpperLetter(String str)
        {
            if (str == null)
                return null;
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812

        public static bool NumberValidation(this String input)
        {
            int n;
            bool isNumeric = int.TryParse(input, out n);
            return isNumeric;
        }
        //upper case or not
        public static bool CheckUpperCase(String str)
        {
            foreach (char input in str)
            {
                if (Char.IsUpper(input))
                    return str;
            }
            return str;
        }


<<<<<<< HEAD
        //8.remove the last character from given the string
        public static String LastCharacterRemove(this String str)
=======
        //valid numeric value or not.
        public static bool NumberValidation(String input)
        {
            int n;
            bool isNumeric = int.TryParse(input, out n);
            return isNumeric;
        }

=======

        //valid numeric value or not.
        public static bool NumberValidation(String input)
        {
            int n;
            bool isNumeric = int.TryParse(input, out n);
            return isNumeric;
        }


        //remove the last character from given the string
        public static String LastCharacterRemove(String str)
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
        {
            if (str == null)
                return null;
            else
                return str.Remove(str.Length - 1);

        }


        //    word count from an input string.
        public static int WordCount(this String input)
        {


            int ln = input.Length;
            String[] words = input.Split(' ');

            return words.Length;
        }


        }


        //    word count from an input string.
        public static int WordCount(this String input)
        {


            int ln = input.Length;
            String[] words = input.Split(' ');

            return words.Length;
        }

<<<<<<< HEAD
        //9-word count from an input string.
        public static int WordCount(this String input)
        {
            int ln = input.Length;
            String[] words = input.Split(' ');

            return words.Length;
        }


        //10.input string to integer.

        public static int StringToInt(this String input)
=======

        // input string to integer.
        public static int StringToInt(String input)
>>>>>>> 629a58571175ef9707ce094f74f8f06f26139812
        {
            int x = 0;

            Int32.TryParse(input, out x);
            return x;
        }
    }
}

