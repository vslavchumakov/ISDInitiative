using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    /// <summary>
    /// счёт
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// кол-во
        /// </summary>
        private static int _quantity;

        /// <summary>
        /// методы доступа с полю quality, то есть свой-ства
        /// </summary>
        public int Quality
        {
            get => _quantity;
            set => _quantity = value;
        }

        /// <summary>
        /// артикль
        /// </summary>
        private static string _article;

        /// <summary>
        /// методы доступа с полю article, то есть свой-ства
        /// </summary>
        public string Article
        {
            get => _article;
            set => _article = value;
        }

        /// <summary>
        /// стоимость
        /// </summary>
        public int Account { get; private set; }

        /// <summary>
        /// заказчик
        /// </summary>
        public string Customer { get; private set; }

        /// <summary>
        /// поставщик
        /// </summary>
        public string Provider { get; private set; }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="account">стоимость</param>
        /// <param name="customer">заказчик</param>
        /// <param name="provider">поставщик</param>
        public Invoice(int account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }

        /// <summary>
        /// метод расчёта стоимости заказа
        /// </summary>
        /// <param name="withNDS">учитывание НДС, true-учитывает ндс false- не учитывает НДС</param>
        /// <returns>стоимость заказа</returns>
        public double Culculation(bool withNDS = true)
        {
            double price = 0;//цена единицы товара
            switch (Article)//свитч стоимости товара по артиклю
            {
                case "ASE1254":
                    price = 12.5;
                    break;
                case "OPE4324":
                    price = 7.75;
                    break;
                case "PLE8745":
                    price = 7.75;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("---error article---");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
            }

            return (withNDS ? 1.2 : 1) * Quality * price;
        }
    }
}
