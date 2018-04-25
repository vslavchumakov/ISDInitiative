using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    /// <summary>
    /// базовый интерфейс автомобиль
    /// </summary>
    public class Car
    {
        /// <summary>
        /// название автомобиля
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// год выпуска
        /// </summary>
        public int YearCreation { get; set; }

        public Car()
        {
            Name = "noname";
            YearCreation = 0;
        }

        public Car(string name, int year)
        {
            this.Name = name;
            this.YearCreation = year;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Year: " + YearCreation;
        }
    }
}
