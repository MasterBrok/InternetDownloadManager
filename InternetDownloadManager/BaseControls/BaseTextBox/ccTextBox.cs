
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace InternetDownloadManager.BaseControls.BaseTextBox
{
    public class ccTextBox : TextBox
    {
        static ccTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ccTextBox), new FrameworkPropertyMetadata(typeof(ccTextBox)));
        }




        public object TargetSender
        {
            get { return (object)GetValue(TargetSenderProperty); }
            set { SetValue(TargetSenderProperty, value); }
        }

        public static readonly DependencyProperty TargetSenderProperty =
            DependencyProperty.Register("TargetSender", typeof(object), typeof(ccTextBox), new PropertyMetadata(default));


        public PathGeometry IconLeft
        {
            get { return (PathGeometry)GetValue(IconLeftProperty); }
            set { SetValue(IconLeftProperty, value); }
        }

        public static readonly DependencyProperty IconLeftProperty =
            DependencyProperty.Register("IconLeft", typeof(PathGeometry), typeof(ccTextBox), new PropertyMetadata(default));




        public PathGeometry IconRight
        {
            get { return (PathGeometry)GetValue(IconRightProperty); }
            set { SetValue(IconRightProperty, value); }
        }

        public static readonly DependencyProperty IconRightProperty =
            DependencyProperty.Register("IconRight", typeof(PathGeometry), typeof(ccTextBox), new PropertyMetadata(default));




    }
}
