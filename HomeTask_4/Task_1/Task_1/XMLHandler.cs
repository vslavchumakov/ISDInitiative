using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    /// <summary>
    /// Concrete class XMLHandler  inherit from an abstract  class AbstractHandler
    /// </summary>
    class XMLHandler : AbstractHandler
    {
        /// <summary>
        /// Constructor with one parameter
        /// </summary>
        /// <param name="fileName"></param>
        public XMLHandler(string fileName): base(fileName)
        {
        }

        /// <summary>
        /// Override abstract method Save from abstract class
        /// </summary>
        public override void Save()
        {
            Console.WriteLine(fileName + " saved in XML-format");
        }
    }
}
