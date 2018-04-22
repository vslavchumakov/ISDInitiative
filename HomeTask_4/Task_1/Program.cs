using System;
namespace Task_1
{
    class Program
    {
        #region HomeTask_04_Task_1
        //  Создайте класс AbstractHandler.
        //  В теле класса создать методы void Open(), void Create(), void Chenge(), void Save().
        //  Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler.
        //  Написать программу, которая будет выполнять определение документа и для каждого формата 
        //  должны быть методы открытия, создания, редактирования, сохранения определенного формата документа.
        #endregion

        static void Main(string[] args)
        {
            Editor edt = new Editor();

            Console.WriteLine("First example");
            edt.DefineFormatDocument("my_hometask_4.doc");
            edt.Open();
            edt.Change();
            edt.Save();

            Console.WriteLine(new string('-', 15));

            Console.WriteLine("Second example");
            edt.DefineFormatDocument("noname.xml");
            edt.Create();
            edt.Open();
            edt.Change();
            edt.Save();


            Console.WriteLine(new string('-', 15));

            Console.WriteLine("Third example");
            edt.DefineFormatDocument("my.xxx");


            // Delay.
            Console.ReadKey();
        }
    }
}
