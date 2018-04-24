﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    /// <summary>
    /// Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант.
    // Присвойте каждой константе значение, задающее количество часов, которые должен отработать сотрудник за месяц.
    // Создайте класс Accauntant с методом bool AskForBonus(Post worker, int hours),
    //отражающее давать или нет сотруднику премию.Если сотрудник отработал больше положеных часов в месяц, то ему положена премия.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Info(new Worker(PositionHoursEnum.Doctor, "Gregory", "House"), 999);
            Info(new Worker(PositionHoursEnum.LaboratoryAssistant, "Emma", "Smith"), 500);
            Info(new Worker(PositionHoursEnum.Cook, "John", "Watson"), 700);
            Info(new Worker(PositionHoursEnum.Nurse, "Tom", "Li"), 1000);
        }

        /// <summary>
        /// метод выводит информацию о сотруднике
        /// </summary>
        /// <param name="worker1"></param>
        /// <param name="hours"></param>
        private static void Info(Worker worker1, int hours)
        {
            Console.WriteLine(worker1);
            Console.WriteLine("Count hours worked: " + hours);
            Console.WriteLine("Get a bonus: " + Accauntant.AskForBonus(worker1, hours));
            Console.WriteLine("------------------------------\n");
        }
    }
}