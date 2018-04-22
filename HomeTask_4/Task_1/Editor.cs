using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    /// <summary>
    /// Class Editor allows to work with documents
    /// </summary>
    class Editor
    {
        AbstractHandler handler;

        internal AbstractHandler AbstractHandler
        {
            get => default(AbstractHandler);
            set
            {
            }
        }

        /// <summary>
        /// Open document
        /// </summary>
        public void Open()
        {
            handler.Open();
        }

        /// <summary>
        /// Create document
        /// </summary>
        public void Create()
        {
            handler.Create();
        }

        /// <summary>
        /// Change document
        /// </summary>
        public void Change()
        {
            handler.Change();
        }

        /// <summary>
        /// Save document
        /// </summary>
        public void Save()
        {
            handler.Save();
        }


        /// <summary>
        /// Method which defines format of document, by extension
        /// </summary>
        /// <param name="fileName"></param>
        public void DefineFormatDocument(string fileName)
        {
            string formatDocument = fileName.Substring(fileName.Length - 4);

            switch (formatDocument.ToUpper())
            {
                case ".DOC":
                    handler = new DOCHandler(fileName);
                    break;
                case ".XML":
                    handler = new XMLHandler(fileName);
                    break;
                case ".TXT":
                    handler = new TXTHandler(fileName);
                    break;
                default:
                    Console.WriteLine("Unable to recognize the format!");
                    handler = null;
                    break;
            }
        }
    }
}
