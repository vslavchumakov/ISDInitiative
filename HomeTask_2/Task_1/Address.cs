using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Address
    {
        private int index;
        public int Index
        {
            get
            {
                return this.index;
            }
            set
            {
                this.index = value;
            }
        }
        string country;
        public string Country
        {
            get
            {
                return this.country;
            }
            set
            {
                this.country = value;
            }
        }
        string city;
        public string City
        {
            get
            {
                return this.city;
            }
            set
            {
                this.city = value;
            }
        }
        string street;
        public string Street
        {
            get
            {
                return this.street;
            }
            set
            {
                this.street = value;
            }
        }
        int house;
        public int House
        {
            get
            {
                return this.house;
            }
            set
            {
                this.house = value;
            }
        }
        int apartment;
        public int Apartament
        {
            get
            {
                return this.apartment;
            }
            set
            {
                this.apartment = value;
            }
        }
        public void Print() => Console.WriteLine("Index:\t\t{0}" +
                                               "\nCountry:\t{1}" +
                                                "\nCity:\t\t{2}" +
                                                "\nStreet:\t\t{3}" +
                                                "\nHouse:\t\t{4}" +
                                                "\nApartment:\t{5}\n\n",
            index,country, city, street, house, apartment);

    }
}
