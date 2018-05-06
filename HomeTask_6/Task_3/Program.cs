using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    // Создайте класс MyClass и структуру MyStruct, которые содержат в себе поля public string change.
    // В классе Program создайте два метода:
    //  -- static void ClassTaker(MyClass myClass), 
    // который присваивает полю change экземпляра myClass значение «изменено».
    //  -- static void StruktTaker(MyStruct myStruct), 
    // который присваивает полю change экземпляра myStruct значение «изменено».
    // Продемонстрируйте разницу в использовании классов и структур, 
    // создав в методе Main() экземпляры структуры и класса.
    // Измените, значения полей экземпляров на «не изменено», 
    // а затем вызовите методы ClassTaker и StruktTaker.
    // Выведите на экран значения полей экземпляров. Проанализируйте полученные результаты.

    class Program
    {
        /// <summary>
        /// метод который присваивает полю change 
        /// экземпляра myClassInstance значение «изменено».
        /// </summary>
        /// <param name="myClassInstance"></param>
        static void ClassTaker(MyClass myClassInstance)
        {
            //ToDo realize static function
            myClassInstance.change = "изменено";
        }
        /// <summary>
        /// метод который присваивает полю change
        /// экземпляра myStructInstance значение «изменено»
        /// </summary>
        /// <param name="myStructInstance"></param>
        static void StruktTaker(MyStruct myStructInstance)
        {
            //ToDo realize static function
            myStructInstance.change = "изменено";
        }

        static void Main(string[] args)
        {
            // Создаем екземпляр класса
            MyClass testClass = new MyClass();
            // Создаем структуру на куче
            MyStruct testStruct = new MyStruct(); //Создание структуры на куче

          
            testClass.change = "не изменено"; 
            // Вызываем метод ClassTaker и передаем в качестве аргумента ссылку на класс
            ClassTaker(testClass);


            testStruct.change = "не изменено";
            // Вызываем метод StructTaker и передаем в качестве аргумента ссылку на структуру
            StruktTaker(testStruct);

            Console.WriteLine($"Поле change класса - {testClass.change}."); 
            Console.WriteLine($"Поле change структуры - {testStruct.change}.");

            Console.ReadKey();
        }
    }
}
