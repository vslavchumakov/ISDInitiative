using System;
using System.Windows.Forms;
using TextEditor.BL;

namespace TextEditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm form = new MainForm();
            FileManager manager = new FileManager();
            MessageService service = new MessageService();

            MainPresenter presenter = new MainPresenter(form, manager, service);

            Application.Run(form);
        }
    }
}
