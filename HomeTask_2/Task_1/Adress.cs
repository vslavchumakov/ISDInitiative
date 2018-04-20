using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2_1
{
    /// <summary>
    /// класс адрес
    /// </summary>
    class Address
    {
        /// <summary>
        /// св-во индекс
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// св-во страна
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// св-во город
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// св-во улица
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// св-во дом
        /// </summary>
        public string House { get; set; }

        /// <summary>
        /// св-во квартира
        /// </summary>
        public string Apartment { get; set; }

        /// <summary>
        /// переопределение метода ToString(), наследуемого от базового класса object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder address = new StringBuilder();
            if (Index != 0)
            {
                address.Append("Индекс " + Index + "\n");
            }
            if (!String.IsNullOrEmpty(Country))
            {
                address.Append("Страна " + Country + "\n");
            }
            if (!String.IsNullOrEmpty(City))
            {
                address.Append("Город " + City + "\n");
            }
            if (!String.IsNullOrEmpty(Street))
            {
                address.Append("Улица " + Street + "\n");
            }
            if (!String.IsNullOrEmpty(House))
            {
                address.Append("Дом " + House + "\n");
            }
            if (!String.IsNullOrEmpty(Apartment))
            {
                address.Append("Квартира " + Apartment + "\n");
            }
            return address.ToString();
        }

    }
}
