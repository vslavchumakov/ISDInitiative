using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_v1_streams
{
    /// <summary>
    /// Stream, FileStream, StreamWriter, StreamReader
    /// 
    /// Задание 2. Создайте файл, запишите в него произвольные данные
    /// и закройте файл. Затем снова откройте этот файл, прочитайте из него данные
    /// и выведете их на консоль.
    /// 
    /// автор: Куликова Ирина
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //тестируемый текст
            string text = $"Lorem - ipsum morbi nulla risus tempus orci lorem arcu in nulla duis," +
                             " sit ipsum sed curabitur ultricies. Pharetra curabitur nulla ornare sed lectus" +
                             " fusce in eget odio ornare. Vulputate, odio: ipsum - quisque sodales ultricies duis commodo nibh auctor at donec tellus risus duis, ornare et malesuada," +
                             " tempus eros in, porttitor. Malesuada donec: ut odio commodo, sapien sagittis proin sapien, eros morbi orci elementum vitae tellus at magna enim donec cursus." +
                             " Adipiscing risus auctor nam quisque maecenas duis sapien pellentesque ligula lectus enim duis eros gravida maecenas in commodo porta risus rutrum." +
                             " Eros nec sodales, pharetra ipsum leo maecenas sit porttitor congue, vitae porttitor urna lorem curabitur lectus morbi ligula non ligula. " +
                             "Fusce maecenas lectus non mattis nam odio malesuada magna nibh, pellentesque quisque risus morbi justo, at nec tellus, eros diam elementum" +
                             " ornare lectus quam in. Quam leo et, eros sem bibendum justo elementum pharetra mauris, auctor eget non cursus metus sed nulla nec," +
                             " vitae, gravida et ut nam justo.";

            //путь к файлу
            string path = "doument.txt";

            //сохраняем данные в фаил
            DocumentWorker.SaveDocument(path, text);

            //считываем данные с файла
            Console.WriteLine(DocumentWorker.OpenDocument(path));
        }
    }
}
