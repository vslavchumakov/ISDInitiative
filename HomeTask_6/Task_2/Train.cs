using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    /// <summary>
    /// структура поезд
    /// </summary>
    struct Train
    {
        /// <summary>
        /// пункт назначения
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// номер поезда
        /// </summary>
        public int NumberTrain { get; set; }

        /// <summary>
        /// время отправление
        /// </summary>
        public DateTime DepartureTime { get; set; }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="desttnation">пункт назначения</param>
        /// <param name="number">номер поезда</param>
        /// <param name="date">данные время отправления год</param>
        public Train(string destination, int number, DateTime date)
        {
            Destination = destination;
            NumberTrain = number;
            DepartureTime = date;
        }

        /// <summary>
        /// метод выводит информацию о поезде, переопределенный метод ValueType.ToString()
        /// </summary>
        /// <returns>строковая информация об объекте</returns>
        public override string ToString()
        {
            StringBuilder train = new StringBuilder();
            train.Append("Destination: " + Destination + "\n");
            train.Append("Number: " + NumberTrain + "\n");
            train.Append("Departure data: " + DepartureTime + "\n");
            return train.ToString();
        }
    }
}
