using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace InternetDownloadManager.BaseControls.BaseButton
{
    public class ccExpenderMenuButton : Button
    {
        static ccExpenderMenuButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ccExpenderMenuButton), new FrameworkPropertyMetadata(typeof(ccExpenderMenuButton)));
        }


        public PathGeometry Icon
        {
            get { return (PathGeometry)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(PathGeometry), typeof(ccExpenderMenuButton), new PropertyMetadata(default));




    }
}
