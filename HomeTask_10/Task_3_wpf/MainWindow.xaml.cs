using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task_3_wpf
{
    /// <summary>
    /// Напишите приложение для поиска заданного файла на диске. 
    /// Добавьте код, использующий класс FileStream и позволяющий просматривать файл в текстовом окне.
    /// В заключение добавьте возможность сжатия найденного файла.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// список найденных файлов
        /// </summary>
        ListFiles listFindFiles = new ListFiles();

        /// <summary>
        /// инициализация элементов графического интерфейса
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            //осуществляем привязку данных к кантролу
            listFiles.ItemsSource = listFindFiles.Files;
        }

        /// <summary>
        /// обработка события слика по кнопке Search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_ClickSearch(object sender, RoutedEventArgs e)
        {
            //получаем имя файла с кантрола
            string file = fileName.Text;

            //выбранное расширение файла
            string extension = extensionFile.Text;

            //выбранная директория
            string directory = directoryFile.Text;

            //валидация имени файла
            if (file.IndexOfAny(System.IO.Path.GetInvalidFileNameChars()) != -1 || String.IsNullOrEmpty(file))
            {
                textFromFile.Text = "Enter corrent file name";
                return;
            }

            //выполняем поиск файлов
            IEnumerable<string> files = Searcher.SafeEnumerateFiles(directory, file + "." + extension.ToLower(), SearchOption.AllDirectories);

            //добавляем найденные файлы в кантрол листбокс
            listFindFiles.AddFiles(files);

            ButtonCreate.IsEnabled = (listFiles.HasItems) ? true : false;
        }

        /// <summary>
        /// обработка события клика по кнопке создать архив
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCreate_Click(object sender, RoutedEventArgs e)
        {
            //если выбран какой-либо фаил
            if (listFiles.SelectedIndex > 0)
            {
                //получаем путь к файлу
                SearchFile file = (SearchFile)listFiles.SelectedItem;

                //создаём архив
                string zip = DocumentWorker.CreateArchive(file.Name, fileName.Text, extensionFile.Text);
            }
        }

        /// <summary>
        /// событие изминения выбраного item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListFiles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //получаем выбранный фаил
            SearchFile file = (SearchFile)listFiles.SelectedItem;

            //загружаём в текстбокс содержимое файла
            textFromFile.Text = DocumentWorker.OpenFile(file.Name);
        }
    }
}
