using System;
using System.Windows.Forms;

namespace TextEditor
{
    public interface IMainForm
    {
        string FilePath { get; }
        string Content { get; set; }
        event EventHandler FileOpenClick;
        event EventHandler FileSaveClick;
        event EventHandler FileArchieveClick;
    }

    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            btnOpenFile.Click += BtnOpenFile_Click;
            btnSaveFile.Click += BtnSaveFile_Click;
            btnArchieveFile.Click += BtnArchieveFile_Click;
        }

        #region Проброс событий
        private void BtnSaveFile_Click(object sender, EventArgs e)
        {
            FileSaveClick?.Invoke(this, EventArgs.Empty);
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            FileOpenClick?.Invoke(this, EventArgs.Empty);
        }

        private void BtnArchieveFile_Click(object sender, EventArgs e)
        {
            FileArchieveClick?.Invoke(this, EventArgs.Empty);
        }
        #endregion

        #region Реализация интерфейса IMainForm
        public string FilePath => txtFilePath.Text;

        public string Content
        {
            get => txtContent.Text;
            set => txtContent.Text = value;
        }

        public event EventHandler FileOpenClick;
        public event EventHandler FileSaveClick;
        public event EventHandler FileArchieveClick;
        public event EventHandler ContentChanged;
        #endregion

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = dlg.FileName;
                FileOpenClick?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
