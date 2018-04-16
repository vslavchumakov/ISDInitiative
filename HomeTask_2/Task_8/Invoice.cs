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
        private int quantity = 10; //откуда его брать?

        /// <summary>
        /// артикль
        /// </summary>
        private static string article = "02459UKR";

        /// <summary>
        /// стоимость
        /// </summary>
        //public readonly int account;
        public int Account { get;}

        /// <summary>
        /// заказчик
        /// </summary>
        //public readonly string customer;
        public string Customer { get;}

        /// <summary>
        /// поставщик
        /// </summary>
        //public readonly string provider;
        public string Provider { get; }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="account">стоимость</param>
        /// <param name="customer">заказчик</param>
        /// <param name="provider">поставщик</param>
        public Invoice(int account, string customer, string provider)
        {
            this.Account = account;
            this.Customer = customer;
            this.Provider = provider;
        }

        /// <summary>
        /// метод расчёта стоимости заказа
        /// </summary>
        /// <param name="withNDS">учитывание НДС, true-учитывает ндс false- не учитывает НДС</param>
        /// <returns>стоимость заказа</returns>
        public double Culculation(bool withNDS = true) => (withNDS ? 1.2 : 1) * Account * quantity;
    }
}
