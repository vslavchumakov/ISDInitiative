using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Notebook> notebooks = new List<Notebook>();

            Notebook notebook1 = new Notebook("Predator 15 G9 - 593(NH.Q1ZEU.008) Black", "Acer", 64799);
            notebooks.Add(notebook1);

            Notebook notebook2 = new Notebook("A1707 MacBook Pro TB Retina 15 Space Gray(MPTT2UA / A)", "Apple", 96099);
            notebooks.Add(notebook2);

            Notebook notebook3 = new Notebook("ROG G703VI(G703VI - GB001T) Titanium", "Asus", 128099);
            notebooks.Add(notebook3);

            foreach (var notebook in notebooks)
            {
                notebook.Info();
            }

            Console.ReadKey();
        }
    }
}
