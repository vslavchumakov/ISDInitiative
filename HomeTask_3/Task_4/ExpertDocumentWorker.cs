using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_4
{
    /// <summary>
    /// платная версия программы, доступны все опции
    /// </summary>
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public sealed override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}