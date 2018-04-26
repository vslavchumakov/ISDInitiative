using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    /// <summary>
    /// дочерний класс Гоночный автомобиль
    /// </summary>
    public class RacingCar : Car
    {
        /// <summary>
        /// максимальная скорость
        /// </summary>
        public double MaxSpeed { get; set; }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="name">название машины</param>
        /// <param name="year">год выпуска</param>
        /// <param name="maxSpeed">максимальная развиваемая скорость</param>
        public RacingCar(string name, int year, double maxSpeed) : base(name, year)
        {
            this.MaxSpeed = maxSpeed;
        }

        /// <summary>
        /// переопределяем ToString()
        /// </summary>
        /// <returns>строковое представление объекта</returns>
        public override string ToString()
        {
            return base.ToString()+ ", Max Speed: " + MaxSpeed;
        }
    }
}
