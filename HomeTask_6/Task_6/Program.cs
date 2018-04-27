using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
            Info(new Worker(PositionHours.Doctor, "Gregory", "House"), 999);
            Info(new Worker(PositionHours.LaboratoryAssistant, "Emma", "Smith"), 500);
            Info(new Worker(PositionHours.Cook, "John", "Watson"), 700);
            Info(new Worker(PositionHours.Nurse, "Tom", "Li"), 1000);
            Thread.Sleep(4000);
        }

        /// <summary>
        /// метод выводит информацию о сотруднике
        /// </summary>
        /// <param name="worker"></param>
        /// <param name="hours"></param>
        private static void Info(Worker worker, int hours)
        {
            Console.WriteLine(worker);
            Console.WriteLine("Count hours worked: " + hours);
            Console.WriteLine("Get a bonus: " + Accauntant.AskForBonus(worker, hours));
            Console.WriteLine("------------------------------\n");
        }
        
    }
}
