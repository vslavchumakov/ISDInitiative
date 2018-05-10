using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Task_3_wpf
{
    /// <summary>
    /// найденный фаил
    /// </summary>
    public class SearchFile : DependencyObject
    {
        /// <summary>
        /// имя
        /// </summary>
        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Model.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NameProperty =
        DependencyProperty.Register("Name", typeof(string), typeof(SearchFile), new PropertyMetadata("no"));
    }

    /// <summary>
    /// статический класс, содержащий коллекцию корневых каталогов
    /// </summary>
    public class ListFiles
    {
        /// <summary>
        /// коллекция найденных файлов
        /// </summary>
        public ObservableCollection<SearchFile> Files { get; set; } = new ObservableCollection<SearchFile>();

        /// <summary>
        /// добавление файлов в коллекцию
        /// </summary>
        /// <param name="files">коллекция файлов</param>
        public void AddFiles(IEnumerable<string> listFiles)
        {
            foreach (string file in listFiles)
            {
                Files.Add(new SearchFile() { Name = file });
            }
        }

        /// <summary>
        /// метод возвращает коллекцию логических дисков системы
        /// </summary>
        /// <returns>коллекция логических дисков системы</returns>
        public ObservableCollection<SearchFile> GetFiless() => Files;
    }
}
