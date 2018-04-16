using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class Point
    {
        /// <summary>
        /// координата Х
        /// </summary>
        private int x;

        /// <summary>
        /// координата У
        /// </summary>
        private int y;

        /// <summary>
        /// имя объекта
        /// </summary>
        private string name;

        /// <summary>
        /// св-во возвращает координату Х
        /// </summary>
        public int X { get => x; }

        /// <summary>
        /// св-во возвращает координату У
        /// </summary>
        public int Y { get => y; }

        /// <summary>
        /// св-во возвращает имя объекта
        /// </summary>
        public string Name { get => name; }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="x">координата Х</param>
        /// <param name="y">координата У</param>
        /// <param name="name">имя</param>
        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }
}
