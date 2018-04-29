using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace readFiles
{
    /// <summary>
    /// класс для работы с документами
    /// </summary>
    public static class DocumentWorker
    {
        /// <summary>
        /// фильтр по умолчанию
        /// </summary>
        static string _defaultFilter = "All txt files(*txt)|*txt";

        /// <summary>
        /// расширение по умолчанию
        /// </summary>
        static string _defaultExtention = "txt";

        /// <summary>
        /// начальная директория по умолчанию
        /// </summary>
        static string _defaulDirectory = "D:\\";

        /// <summary>
        /// метод сохраняет документ
        /// </summary>
        /// <returns>true- документ сохранён, false- документ не сохранен </returns>
        public static bool SaveDocument(string text)
        {
            SaveFileDialog dialog = new SaveFileDialog//создаём окно сохранить
            {
                Filter = _defaultFilter,//фильтр форматов
                DefaultExt = _defaultExtention,//формат по умолчанию
                InitialDirectory = _defaulDirectory,//начальная директория
                CheckPathExists = false//проверка на наличие фаила отключена
            };

            if (dialog.ShowDialog() == DialogResult.OK)//если пользователь нажал ок
            {
                File.WriteAllText(dialog.FileName, text, Encoding.UTF8);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// метод открывает документ
        /// </summary>
        /// <returns></returns>
        public static string OpenDocument()
        {
            OpenFileDialog dialog = new OpenFileDialog //создаём диалог открытия фаила
            {
                Filter = "All txt files(*txt)|*txt",  //фильтр форматов
                InitialDirectory = "D:\\"   //начальная директория
            };

            if (dialog.ShowDialog() == DialogResult.OK)//если пользователь нажал ок
            {
                return File.ReadAllText(dialog.FileName, Encoding.UTF8);//считываем данные с файла в стороку, заполняем текстбокс
            }
            return string.Empty;
        }
    }
}
