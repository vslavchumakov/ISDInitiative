using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    // Declare the Player class that implements the two interfaces:
    // IPlayable and IRecodable:
    class Player : IPlayable, IRecodable
    {
  
        public void Play()
        {
            Console.WriteLine("Playing.");
        }

        public void Record()
        {
            Console.WriteLine("Recording.");
        }


        // Implement interface IPlayable explicity
        void IPlayable.Pause()
        {
            Console.WriteLine("Pause playing.");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Stop playing.");
        }


        // Implement interface IRecodable explicity
        void IRecodable.Pause()
        {
            Console.WriteLine("Pause recording.");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Stop recording.");
        }
    }
}
