using System;
namespace Task_2
{
    /// <summary>
    /// Class BadPupil derives from base class Pupil
    /// </summary>
    class BadPupil : Pupil
	{
        /// <summary>
        /// User constructor
        /// </summary>
        /// <param name="name">Name of the pupil</param>
        public BadPupil(string name)
        {
            this.name = name;
        }
        
        // Override methods from base class Pupil
        public override void Study()
		{
            Console.WriteLine($"{name} studies badly.");
		}

        public override void Read()
		{
            Console.WriteLine($"{name} reads badly.");
        }

        public override void Write()
		{
            Console.WriteLine($"{name} writes badly.");
        }

        public override void Relax()
		{
            Console.WriteLine($"{name} relaxes a lot.");
        }
	}
}
