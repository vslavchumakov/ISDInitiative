using System;
using TextEditor.BL;
namespace TextEditor
{
    public class MainPresenter
    {
        private readonly IMainForm _view;
        private readonly IFileManager _manager;
        private readonly IMessageService _messageService;

        private string _currentFilePath; // Хранит ссылку на наш открытый файл

        public MainPresenter(IMainForm view, IFileManager manager, IMessageService messageService)
        {
            _view = view;
            _manager = manager;
            _messageService = messageService;

            _view.FileOpenClick += _view_FileOpenClick;
            _view.FileSaveClick += _view_FileSaveClick;
            _view.FileArchieveClick += _view_FileArchieveClick;
        }

        // Archieve
        private void _view_FileArchieveClick(object sender, EventArgs e)
        {
            try
            {
                if (!_manager.CreateArchive(_currentFilePath))
                {
                    _messageService.ShowExclamation("The zipped file already exists!");
                    return;
                }
                _messageService.ShowMessage("File successfully archived!");
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        // Save
        private void _view_FileSaveClick(object sender, EventArgs e)
        {
            try
            {
                _manager.SaveContent(_view.Content, _currentFilePath);
                _messageService.ShowMessage("File successfully saved!");
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        // Open
        private void _view_FileOpenClick(object sender, System.EventArgs e)
        {
            try
            {
                string filePath = _view.FilePath;
                if (!_manager.IsExist(filePath))
                {
                    _messageService.ShowExclamation("Selected file doesn't exist!");
                    return;
                }
                _currentFilePath = filePath;

                _view.Content = _manager.GetContent(filePath);
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }
    }
}
