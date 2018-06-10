using System;
namespace Task_2
{
    /// <summary>
    /// Class GoodPupil derives from base class Pupil
    /// </summary>
    class GoodPupil : Pupil
	{
        /// <summary>
        /// User constructor
        /// </summary>
        /// <param name="name">Name of the pupil</param>
        public GoodPupil(string name):base(name)
        {
        }

        // Override methods from base class Pupil
        public override void Study()
		{
            Console.WriteLine($"{name} studies well.");
        }

        public override void Read()
		{
            Console.WriteLine($"{name} reads well.");
        }

        public override void Write()
		{
            Console.WriteLine($"{name} writes well.");
        }

        public override void Relax()
		{
            Console.WriteLine($"{name} relaxes normally.");
        }
	}
}
