using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace readFiles
{
    /// <summary>
    /// Задание 2. Создайте файл, запишите в него произвольные данные
    /// и закройте файл. Затем снова откройте этот файл, прочитайте из него данные
    /// и выведете их на консоль.
    /// 
    /// автор: Куликова Ирина
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// подписываемся на событие клика по кнопке открыть фаил
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOpenClick(object sender, RoutedEventArgs e)
        {
            //открываем документ и загружаем данные в текстовую область
            innerDocumentText.Text = DocumentWorker.OpenDocument();
        }

        /// <summary>
        /// подписываемся на событие клика по кнопке сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSaveClick(object sender, RoutedEventArgs e)
        {
            //сохраняем документ и закрываем приложение
            if (DocumentWorker.SaveDocument(innerDocumentText.Text))
            {
                this.Close();
            }
        }

        /// <summary>
        /// подписываемся на событие изминения текста в текстовом канторле
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InnerDocumentText_TextChanged(object sender, TextChangedEventArgs e)
        {
            //если в текстовом поле пусто, кнопка сохранить не активна
            buttonSave.IsEnabled = !String.IsNullOrEmpty(innerDocumentText.Text) ? true : false;
        }
    }
}
