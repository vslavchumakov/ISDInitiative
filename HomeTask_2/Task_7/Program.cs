using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        /// <summary>
        ///Создать класс Employee.
        ///В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и
        ///инициализирует поля, соответствующие фамилии и имени сотрудника.
        ///Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый сбор.
        ///Написать программу, которая выводит на экран информацию о сотруднике(фамилия, имя, должность), оклад и налоговый сбор.
        /// </summary>


        static void Main(string[] args)
        {
            Employee employee = new Employee("Ivan", "Ivanov")
            {
                Position = "Cleaner",
                Experience = 2
            };

            employee.GetInfo();

            Employee employee1 = new Employee("Gleb", "Fedorov")
            {
                Position = "Security",
                Experience = 1
            };

            employee1.GetInfo();

            Employee employee2 = new Employee("Anna", "Frolova")
            {
                Position = "Nurs",
                Experience = 3
            };

            employee2.GetInfo();

            Console.ReadKey();
        }
    }
}
