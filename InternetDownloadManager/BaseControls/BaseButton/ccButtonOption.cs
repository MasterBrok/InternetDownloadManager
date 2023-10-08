using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace InternetDownloadManager.BaseControls.BaseButton
{
    public class ccButtonOption : Button
    {
        static ccButtonOption()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ccButtonOption), new FrameworkPropertyMetadata(typeof(ccButtonOption)));
        }


        public PathGeometry Icon
        {
            get { return (PathGeometry)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(PathGeometry), typeof(ccButtonOption), new PropertyMetadata(default));


    }
}
