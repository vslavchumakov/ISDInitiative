using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task_3_wpf
{
    /// <summary>
    /// класс поиска файла на диске
    /// </summary>
    public static class Searcher
    {
        /// <summary>
        /// метод проводит рекурсивный поиск файлов по заданому патерну на указанном диске и возвращает коллекцию путей к найденым файлам
        /// </summary>
        /// <param name="path">путь начала поиска</param>
        /// <param name="searchPattern">паттерн поиска файла</param>
        /// <param name="searchOption">опции поиска</param>
        /// <returns>коллекция путей найденных файлов</returns>
        public static IEnumerable<string> SafeEnumerateFiles(string path, string searchPattern, SearchOption searchOption)
        {
            //коллекция папок, по которым проходим
            Stack<string> dirs = new Stack<string>();

            //добавляем в коллекцию коренную директурию поиска
            dirs.Push(path);

            //проходим по всем папкам, пока коллекция не будет пустой
            while (dirs.Count > 0)
            {
                //путь к текущей папке
                string currentDirPath = dirs.Pop();

                if (searchOption == SearchOption.AllDirectories)
                {
                    //получаем папки текущей директории и добавляем их в стэк папок
                    try
                    {
                        string[] subDirs = Directory.GetDirectories(currentDirPath);
                        foreach (string subDirPath in subDirs)
                        {
                            dirs.Push(subDirPath);
                        }
                    }
                    catch (UnauthorizedAccessException)//Исключение, возникающее в случае запрета доступа операционной системой из-за ошибки ввода-вывода или особого типа ошибки безопасности.
                    {
                        continue;
                    }
                    catch (DirectoryNotFoundException)//Исключение, которое создается, когда не удается найти часть файла или каталога.
                    {
                        continue;
                    }
                }

                //получаем файлы текущей папки
                string[] files = null;
                try
                {
                    files = Directory.GetFiles(currentDirPath, searchPattern);
                }
                catch (UnauthorizedAccessException)//Исключение, возникающее в случае запрета доступа операционной системой из-за ошибки ввода-вывода или особого типа ошибки безопасности.

                {
                    continue;
                }
                catch (DirectoryNotFoundException)//Исключение, которое создается, когда не удается найти часть файла или каталога.
                {
                    continue;
                }

                //добавляем файлы, соответствующие поиску в возвращаёммую коллекцию
                foreach (string filePath in files)
                {
                    yield return filePath;
                }
            }
        }
    }
}
