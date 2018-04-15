using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you bet:");
            int userBet = Int32.Parse(Console.ReadLine());

            Random randomValue = new Random();

            int roll = randomValue.Next(1, 12);

            if (roll >= 1 & roll <= 5)
                Console.WriteLine("You lose! Roll:{0}, Balance:{1}", roll, userBet * 0);
            else if (roll >= 6 & roll <= 8)
                Console.WriteLine("You didn't win anything and didn't lose! Roll:{0}, Balance:{1}", roll, userBet);
            else if (roll >= 9 & roll <= 11)
                Console.WriteLine("You win! Multiply x2! Roll:{0}, Balance:{1}", roll, userBet * 2);
            else
                Console.WriteLine("You win! Multiply x10! Roll:{0},Balance:{1}", roll, userBet * 10);
            Console.ReadKey();
        }
    }
}
