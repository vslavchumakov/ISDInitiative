using System;
namespace Task_1
{
    /// <summary>
    /// Concrete class TXTHandler  inherit from an abstract  class AbstractHandler
    /// </summary>
    class TXTHandler : AbstractHandler
    {
        /// <summary>
        /// Constructor with one parameter
        /// </summary>
        /// <param name="fileName"></param>
        public TXTHandler(string fileName) : base(fileName)
        {
        }

        /// <summary>
        /// Override abstract method Save from abstract class
        /// </summary>
        public override void Save()
        {
            Console.WriteLine(fileName + " saved in TXT-format");
        }
    }
}
