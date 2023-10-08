using BrokHelper.Helper;
using System;
using System.Windows.Input;

namespace InternetDownloadManager.InternetDownloadManager_MVVM.ViewModels
{
    public partial class IDM
    {


        #region Private ICommmand
        private ICommand _addDownload;
        private ICommand _minmax;
        private ICommand _selectAll;
        private ICommand _deleteDownoad;
        private ICommand _option;
        private ICommand _exit;

        #endregion

        #region Public ICommand
        public ICommand AddDownloadCommand
        {
            get
            {

                Helper.Command.TryFill(ref _addDownload, new BrokHelper.IBase.IBrokCommand(AddDownload_Click, CanAddDownload_Click));
                return _addDownload;
            }
        }

        public ICommand MinMax
        {
            get
            {
                Helper.Command.TryFill(ref _minmax, new BrokHelper.IBase.IBrokCommand(MinMax_Click, CanMinMax_Click));
                return _minmax;
            }
        }


        public ICommand Exit
        {
            get
            {
                Helper.Command.TryFill(ref _exit, new BrokHelper.IBase.IBrokCommand(Exit_Click, CanExit_Click));
                return _exit;
            }
        }


        public ICommand SelectAllCommand
        {
            get
            {
                Helper.Command.TryFill(ref _selectAll, new BrokHelper.IBase.IBrokCommand(SelectAll_Click, CanSelectAll_Click));
                return _selectAll;
            }
        }

        public ICommand DeleteDownloadCommand
        {
            get
            {
                Helper.Command.TryFill(ref _deleteDownoad, new BrokHelper.IBase.IBrokCommand(DeleteDownload_Click, CanDeleteDownload_Click));
                return _deleteDownoad;
            }
        }
        public ICommand OptionMenu
        {
            get
            {
                Helper.Command.TryFill(ref _option, new BrokHelper.IBase.IBrokCommand(Option_Click, CanOption_Click));
                return _option;
            }
        }


        #endregion

    }
}
