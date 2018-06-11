using System.IO;
using System.IO.Compression;
using System.Text;
namespace TextEditor.BL
{
    public class FileManager : IFileManager
    {
        private readonly Encoding defaultEncoding = Encoding.GetEncoding(1251);

        /// <summary>
        /// Method IsExist determines whether there is a file on the disk or not
        /// </summary>
        /// <param name="filePath">File Path</param>
        /// <returns>true or false</returns>
        public bool IsExist(string filePath)
        {
            return File.Exists(filePath);
        }

        /// <summary>
        /// Method GetText reads the data from the file into the string
        /// </summary>
        /// <param name="filePath">File Path</param>
        /// <param name="encoding">Encoding</param>
        /// <returns>String data</returns>
        public string GetContent(string filePath, Encoding encoding)
        {
            return File.ReadAllText(filePath, encoding);
        }


        /// <summary>
        /// Overloaded method GetText reads the data from the file into the string
        /// </summary>
        /// <param name="filePath">File Path</param>
        /// <returns>String data</returns>
        public string GetContent(string filePath)
        {
            return GetContent(filePath, defaultEncoding);
        }

        /// <summary>
        /// Method SaveContent saves the data into the file
        /// </summary>
        /// <param name="content">Data content</param>
        /// <param name="filePath">File Path</param>
        /// <param name="encoding">Encoding</param>        
        public void SaveContent(string content, string filePath, Encoding encoding)
        {
            File.WriteAllText(filePath, content, encoding);
        }

        /// <summary>
        /// Overloaded method SaveContent saves the data into the file
        /// </summary>
        /// <param name="content">Data content</param>
        /// <param name="filePath">File Path</param>
        public void SaveContent(string content, string filePath)
        {
            SaveContent(content, filePath, defaultEncoding);
        }

        /// <summary>
        /// Method CreateArchive creates an archive next to the selected file
        /// </summary>
        /// <param name="filePath">File Path</param>
        /// <param name="fileName">File Name</param>
        /// <returns></returns>
        public bool CreateArchive(string filePath)
        {
            string fileName = Path.GetFileName(filePath);
            string parentDir = Directory.GetParent(filePath).FullName;
            string zip = ".zip";
            string zipPath = Path.Combine(parentDir, Path.GetFileNameWithoutExtension(fileName)) + zip;
            if (!IsExist(zipPath))
            {
                using (ZipArchive archive = ZipFile.Open(zipPath, ZipArchiveMode.Create))
                {
                    archive.CreateEntryFromFile(filePath, fileName, CompressionLevel.Fastest);
                }
                return true;
            }
            else return false;
        }
    }
}