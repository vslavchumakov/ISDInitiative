using System;
namespace Task_2
{
    /// <summary>
    /// Menu Class
    /// </summary>
    class Menu
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
            } while (!isInputRight || choice < (byte)FirstMenuItem.Exit || choice > (byte)FirstMenuItem.Record);
            return choice;
        }


        public static void StartMenu(Player player)
        {
            do
            {
                Console.Clear();
                // First choice of user action
                byte firstChoice;
                Console.WriteLine((byte)FirstMenuItem.Play + ". Play");
                Console.WriteLine((byte)FirstMenuItem.Record + ". Record");
                Console.WriteLine((byte)FirstMenuItem.Exit + ". Exit");
                Console.WriteLine("Make your choice:");
                firstChoice = ReadChoice();
                Console.Clear();
                switch ((FirstMenuItem)firstChoice)
                {
                    case FirstMenuItem.Play: // User chooses Play
                        player.Play();
                        break;
                    case FirstMenuItem.Record: // User chooses Record
                        player.Record();
                        break;
                    case FirstMenuItem.Exit: // User chooses Exit
                        Environment.Exit(0);
                        break;
                    default: // User makes wrong choice 
                        break;
                }

                Console.WriteLine((byte)SecondMenuItem.Pause + ". Pause");
                Console.WriteLine((byte)SecondMenuItem.Stop + ". Stop");
                Console.WriteLine((byte)SecondMenuItem.Exit + ". Exit");
                Console.WriteLine("Make your choice:");

                // Second user choice in case Playing
                byte secondChoice = ReadChoice();

                switch ((SecondMenuItem)secondChoice)
                {
                    case SecondMenuItem.Pause: // User chooses Pause
                        {
                            if((FirstMenuItem)firstChoice== FirstMenuItem.Play) // Playing
                            {
                                IPlayable iPlayable = player;
                                iPlayable.Pause();
                            }
                            else // Recording
                            {
                                IRecodable iRecodable = player;  
                                iRecodable.Pause();
                            }
                            break;
                        }
                    case SecondMenuItem.Stop: // User chooses Stop
                        {
                            if ((FirstMenuItem)firstChoice == FirstMenuItem.Play) // Playing
                            {
                                IPlayable iPlayable = player;
                                iPlayable.Stop();
                            }
                            else
                            {
                                IRecodable iRecodable = player;  // Recording
                                iRecodable.Stop();
                            }
                            break;
                        }
                    case SecondMenuItem.Exit: // User chooses Exit
                        Environment.Exit(0);
                        break;
                    default: // User makes wrong choice 
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (true);
        }
    }
}
