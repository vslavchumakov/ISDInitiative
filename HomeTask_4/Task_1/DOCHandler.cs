using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    /// <summary>
    /// Concrete class DOCHandler  inherit from an abstract  class AbstractHandler
    /// </summary>
    class DOCHandler : AbstractHandler
    {
        /// <summary>
        /// Constructor with one parameter
        /// </summary>
        /// <param name="fileName"></param>
        public DOCHandler(string fileName) : base(fileName)
        {
        }

        /// <summary>
        /// Override abstract method Save from abstract class
        /// </summary>
        public override void Save()
        {
            Console.WriteLine(fileName + " saved in DOC-format");
        }
    }
}
