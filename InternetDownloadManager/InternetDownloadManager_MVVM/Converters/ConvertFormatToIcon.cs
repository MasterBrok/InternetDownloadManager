using InternetDownloadManager.InternetDownloadManager_MVVM.Models.Enums;
using System;
using System.Windows;
using System.Windows.Media;

namespace InternetDownloadManager.InternetDownloadManager_MVVM.Converters
{
    public static class ConvertFormatToIcon
    {
        public static PathGeometry Convert(FormatIcon formatIcon)
        {
			try
			{
				return (PathGeometry)Application.Current.FindResource(formatIcon.ToString());
			}
			catch (Exception)
			{
				throw new Exception("Not Found Icon");
			}
        }
    }
}
