using System;

namespace Task_1
{
    public struct Notebook
    {
        private string model;
        private string manufacturer;
        private int price;

        public Notebook(string model, string manufacturer, int price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        public void Info()
        {
            Console.WriteLine("Notebook");
            Console.WriteLine("Model: {0}", model);
            Console.WriteLine("Manufacturer: {0}", manufacturer);
            Console.WriteLine("Price: {0} UAH", price);
            Console.WriteLine("____________________");
        }
    }
}
