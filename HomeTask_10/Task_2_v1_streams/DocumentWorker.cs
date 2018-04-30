using System.Text;
using System.IO;

namespace Task_2_v1_streams
{
    /// <summary>
    /// класс для работы с документами
    /// </summary>
    public static class DocumentWorker
    {

        /// <summary>
        /// метод сохраняет документ
        /// </summary>
        /// <returns>true- документ сохранён, false- документ не сохранен </returns>
        public static void SaveDocument(string path, string text)
        {
            if (text == null)
            {
                return;
            }

            ///используем файловый поток
            using (Stream textStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                //применяем декоратор потока StreamWriter 
                using (StreamWriter writer = new StreamWriter(textStream))
                {
                    System.Console.WriteLine("File written.");
                    writer.Write(text);
                }
            }
        }

        /// <summary>
        /// метод открывает документ
        /// </summary>
        /// <returns></returns>
        public static string OpenDocument(string path)
        {
            //попытка открыть поток
            try
            {
                //создаём файловый поток
                using (Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    //применяем декоратор потока StreamReader 
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        System.Console.WriteLine("File read out.");
                        return reader.ReadToEnd();
                    }
                }
            }
            catch (System.IO.FileNotFoundException exception)//отлавливаем исключение: фаил не найден
            {
                return exception.Message;
            }
        }
    }
}
