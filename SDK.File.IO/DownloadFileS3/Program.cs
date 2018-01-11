using System;
using Amazon;
using DownloadManager.S3;
using DownloadManager;
using System.IO;
namespace DownloadFileS3
{
    class Program
    {
        static string bucketName = "elasticbeanstalk-us-west-1-833434519629";
        static string keyName = "20172905Bw-server-real-time-app-zplus.zip";
        static string AccessKey = "AKIAIHSNDT557FHGP3YA";
        static string SerectKey = "qQZBMAROOU50S5Mx2t+5Els5nQATvdPdFDaKybiP";
        static string DestPath = @"C:\Users\asus\Downloads\20172905Bw-server-real-time-app-zplus.zip";
        //static IAmazonS3 client;
        static string InputKey = Console.ReadLine();
        /*==Define-MultiThreadedWebDownloader==*/
        static MultiThreadedWebDownloader downloader = null;
        static DateTime lastNotificationTime;
        static void Main(string[] args)
        {
            var Uri = AmazonS3.Instance.GetLink(AccessKey, SerectKey, bucketName, keyName, RegionEndpoint.USWest1);
            Console.WriteLine("====Download-File-From-S3====");
            Console.WriteLine("Uri File {0}", Uri);
            Console.WriteLine();
            Console.WriteLine("====Download-Processing====");
            DownloadFile(Uri);
            Console.ReadLine();
        }

        #region[Event]
        private static void DownloadFile(string Uri)
        {
            /*==Check whether the file exists==*/
            if (File.Exists(DestPath.Trim()))
            {
                File.Delete(DestPath.Trim());
            }
            if (File.Exists(DestPath.Trim() + ".tmp"))
            {
                File.Delete(DestPath.Trim() + ".tmp");
            }
            /*--Set-Link-Download--*/
            downloader = new MultiThreadedWebDownloader(Uri)
            {
                /*--Set-Path-Download--*/
                DownloadPath = DestPath.Trim() + ".tmp"
            };
            /*==Register the events of HttpDownloadClient.==*/
            downloader.DownloadCompleted += DownloadCompleted;
            downloader.DownloadProgressChanged += DownloadProgressChanged;
            downloader.StatusChanged += StatusChanged;
           
            if (InputKey == "S")
            {
                /*--Set-Path-BeginDownload--*/
                downloader.BeginDownload();
            }
            else if (InputKey == "P")
            {
                downloader.Pause();
                Console.ReadLine();
            }
            else
            {
                downloader.Resume();
                Console.ReadLine();
            }
        }
        #endregion

        #region[EventArgs]
        protected static void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // Refresh the summary every second.
            if (DateTime.Now > lastNotificationTime.AddSeconds(1))
            {
                var lbSummary = String.Format(
                     "Received: {0}KB Total: {1}KB Speed: {2}KB/s  Threads: {3}",
                     e.ReceivedSize / 1024,
                     e.TotalSize / 1024,
                     e.DownloadSpeed / 1024,
                     downloader.DownloadThreadsCount);
                //Hiễn thị %
                //prgDownload.Value = (int)(e.ReceivedSize * 100 / e.TotalSize);
                lastNotificationTime = DateTime.Now;
                Console.WriteLine(lbSummary);
            }
        }
        protected static void DownloadCompleted(object sender, DownloadCompletedEventArgs e)
        {
            var lbSummary = string.Empty;
            if (e.Error == null)
            {

                lbSummary = String.Format("Received: {0}KB, Total: {1}KB, Time: {2}:{3}:{4}",
                                 e.DownloadedSize / 1024, e.TotalSize / 1024, e.TotalTime.Hours,
                                 e.TotalTime.Minutes, e.TotalTime.Seconds);

                File.Move(DestPath.Trim() + ".tmp", DestPath.Trim());
            }
            else
            {
                lbSummary = e.Error.Message;
                if (File.Exists(DestPath.Trim() + ".tmp"))
                {
                    File.Delete(DestPath.Trim() + ".tmp");
                }

                if (File.Exists(DestPath.Trim()))
                {
                    File.Delete(DestPath.Trim());
                }
            }
        }
        protected static void StatusChanged(object sender, EventArgs e)
        {
            var lbStatus = string.Empty;
            var lbSummary = string.Empty;
            /*==Refresh the status==*/
            lbStatus = downloader.Status.ToString();
            switch (downloader.Status)
            {
                case DownloadStatus.Waiting:
                    lbStatus = "Checking Server Download";
                    break;
                case DownloadStatus.Canceled:
                    lbStatus = "Cancel Process Download";
                    break;
                case DownloadStatus.Completed:
                    lbStatus = "Complete Download File";
                    break;
                case DownloadStatus.Downloading:
                    lbStatus = "Downloading";
                    break;
                case DownloadStatus.Paused:
                    //Pause
                    //btnCancel.Enabled = true;
                    //btnDownload.Enabled = false;

                    // The "Resume" button.
                    //btnPause.Enabled = true & downloader.IsRangeSupported;
                    //tbPath.Enabled = false;
                    //tbURL.Enabled = false;
                    break;
            }
            Console.WriteLine(lbStatus);
            if (downloader.Status == DownloadStatus.Paused)
            {
                lbSummary=  String.Format("Received: {0}KB, Total: {1}KB, Time: {2}:{3}:{4}",
                   downloader.DownloadedSize / 1024, downloader.TotalSize / 1024,
                   downloader.TotalUsedTime.Hours, downloader.TotalUsedTime.Minutes,
                   downloader.TotalUsedTime.Seconds);
            }
            else
            {
               // btnPause.Text = "Pause";
            }
        }
        #endregion

        //private static void DownloadFileS3()
        //{
        //    using (client = new AmazonS3Client(AccessKey, SerectKey, RegionEndpoint.USWest1))
        //    {
        //        ListObjectsRequest listRequest = new ListObjectsRequest
        //        {
        //            BucketName = bucketName,
        //        };
        //        ListObjectsResponse listResponse;
        //        do
        //        {
        //            // Get a list of objects
        //            listResponse = client.ListObjects(listRequest);
        //            foreach (S3Object obj in listResponse.S3Objects)
        //            {
        //                Console.WriteLine("Object - " + obj.Key);
        //                Console.WriteLine(" Size - " + obj.Size);
        //                Console.WriteLine(" LastModified - " + obj.LastModified);
        //                Console.WriteLine(" Storage class - " + obj.StorageClass);
        //            }

        //            // Set the marker property
        //            listRequest.Marker = listResponse.NextMarker;
        //        } while (listResponse.IsTruncated);
        //    }
        //}
    }
}
