using System;
namespace Task_4
{
    #region Hometask_04_2
    //
    // Author: Shemet Viktoriya
    //
    // Description: 
    // Create your own implementations of methods 
    // Substring (int, int),
    // IndexOf (string), 
    // Replace (string, string)
    //
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            string @string = "Hello world!";

            // Example for Method Substring
            Console.WriteLine(@string.ExtensionSubstring(6,6));

            // Example for Method IndexOf
            Console.WriteLine(@string.ExtensionIndexOf("lo")); 
            Console.WriteLine(@string.ExtensionIndexOf("al"));

            // Example for Method Replace
            Console.WriteLine(@string.ExtensionReplace("world", "people"));
            Console.WriteLine(@string.ExtensionReplace("CLR", "C#"));
        }
    }
}
