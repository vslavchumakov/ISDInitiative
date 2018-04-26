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
            Сrossover crossover = new Сrossover("Nissan", 2016, 18.5);
            cars.Add(crossover);

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

            // тест метода Contains
            Console.WriteLine("Contains (Nissan, 2016, 18.5): " + cars.Contains(crossover));

            //проверяем на автомобиль, которого нет в коллекции
            Car kia = new Car("Kia", 2018);
            Console.WriteLine("Contains (Kia, 2018): " + cars.Contains(kia) + "\n");

            //тест Insert
            Console.WriteLine("test Insert (kia)\n");
            cars.Insert(1, kia);
            Console.WriteLine(cars);

            //тест IndexdOf
            Console.WriteLine("test Insert (Lamborhgini): " + cars.IndexOf(racingCar) + "\n");

            //добавляем машины по не корректным индексам
            Console.WriteLine("Invalid index Inserted");
            cars.Insert(-10, new Car());
            cars.Insert(96, new Car());
            //выводим информацию о коллекции
            Console.WriteLine(cars);

            //проверка вставки в середину с перевыделением памяти
            cars.Insert(3, new RacingCar("Toyota", 2015, 265));

            //проверка удаление по индексу
            Console.WriteLine("RemoveAt (index 2):");
            cars.RemoveAt(2);
            //выводим информацию о коллекции
            Console.WriteLine(cars);

            //проверка удаление по индексу
            Console.WriteLine("RemoveAt (index -1):");
            cars.RemoveAt(-1);
            //выводим информацию о коллекции
            Console.WriteLine(cars);

            //проверка удаление по ссылке
            Console.WriteLine("Remove (kia):");
            cars.Remove(kia);
            //выводим информацию о коллекции
            Console.WriteLine(cars);

            //проверка удаление по ссылке
            Console.WriteLine("Remove (Nissan):");
            cars.Remove(crossover);
            //выводим информацию о коллекции
            Console.WriteLine(cars);

            //очищаем коллекцию
            Console.WriteLine("Test Clear");
            cars.Clear();
            //выводим в консоль информацию о коллекции
            Console.WriteLine(cars);

            Console.ReadKey();
        }
    }
}
