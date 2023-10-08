using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace InternetDownloadManager.BaseControls.BaseButton
{
    public class ccToggleButtonExpender : ToggleButton
    {
        static ccToggleButtonExpender()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ccToggleButtonExpender), new FrameworkPropertyMetadata(typeof(ccToggleButtonExpender)));
        }




        public PathGeometry Icon
        {
            get { return (PathGeometry)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(PathGeometry), typeof(ccToggleButtonExpender), new PropertyMetadata(default));



        public object TextToggle
        {
            get { return (object)GetValue(TextToggleProperty); }
            set { SetValue(TextToggleProperty, value); }
        }

        public static readonly DependencyProperty TextToggleProperty =
            DependencyProperty.Register("TextToggle", typeof(object), typeof(ccToggleButtonExpender), new PropertyMetadata(default));


    }
}
