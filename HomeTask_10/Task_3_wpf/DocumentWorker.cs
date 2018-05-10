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
            //создаём папку, копируем в него фаил для архивации, производим архивацию
            if (!Directory.Exists(zipPath))
            {
                //задача создания директории
                Task task1 = Task.Factory.StartNew(() =>
                {
                    Directory.CreateDirectory(zipPath);
                });

                task1.Wait();
                task1.Dispose();

                //задача копирования файла в директорию
                Task task2 = Task.Factory.StartNew(() =>
                {
                    File.Copy(filePath, Path.Combine(zipPath, fileName) + "." + extension.ToLower());
                });

                task2.Wait();
                task2.Dispose();

                try
                {
                    //задача архивирования
                    Task task3 = Task.Factory.StartNew(() =>
                    {
                        ZipFile.CreateFromDirectory(parentDir, zipPath);
                    });


                    task3.Wait();
                    task3.Dispose();
                    return zipPath;
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                return "Archive with same name exists!";
            }
        }
    }
}
