using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2_5
{
    /// <summary>
    /// класс пользователь
    /// </summary>
    class User
    {
        /// <summary>
        /// св-во логин
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// св-во имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// св-во фамилия
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// св-во возраст
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// св-во дата заполнения анкеты
        /// </summary>
        public DateTime Date { get;}

        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="login">логин</param>
        /// <param name="name">имя</param>
        /// <param name="surname">фамилия</param>
        /// <param name="age">возраст</param>
        /// <param name="year">год создания профиля</param>
        /// <param name="month">месяц создания профиля</param>
        /// <param name="day">день создания профиля</param>
        public User(string login, string name, string surname, int age)
        {
            Login = login;
            Name = name;
            Surname = surname;
            Age = age;
            Date = DateTime.Now;
        }

        /// <summary>
        ///  переопределение метода ToString(), наследуемого от базового класса object
        /// </summary>
        /// <returns>информация о пользователе</returns>
        public override string ToString()
        {
            StringBuilder user = new StringBuilder();
            user.Append("Login: " + Login + "\n");
            user.Append("Name: " + Name + "\n");
            user.Append("Surname: " +  Surname + "\n");
            user.Append("Age: " + Age + "\n");
            user.Append("Registed: " + Date + "\n");
            return user.ToString();
        }
    }
}
