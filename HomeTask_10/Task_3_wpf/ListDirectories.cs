using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_wpf
{
    /// <summary>
    /// корневые каталоги поиска
    /// </summary>
    public class RootDirectory
    {
        /// <summary>
        /// имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="name">имя</param>
        public RootDirectory(string name){Name = name;}
    }

    /// <summary>
    /// статический класс, содержащий коллекцию корневых каталогов
    /// </summary>
    public static class ListDirectories
    {
        /// <summary>
        /// коллекция корневых каталогов
        /// </summary>
        static ObservableCollection<RootDirectory> directories = new ObservableCollection<RootDirectory>();

        /// <summary>
        /// конструктор
        /// </summary>
        static ListDirectories()
        {
            //получаем логические диски системы
            string[] DriveList = Environment.GetLogicalDrives();

            //добавляем диски в каталог
            for (int i = 0; i < DriveList.Length; i++)
            {
                directories.Add(new RootDirectory(DriveList[i]));
            }
        }

        /// <summary>
        /// метод возвращает коллекцию логических дисков системы
        /// </summary>
        /// <returns>коллекция логических дисков системы</returns>
        public static ObservableCollection<RootDirectory> GetDirectories() => directories;
    }
}
