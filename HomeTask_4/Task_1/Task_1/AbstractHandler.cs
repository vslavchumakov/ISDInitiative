using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    abstract class AbstractHandler
    {
        /// <summary>
        /// protected field fileName
        /// </summary>
        protected string fileName;


        /// <summary>
        /// Constructor with one parameter
        /// </summary>
        /// <param name="fileName"></param>
        public AbstractHandler(string fileName)
        {
            this.fileName = fileName;
        }

        /// <summary>
        /// Method which opens file
        /// </summary>
        public void Open()
        {
            Console.WriteLine(fileName + " opened");
        }

        /// <summary>
        ///  Method which creates file
        /// </summary>
        public void Create()
        {
            Console.WriteLine(fileName + " created");
        }


        /// <summary>
        ///  Method which changes file
        /// </summary>
        public void Change()
        {
            Console.WriteLine(fileName + " changed");
        }

        /// <summary>
        /// Abstract method  is implicitly a virtual method
        /// </summary>
        public abstract void Save();
    }
}
