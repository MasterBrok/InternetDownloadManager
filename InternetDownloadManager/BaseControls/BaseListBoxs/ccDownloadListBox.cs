
using System.Windows;
using System.Windows.Controls;

namespace InternetDownloadManager.BaseControls.BaseListBoxs
{
    public class ccDownloadListBox : ListBox
    {
        static ccDownloadListBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ccDownloadListBox), new FrameworkPropertyMetadata(typeof(ccDownloadListBox)));
        }
    }
}
