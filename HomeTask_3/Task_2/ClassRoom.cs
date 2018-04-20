using System;
namespace Task_2
{
    /// <summary>
    /// Aggregation relationship between two classes (ClassRoom and Pupil): a classroom has one or more pupils
    /// </summary>
    public class ClassRoom
	{
        // According to the task condition class consists of 4 pupils
        Pupil[] pupils = new Pupil[4];

        Random rnd = new Random();

        /// <summary>
        /// Instance constructor with three arguments
        /// </summary>
        /// <param name="p0"></param>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
		public ClassRoom(Pupil p0, Pupil p1, Pupil p2):this(p0,p1)
        {
            pupils[2] = p2;
        }

        /// <summary>
        /// Instance constructor with two arguments
        /// </summary>
        /// <param name="p0"></param>
        /// <param name="p1"></param>
        public ClassRoom(Pupil p0, Pupil p1)
		{
            pupils[0] = p0;
            pupils[1] = p1;
            pupils[2] = GeneratePupil();
            pupils[3] = GeneratePupil();
        }

        /// <summary>
        /// Method which generates random pupil
        /// </summary>
        /// <returns></returns>
        private Pupil GeneratePupil()
		{
            // Get random number between 1 and 3 with method Next on the instance rnd from class Random
            int rand = rnd.Next(1, 4); 
            switch (rand)
            {
                case 1: return new ExcelentPupil("Jeffrey Richter");
                case 2: return new GoodPupil("Herb Schildt");
                case 3: return new BadPupil("Ivan Ivanov");  
            }
            return null;
        }

        /// <summary>
        /// Show how all pupils of class study
        /// </summary>
        public void Study()
		{
            foreach (Pupil p in pupils)
            {
                p.Study();
            }
		}

        /// <summary>
        /// Show how all pupils of class read
        /// </summary>
		public void Read()
		{
            foreach (Pupil p in pupils)
            {
                p.Read();
            }
        }

        /// <summary>
        /// Show how all pupils of class write
        /// </summary>
		public void Write()
		{
            foreach (Pupil p in pupils)
            {
                p.Write();
            }
        }

        /// <summary>
        /// Show how all pupils of class relax
        /// </summary>
		public void Relax()
		{
            foreach (Pupil p in pupils)
            {
                p.Relax();
            }
        }
	}
}
