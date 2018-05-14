using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_wpf
{

    /// <summary>
    /// класс для работы с документами
    /// </summary>
    public static class DocumentWorker
    {
        /// <summary>
        /// метод открытия файла
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static string OpenFile(string file)
        {
            //попытка открыть поток
            try
            {
                //создаём файловый поток
                using (Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read))
                {
                    //применяем декоратор потока StreamReader 
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }
            catch (UnauthorizedAccessException exception)//Исключение, возникающее в случае запрета доступа операционной системой из-за ошибки ввода-вывода или особого типа ошибки безопасности.
            {
                return exception.Message;
            }
            catch (DirectoryNotFoundException exception)//Исключение, которое создается, когда не удается найти часть файла или каталога.
            {
                return exception.Message;
            }
            catch (FileNotFoundException exception)//отлавливаем исключение: фаил не найден
            {
                return exception.Message;
            }
        }

        /// <summary>
        /// метод создаёт архив рядом с выбраным файлом
        /// </summary>
        /// <param name="filePath">путь к файлу</param>
        /// <param name="fileName">имя файлв</param>
        /// <returns>путь к архиву</returns>
        internal static string CreateArchive(string filePath, string fileName, string extension)
        {
            string parentDir = Directory.GetParent(filePath).FullName;
            string zip = ".zip";
            string zipPath = Path.Combine(parentDir, fileName) + zip;
            if (!Directory.Exists(zipPath))
            {
                using (ZipArchive archive = ZipFile.Open(zipPath, ZipArchiveMode.Create))
                {
                    archive.CreateEntryFromFile(filePath, fileName, CompressionLevel.Fastest);
                }
                return zipPath;
            }
            else
            {
                return "Archive with same name exists!";
            }
        }
    }
}
