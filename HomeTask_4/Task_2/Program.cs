using System;
namespace Task_2
{

    #region Hometask_04_2
    //
    // Author: Shemet Viktoriya
    //
    // Description: 
    // Create 2 interfaces IPlayable and IRecodable.
    // In each of the interfaces, create 3 methods void Play() / void Pause() / void Stop() 
    // and void Record() / void Pause() / void Stop(), respectively.
    // Create a derived class Player from the basic interfaces IPlayable and IRecodable.
    // Write a program that plays and writes.
    //
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            // Declare a class instance player
            Player player = new Player();

            // Start menu
            Menu.StartMenu(player);

            //Delay
            Console.ReadKey();
        }
    }
}
