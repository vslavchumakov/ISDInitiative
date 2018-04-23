using System;
using System.Text;

namespace Task_4
{
    static class ExtensionString
    {
        /// <summary>
        /// Substring returns a new string that is a substring of this string. The substring begins at the specified given index and extended up to the given length.
        /// </summary>
        /// <param name="str">The string we pass to the method</param>
        /// <param name="startIndex">The index of the start of the substring.</param>
        /// <param name="length">The number of characters in the substring.</param>
        /// <returns></returns>        
        public static string ExtensionSubstring(this string str, int startIndex, int length)
        {
            char[] arrayChar = new char[length];
            try
            {
                for (int i = 0; i < length; i++)
                {
                    arrayChar[i] = str[startIndex + i];
                }
                return new string(arrayChar);
            }
            catch (IndexOutOfRangeException ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// The IndexOf method returns the index of the first occurrence of the specified substring.
        /// </summary>
        /// <param name="inputStr">The string we pass to the method</param>
        /// <param name="str">The parameter string to check its occurrences</param>
        /// <returns>
        ///  Integer - If the parameter String occurred as a substring in the specified String
        ///  it returns position of the first character of the substring.
        ///  If it does not occur as a substring, -1 is returned.
        ///  </returns>
        public static int ExtensionIndexOf(this string inputStr, string str)
        {
            string[] split = new string[inputStr.Length - str.Length + 1]; ;
            for (int i = 0; i <split.Length; i++)
            {
                split[i] = ExtensionSubstring(inputStr, i, str.Length);
                if (split[i] == str)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Returns a new string in which all occurrences of a specified string 
        /// in the current instance are replaced with another specified string.
        /// </summary>
        /// <param name="inputStr">The string we pass to the method</param>
        /// <param name="oldValue">The string to be replaced.</param>
        /// <param name="newValue">The string to replace all occurrences of oldValue.</param>
        /// <returns>
        /// A string that is equivalent to the current string except that
        /// all instances of oldValue are replaced with newValue.
        /// If oldValue is not found in the current instance, 
        /// the method returns the current instance unchanged.
        /// </returns>
        public static string ExtensionReplace(this string inputStr, string oldValue, string newValue)
        {
            StringBuilder newStr = new StringBuilder();
            for (int i = 0; i < inputStr.Length; i++)
            {
                if (IsSubstr(inputStr, i, oldValue))
                {
                    newStr.Append(newValue);
                    i += oldValue.Length - 1;
                }
                else newStr.Append(inputStr[i]);
            }
            return newStr.ToString();
        }


        /// <summary>
        /// Predicate defines if substr is in str on the index position
        /// </summary>
        /// <param name="str"></param>
        /// <param name="index"></param>
        /// <param name="substr"></param>
        /// <returns></returns>
        private static bool IsSubstr(string str, int index, string substr)
        {
            for (int i = 0; i < substr.Length; i++)
            {
                if (substr[i] != str[index + i]) return false;
            }
            return true;
        }
    }
}
