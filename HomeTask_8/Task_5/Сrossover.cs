using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    /// <summary>
    /// дочерний класс Кроссовер
    /// </summary>
    public class Сrossover : Car
    {
        /// <summary>
        /// клиренс
        /// </summary>
        public double Clearance { get; set; }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="name">название машины</param>
        /// <param name="year">год выпуска</param>
        /// <param name="clearance">клиренс</param>
        public Сrossover(string name, int year, double clearance) : base(name, year)
        {
            this.Clearance = clearance;
        }
        
        /// <summary>
        /// переопределяем ToString()
        /// </summary>
        /// <returns>строковое представление объекта</returns>
        public override string ToString()
        {
            return base.ToString() + ", Clearance: " +  Clearance;
        }
    }
}
