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

        /// <summary>
        /// Method which clear last line on the Console
        /// </summary>
        public static void ClearLastLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

        /// <summary>
        /// Read user input and return number of choice in right case
        /// </summary>
        /// <returns>number between 0 and 2/returns>
        static byte ReadChoice()
        {
            string enter;
            bool isInputRight;
            byte choice;
            Console.WriteLine("");
            do
            {
                ClearLastLine();
                enter = Console.ReadLine();
                isInputRight = byte.TryParse(enter, out choice);
            } while (!isInputRight || choice <0 || choice >2);
            return choice;
        }

        static void Main(string[] args)
        {
            // Declare a class instance player:
            Player player = new Player();
            // First choice of user action
            byte choice;
            Console.WriteLine("1. Play");
            Console.WriteLine("2. Record");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Make your choice:");
            choice = ReadChoice();
            switch (choice)
            {
                
                case 1: // User chooses Play
                    {
                        Console.Clear();
                        player.Play();
                        Console.WriteLine("1. Pause");
                        Console.WriteLine("2. Stop");
                        Console.WriteLine("0. Exit");
                        Console.WriteLine("Make your next choice:");
                        // Second user choice in case Playing
                        byte newchoice = ReadChoice();
                        IPlayable iPlayable = (IPlayable)player;
                        switch (newchoice)
                        {
                            case 1: // User chooses Pause playing
                                iPlayable.Pause();
                                break;
                            case 2: // User chooses Stop playing
                                iPlayable.Stop();
                                break;
                            case 0: // User chooses Exit
                                break;
                        }
                        break;
                    }

                case 2: // User chooses Record
                    {
                        Console.Clear();
                        player.Record();
                        Console.WriteLine("1. Pause");
                        Console.WriteLine("2. Stop");
                        Console.WriteLine("0. Exit");
                        Console.WriteLine("Make your next choice:");
                        // Second user choice in case Recording
                        byte newchoice = ReadChoice();
                        IRecodable iRecodable = (IRecodable)player;
                        switch (newchoice)
                        {
                            case 1: // User chooses Pause recording
                                iRecodable.Pause();
                                break;
                            case 2: // User chooses Stop recording
                                iRecodable.Stop();
                                break;
                            case 0: // User chooses Exit
                                break;
                        }
                        break;
                    }

                case 0: // User chooses Exit
                    break;
            }

            //Delay
            Console.ReadKey();
        }
    }
}
