using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    /// <summary>
    /// Задание 4. Создайте класс DocumentWorker.
    // В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument().
    // В тело каждого из методов добавьте вывод на экран соответствующих строк:
    // -"Документ открыт", 
    // -"Редактирование документа доступно в версии Про",
    // -"Сохранение документа доступно в версии Про".
    // Создайте производный класс ProDocumentWorker.
    // Переопределите соответствующие методы, при переопределении методов выводите следующие строки:
    // -"Документ отредактирован", 
    // -"Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт".
    // Создайте производный класс ExpertDocumentWorker от базового класса ProDocumentWorker.
    // Переопределите соответствующий метод.При вызове данного метода необходимо выводить на экран
    // -"Документ сохранен в новом формате".
    // В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp. 
    // Если пользователь не вводит ключ, он может пользоваться только бесплатной версией (создается экземпляр базового класса), 
    // если пользователь ввел номера ключа доступа pro и exp, то должен создаться экземпляр соответствующей версии класса, 
    // приведенный к базовому - DocumentWorker.
    /// </summary>
    class Program
    {
        /// <summary>
        /// метод создает документ в зависимомти от введенных ключей
        /// </summary>
        /// <param name="pro">ключ к версии pro, введеный пользователем</param>
        /// <param name="expert">ключ к версии expert, введенный пользователем</param>
        /// <returns>экземпляр класса DocumentWorker или его наследника</returns>
        public static DocumentWorker CreateDocumentWorker(string pro, string expert)
        {
            //оригинальный ключ pro
            string _keyPro = "pro";
            //оригинальный ключ expert
            string _keyExpert = "exp";

            if (_keyPro != pro)
            {
                //Console.WriteLine("base");
                return new DocumentWorker();
            }
            else
            {
                if (_keyExpert != expert)
                {
                    //Console.WriteLine("pro");
                    return new ProDocumentWorker();
                }
                else
                {
                    //Console.WriteLine("expert");
                    return new ExpertDocumentWorker();
                }
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("[keys: pro, exp]");
            Console.Write("Введите ключ PRO: ");
            string pro = Console.ReadLine();
            Console.Write("Введите ключ EXPERT: ");
            string expert = Console.ReadLine();
            DocumentWorker document = CreateDocumentWorker(pro, expert);

            Console.WriteLine("open: ");
            document.OpenDocument();

            Console.WriteLine("edit: ");
            document.EditDocument();

            Console.WriteLine("save: ");
            document.SaveDocument();
            Console.ReadKey();
        }
    }
}
