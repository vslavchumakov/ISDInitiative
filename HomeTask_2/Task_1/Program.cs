using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address { Index = 49000, Country = "Украина", City = "Днепр", Street = "Набережная", House = 121, Apartament = 20 };
            address1.Print();
            Address address2 = new Address { Index = 49018, Country = "Украина", City = "Днепр", Street = "Яворницкого", House = 33, Apartament = 11 };
            address2.Print();
            Console.ReadKey();
        }
    }
}
