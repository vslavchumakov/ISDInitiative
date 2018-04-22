using System;
namespace Task_2
{
    /// <summary>
    /// Base class
    /// </summary>
    public class Pupil
	{
        /// <summary>
        /// Field name is the name of pupil
        /// </summary>
        protected string name;
        public Pupil(string name)
        {
            this.name = name;
        }

        // Declared virtual so they can be overridden.
        public virtual void Study()
		{
            Console.WriteLine("Study");
        }

        public virtual void Read()
		{
            Console.WriteLine("Read");
        }

        public virtual void Write()
		{
            Console.WriteLine("Write");
        }

        public virtual void Relax()
		{
            Console.WriteLine("Relax");
        }
	}
}
