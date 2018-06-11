using System.Text;
namespace TextEditor.BL
{
    public interface IFileManager
    {
        bool IsExist(string filePath);
        string GetContent(string filePath, Encoding encoding);
        string GetContent(string filePath);
        void SaveContent(string content, string filePath, Encoding encoding);
        void SaveContent(string content, string filePath);
        bool CreateArchive(string filePath);
    }
}