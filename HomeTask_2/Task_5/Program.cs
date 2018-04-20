using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2_5
{
    /// <summary>
    /// Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата заполнения анкеты). 
    /// Поле дата заполнения анкеты должно быть проинициализировано только один раз (при создании экземпляра данного класса)
    /// без возможности его дальнейшего изменения.
    // Реализуйте вывод на экран информации о пользователе.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("root","Alex","Smit",33,2017,10,5);
            Console.WriteLine(user);
            Console.ReadKey();
        }
    }
}
