using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    /// <summary>
    /// Создайте класс CarCollection<T>. Реализуйте в простейшем приближении
    /// возможность использования его экземпляра для создания парка машин.
    /// Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления машин
    /// с названием машины и года ее выпуска, индексатор для получения значения элемента
    /// по указанному индексу и свойство только для чтения для получения общего количества элементов.
    /// Создайте метод удаления всех машин автопарка.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //создаём коллекцию машин
            CarCollection<Car> cars = new CarCollection<Car>();

            //создаём экземпляр класса Сrossover, производного от Car
            Сrossover сrossover = new Сrossover("Nissan", 2016, 18.5);
            cars.Add(сrossover);

            //создаём экземпляр класса RacingCar, производного от Car
            RacingCar racingCar = new RacingCar("Lamborghini 350GT", 1967, 254);
            cars.Add(racingCar);
            
            //выводим в консоль информацию о коллекции
            Console.WriteLine(cars);

            //добавляем в коллекцию 1 автомобиль базового класса Car для тестирования перевыделения памяти
            cars.Add("Audi TT", 2013);
            
            //выводим в консоль информацию о коллекции
            //перебор элементов массива в цикле по индексу
            Console.WriteLine("index");
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine(cars[i]);
            }
            Console.WriteLine("\n");

            //очищаем коллекцию
            cars.Clear();

            //выводим в консоль информацию о коллекции
            Console.WriteLine(cars);
            Console.ReadKey();
        }
    }
}
