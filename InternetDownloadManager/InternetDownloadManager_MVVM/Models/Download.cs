using InternetDownloadManager.InternetDownloadManager_MVVM.Models.Enums;

namespace InternetDownloadManager.InternetDownloadManager_MVVM.Models
{
    public class Download
    {
        public int ID { get; set; }
        public object  Icon { get; set; }
        public string? Title { get; set; }
        public FormatIcon?  Format{ get; set; }
        public double Size { get; set; }
        public double Value { get; set; }
        public string? TimeLeft { get; set; }
    }
}
