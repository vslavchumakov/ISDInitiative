using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2_1
{
    /// <summary>
    /// Создать класс с именем Address.
    //В теле класса требуется создать поля: index, country, city, street, house, apartment.Для каждого поля, создать свойство с двумя методами доступа.
    //Создать экземпляр класса Address.
    //В поля экземпляра записать информацию о почтовом адресе.
    //Выведите на экран значения полей, описывающих адрес.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //тестовые экземпляры
            Address address1 = new Address { Index = 49089, Country = "Украина", City = "Днепр", Street = "Кирова", House = "15a", Apartment = "12б" };
            Console.WriteLine(address1);

            Address address2 = new Address { Index = 49018, Country = "Украина", City = "Днепр", Street = "Мониторная", House = "2", Apartment = "" };
            Console.WriteLine(address2);

            Console.ReadKey();
        }
    }
}
