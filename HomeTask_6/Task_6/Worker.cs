using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    /// <summary>
    /// класс сотрудник
    /// </summary>
    public class Worker
    {
        /// <summary>
        /// должностное колличество часов в месяц
        /// </summary>
        public PositionHoursEnum PositionHours { get; set; }

        /// <summary>
        /// имя сотрудника
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// фамилия сотрудника
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="positionHours">должностные нормативы</param>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        public Worker(PositionHoursEnum positionHours, string name, string surname)
        {
            PositionHours = positionHours;
            Name = name;
            Surname = surname;
        }

        /// <summary>
        /// переопределение метода ToString()
        /// </summary>
        /// <returns>строковая информация о сотруднике</returns>
        public override string ToString()
        {
            StringBuilder data = new StringBuilder();
            data.Append(Name + " " + Surname + " \n");
            data.Append("Position: " + Enum.GetName(typeof(PositionHoursEnum), PositionHours)+ "\n");
            data.Append("Need hours a month"+ ": " + (int)PositionHours);
            return data.ToString();
        }
    }
}
