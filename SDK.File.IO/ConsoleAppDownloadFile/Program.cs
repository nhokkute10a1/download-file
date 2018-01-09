using FileDownloader;
using System;
namespace ConsoleAppDownloadFile
{
    class Program
    {
        /*
            Khi rớt mạng chương trình sẽ tự kết nối lại để tải tiếp,
            Lưu ý thư viện FileDownloader là 1 SDK
        */
        static FileDownloader.FileDownloader FileDownlaoder = new FileDownloader.FileDownloader();
        static void Main(string[] args)
        {
            /*==Start-Download==*/
            Uri Src = new Uri("http://dl5.vtcgame.vn:2008/CF_Full_1272.zip");
            var Dest = @"C:\Users\asus\Downloads\TestDownload.zip";
            FileDownlaoder.DownloadProgressChanged += OnDownloadProgressChanged;
            FileDownlaoder.DownloadFileAsync(Src, Dest);
            Console.ReadLine();
        }
        /*==Khi tệp tin hoàn thành==*/
        static void DownloadFileCompleted(object sender, DownloadFileCompletedArgs eventArgs)
        {
            /*
                CompletedState : Succeeded,Canceled,Failed
             */
            if (eventArgs.State == CompletedState.Succeeded)
            {
                //Thông báo hoàn tất
            }
            else if (eventArgs.State == CompletedState.Canceled)
            {
                //Khi bị huỷ bỏ tiến trình
            }
            else
            {
                //Khi tải thất bại
            }
        }
        /*==Hiễn thị tốc độ tải tệp tin==*/
        static void OnDownloadProgressChanged(object sender, DownloadFileProgressChangedArgs args)
        {
            Console.WriteLine("Downloaded {0} of {1} bytes", args.BytesReceived, args.TotalBytesToReceive);
        }
    }
}
