using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TestingAssignment
{
    public static class AssignmentBLL
    {
        /// <summary>
        /// 1. lowercase characters converted to uppercase.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
      
        public static String AddUpperCase(this String input)
        {
            StringBuilder str = new StringBuilder(input);
            int ln = str.Length;

            for (int i = 0; i < ln; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                    str[i] = (char)(str[i] - 32);
            }
            return str.ToString();
        }

        /// <summary>
        /// 2.uppercase characters converted to lowercase and vice versa.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>

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

        /// <summary>
        /// 3.string to title case 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
       
        public static string TitleCase(this string str)
        {
            str = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
            return str;
        }

        /// <summary>
        /// 4.lower case or not
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
       

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

        /// <summary>
        /// 5.first character have upper case and the rest lower case.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
       
        public static string FirstUpperLetter(this string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }

        /// <summary>
        /// 6.upper case or not
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        
        public static bool CheckUpperCase(this String str)
        {
            int ln = str.Length;

            for (int i = 0; i < ln; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 7.valid numeric value or not.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>  
      
        public static bool NumberValidation(this String input)
        {
            int n;
            bool isNumeric = int.TryParse(input, out n);
            return isNumeric;
        }

        /// <summary>
        /// 8.remove the last character from given the string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
  
        public static String LastCharacterRemove(this String str)
        {
            if (str == null)
                return null;
            else
                return str.Substring(0, str.Length - 1);
        }

        /// <summary>
        /// 9-word count from an input string.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>

        public static int WordCount(this String input)
        {
            int ln = input.Length;
            String[] words = input.Split(' ');

            return words.Length;
        }

        /// <summary>
        /// 10. input string to integer.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
       
         public static int StringToInt(this String input)
        {
            int x = 0;

            Int32.TryParse(input, out x);
            return x;
        }
    }
}
