using System;
namespace Task_2
{
    /// <summary>
    /// Class ExcelentPupil derives from base class Pupil
    /// </summary>
    class ExcelentPupil : Pupil
	{
        /// <summary>
        /// User constructor
        /// </summary>
        /// <param name="name">Name of the pupil</param>
        public ExcelentPupil(string name) : base(name)
        {
        }

        // Override methods from base class Pupil
        public override void Study()
		{
            Console.WriteLine($"{name} studies excellently.");
        }

        public override void Read()
		{
            Console.WriteLine($"{name} reads excellently.");
        }

        public override void Write()
		{
            Console.WriteLine($"{name} writes excellently.");
        }

        public override void Relax()
		{
            Console.WriteLine($"{name} relaxes a little.");
        }
	}
}
