using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_8
{
    /// <summary>
    /// 3.8. Напишите программу, которая будет «спрашивать» правильный пароль,
    /// до тех пор, пока он не будет введен. Правильный пароль пусть будет «root».
    /// Если пароль не верный, программа должна сказать "Неверный пароль!"
    /// </summary>
    class Program
    {
        /// <summary>
        /// пароль
        /// </summary>
        private static string _truePassword = "root";

        /// <summary>
        /// запрашиваем пароль
        /// </summary>
        private static void GetPassword()
        {
            string password;
            do
            {
                Console.Write("Введите пароль: ");
                password = Console.ReadLine();
            } while (_truePassword != password);
            Console.WriteLine("Привет админ!");
        }

        static void Main(string[] args)
        {
            GetPassword();
        }
    }
}
