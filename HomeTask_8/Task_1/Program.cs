﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    /// <summary>
    /// Создайте класс MyClass<T>, содержащий статический фабричный метод - T FacrotyMethod(), 
    /// который будет порождать экземпляры типа, указанного в качестве параметра типа (указателя места заполнения типом – Т).
    /// </summary>
    class Program
    {
        /// <summary>
        /// тестируемый класс персона
        /// </summary>
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        /// <summary>
        /// тестируемая стуктура поезд
        /// </summary>
        struct Train
        {
            public int Number { get; set; }
            public DateTime Date { get; set; }
        }

        /// <summary>
        /// статический фабричный метод. Возвращает объект заданного типа.
        /// </summary>
        /// <typeparam name="T">объект типа Т</typeparam>
        abstract public class MyClass<T> where T : new()//ограничение указывает, что любой аргумент типа в объявлении
                                               //универсального класса должен иметь открытый конструктор без параметров.
                                               //Чтобы использовать ограничение new, тип не может быть абстрактным.
        {
            public static T FactoryMethod()
            {
                Console.WriteLine("Created object: " + typeof(T));
                return new T();
            }
        }


        static void Main(string[] args)
        {
            //создаём объекты произвольных типов с помощью фабричного метода
            Person person = MyClass<Person>.FactoryMethod();
            Train train = MyClass<Train>.FactoryMethod();
        }
    }
}
