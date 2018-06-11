using System.Windows.Forms;
namespace TextEditor
{
    public class MessageService : IMessageService
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ShowExclamation(string exclamation)
        {
            MessageBox.Show(exclamation, "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void ShowError(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}