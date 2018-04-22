using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    /// <summary>
    /// класс бугалтер
    /// </summary>
    public static class Accauntant
    {
        /// <summary>
        /// метод считает, давать сотруднику премию или нет
        /// </summary>
        /// <param name="worker">сотрудник</param>
        /// <param name="hours">колличество отработанных часов</param>
        /// <returns>true-премия положена false-премия не положена</returns>
        public static bool AskForBonus(Worker worker, int hours) => (int)worker.PositionHours < hours;
    }
}
