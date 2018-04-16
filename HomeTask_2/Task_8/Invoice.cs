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
        private static int _quantity = 0;//----------не понятно назначение поля

        /// <summary>
        /// артикль
        /// </summary>
        private static string _article = "02459UKR";//------не понятно назначение поля

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
            _quantity++;
            Account = account;
            Customer = customer;
            Provider = provider;
        }

        /// <summary>
        /// метод расчёта стоимости заказа
        /// </summary>
        /// <param name="withNDS">учитывание НДС, true-учитывает ндс false- не учитывает НДС</param>
        /// <returns>стоимость заказа</returns>
        public double Culculation(bool withNDS = true) => (withNDS ? 1.2 : 1) * Account;
    }
}
