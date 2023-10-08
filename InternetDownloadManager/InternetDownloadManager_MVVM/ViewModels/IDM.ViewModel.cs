using BrokHelperCustomControlLibrary.Controls.ListBoxs;
using InternetDownloadManager.BaseControls.BaseListBoxs;
using InternetDownloadManager.InternetDownloadManager_MVVM.Converters;
using InternetDownloadManager.InternetDownloadManager_MVVM.Models;
using InternetDownloadManager.Windows;
using System;
using System.CodeDom;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace InternetDownloadManager.InternetDownloadManager_MVVM.ViewModels
{
    public partial class IDM : BrokHelper.Helper.Helper.Notify
    {
        public IDM()
        {
            this.ReadOnlyDownloads = new()
            {
                new Download()
                {
                    ID = 234,
                    Format = Models.Enums.FormatIcon.Viedo,
                    Size = 2345,
                    Title = "Memory",
                    Value = new Random().Next(0,100),
                    TimeLeft = "00:20:00",
                    Icon =ConvertFormatToIcon.Convert(Models.Enums.FormatIcon.Viedo)
                },
                new Download()
                {
                    ID = 23,
                    Format = Models.Enums.FormatIcon.Zip,
                    Size = 100,
                    Title = "Visual Studio 2022",
                    Value = new Random().Next(0,100),
                    TimeLeft = "01:10:00",
                    Icon =ConvertFormatToIcon.Convert(Models.Enums.FormatIcon.Zip)
                },

                new Download()
                {
                    ID = 98,
                    Format = Models.Enums.FormatIcon.APK,
                    Size = 405,
                    Title = "FarLight85",
                    Value = new Random().Next(0,100),
                    TimeLeft = "00:30:00",
                    Icon=ConvertFormatToIcon.Convert(Models.Enums.FormatIcon.APK)
                },

            };
            this.Downloads = new(ReadOnlyDownloads);
        }

        #region Private Property
        private object _selectRow;
        private string _search;
        private object controlListBox;
        private bool _isEnableDelte = false;
        private ObservableCollection<Download> _readOnlyDownloads;
        #endregion
        #region Public Property
        public ObservableCollection<Download> ReadOnlyDownloads
        {
            get { return _readOnlyDownloads; }
            set
            {
                _readOnlyDownloads = value;
                base.BrokNotify();
            }
        }



        private ObservableCollection<Download> _downloads;

        public ObservableCollection<Download> Downloads
        {
            get { return _downloads; }
            set
            {
                _downloads = value;
                base.BrokNotify();
            }
        }

        public object SelectRow
        {
            get { return _selectRow; }
            set
            {
                _selectRow = value;
                base.BrokNotify();
                SelectRow_Click(value);
            }
        }
        public bool IsDelete
        {
            get { return _isEnableDelte; }
            set
            {
                _isEnableDelte = value;
                base.BrokNotify();
            }
        }
        public object ControlListBox
        {
            get { return controlListBox; }
            set { controlListBox = value; }
        }

        public string Search
        {
            set
            {
                _search = value;
                Search_TextChange(value);
                base.BrokNotify();
            }
        }

        #endregion
        #region Function IConmmand
        private bool CanSelectAll_Click(object obj)
        {
            return true;
        }
        private bool CanAddDownload_Click(object obj)
        {
            return true;
        }
        private bool CanDeleteDownload_Click(object obj)
        {
            return true;
        }
        private bool CanMinMax_Click(object obj)
        {
            return true;
        }
        private bool CanExit_Click(object obj)
        {
            return true;
        }

        private bool CanOption_Click(object obj)
        {
            return true;
        }
        /// <summary>
        /// Obj  == ListBox
        /// </summary>
        /// <param name="obj">Sender == ListBox</param>

        private void MinMax_Click(object obj)
        {
            if (obj is wIDM window)
                window.WindowState = WindowState.Minimized;
        }

       
        private void Exit_Click(object obj)
        {
            Environment.Exit(0);
        }

        private void SelectAll_Click(object obj)
        {

        }

        /// <summary>
        /// This Function For (Resume , Stop , StopAll , Option)
        /// </summary>
        /// <param name="obj"></param>
        private void Option_Click(object obj)
        {
            if (obj is string option)
            {
                if (option.Contains("Resume"))
                {
                    // Function Resume
                }
                else if (option.Contains("Stop"))
                {
                    // Function Stop
                }
                else if (option.Contains("StopAll"))
                {
                    // Function StropAll
                }
                else if (option.Contains("Options"))
                {
                    // Function Oprtion
                }
            }
        }


        private void AddDownload_Click(object obj)
        {
            this.ReadOnlyDownloads.Add(new Download()
            {
                ID = new Random().Next(0, 100),
                Title = "Epica",
                Format = Models.Enums.FormatIcon.Music,
                Icon = ConvertFormatToIcon.Convert(Models.Enums.FormatIcon.Music),
                // Size File
                Size = 20,
                TimeLeft = "00:20:00",
                // Value  ProgressBar
                Value = new Random().Next(0, 101)
            });
            this.Downloads = this.ReadOnlyDownloads;
        }


        /// <summary>
        /// Click Button Delete
        /// </summary>
        /// <param name="obj"></param>
        private void DeleteDownload_Click(object obj)
        {
            if (SelectRow is not null)
                ReadOnlyDownloads.Remove(Downloads.First(e => e.ID == (SelectRow as Download)?.ID));
            else
                IsDelete = false;

            this.Downloads = this.ReadOnlyDownloads;

        }

        #endregion
        #region Function

        /// <summary>
        /// obj == Models.Download
        /// </summary>
        /// <param name="obj"></param>
        private void SelectRow_Click(object obj)
        {
            IsDelete = true;

        }



        private void Search_TextChange(string download)
        {
            try
            {
                if (this.Downloads is not null && !string.IsNullOrEmpty(download))
                {
                    this.Downloads = new ObservableCollection<Download>(this.ReadOnlyDownloads.Where(se => se.Title.StartsWith(download)).ToList());
                }
                else
                    this.Downloads = this.ReadOnlyDownloads;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion
    }
}
