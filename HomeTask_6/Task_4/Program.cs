using System;

namespace Task_4
{
    #region Hometask_06_4
    //
    // Author: Shemet Viktoriya
    //
    // Description: 
    // Implement a program that will take from the user the date of his birth 
    // and display the number of days before his next birthday.
    //
    #endregion

    class Program
    {

        /// <summary>
        /// Method which clear last line on the Console
        /// </summary>
        static void ClearLastLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

        /// <summary>
        /// Read user input and return birthday if it was entered correctly
        /// </summary>
        /// <returns>DateTime of user birthday</returns>
        static DateTime ReadBirthday()
        {
            string enter;
            bool isInputRight;
            DateTime birthday;
            Console.WriteLine("");
            do
            {
                ClearLastLine(); // Clear wrong user input
                Console.Write("Enter your birthday in format yyyy,mm,dd: ");
                enter = Console.ReadLine();
                isInputRight = DateTime.TryParse(enter, out birthday);
            } while (!isInputRight || birthday.CompareTo(DateTime.Now) > 0);
            return birthday;
        }

        /// <summary>
        /// Method counts the number of days before user's next birthday
        /// </summary>
        /// <param name="userBirthday">The user's birthday</param>
        /// <returns>Number of days</returns>
        static int CountDaysBeforeNextBirthday(DateTime userBirthday)
        {
            DateTime now = DateTime.Now;
            TimeSpan interval; // interval between present day and birthday this year 
            DateTime birthdayThisYear = new DateTime(now.Year, userBirthday.Month, userBirthday.Day);
            if (birthdayThisYear < now)
            {
                birthdayThisYear = new DateTime(now.Year + 1, userBirthday.Month, userBirthday.Day);
            }
            interval = birthdayThisYear - now;
            return interval.Days;
        }



        static void Main(string[] args)
        {
            DateTime userBirthday = ReadBirthday();
            Console.WriteLine($"The number of days before next birthday - {CountDaysBeforeNextBirthday(userBirthday)}"); 
            //Delay
            Console.ReadKey();
        }
    }
}
