
using System.Windows;
using System.Windows.Controls;
namespace InternetDownloadManager.BaseControls.BaseCheckBoxs
{
    public class ccDownloadCheckBox : CheckBox
    {
        static ccDownloadCheckBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ccDownloadCheckBox), new FrameworkPropertyMetadata(typeof(ccDownloadCheckBox)));
        }
    }
}
