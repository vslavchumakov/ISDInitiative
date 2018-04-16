using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    /// <summary>
    /// Задание 8. Требуется:
    // Создать класс Invoice.
    // В теле класса создать три поля int account, string customer, 
    // string provider которые должны быть проинициализированы 
    // один раз(при создании экземпляра данного класса) без возможности их дальнейшего изменения.
    // В теле класса создать два закрытых поля string article, int quantity,
    // Создать метод расчета стоимости заказа с НДС или без НДС.
    // Написать программу, которая выводит на экран сумму оплаты заказанного товара
    // с НДС или без НДС.
    /// </summary>
    class Program
    {
        /// <summary>
        /// метод выводит информацию о заказе
        /// </summary>
        /// <param name="invoice"></param>
        private static void ShowInvoice(Invoice invoice)
        {
            Console.WriteLine("Customer: " + invoice.Customer);
            Console.WriteLine("Provider: " + invoice.Provider);
            Console.WriteLine("Стоимость заказа (без НДС): " + invoice.Culculation(false));
            Console.WriteLine("C учётом НДС: " + invoice.Culculation());
            Console.WriteLine("\n------------------------------");
        }

        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice(1000, "EVA", "Smile");
            ShowInvoice(invoice1);

            Invoice invoice2 = new Invoice(8712, "АТБ", "Gale");
            ShowInvoice(invoice2);
        }
    }
}
