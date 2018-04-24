using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Printer
    {
        private static Random _random = new Random();
        private static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(_random.Next(consoleColors.Length));
        }
        /// <summary>
        /// values suppose to be parameters with 
        /// different data tipes string/integer/float etc.
        /// and all value should be a single string.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static void Print(params object[] args)
        {
            //string sum = "";
            int i = 1;
            
            foreach (object arg in args)
            {
                try
                {
                    if (arg == null)
                    {
                        throw new ArgumentNullException();
                    }
                    else
                    {
                        Console.ForegroundColor = GetRandomConsoleColor();
                        Console.WriteLine("\n Argument number " + i + " is: " + arg.ToString());
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.ForegroundColor = GetRandomConsoleColor();
                    Console.WriteLine("Argument number {0} :{1} is bad", i, ex);
                    /*
                    Console.WriteLine(ex);
                    Console.WriteLine("HelpLink = {0}", ex.HelpLink);
                    Console.WriteLine("Message = {0}", ex.Message);
                    Console.WriteLine("Source = {0}", ex.Source);
                    Console.WriteLine("StackTrace = {0}", ex.StackTrace);
                    Console.WriteLine("TargetSite = {0}", ex.TargetSite);
                */
                    i++;
                    continue;
                }
                finally
                {
                    Console.WriteLine("Added rgument number " + i );
                    i++;
                }
                
            }
            Console.WriteLine("Adding and printing arguments is completed!");
        }
    }
}
