using System;
using System.IO;
using System.Windows.Forms;
using DownloadManager;
namespace WPF
{
    public partial class FrmDownload : Form
    {
        /*==Define-MultiThreadedWebDownloader==*/
        MultiThreadedWebDownloader downloader = null;
        DateTime lastNotificationTime;
        public FrmDownload()
        {
            InitializeComponent();
        }
        private void BtnCheck_Click(object sender, EventArgs e)
        {

        }
        private void BtnDownload_Click(object sender, EventArgs e)
        {
            /*==Check whether the file exists==*/
            if (File.Exists(tbPath.Text.Trim()))
            {
                string message = "Tệp tin này đã tồn tại"
                           + "Bạn có muốn xoá tệp tin này không"
                           + "Nếu bạn không muốn xoá thì vui lòng thay đổi đường dẫn";
                var result = MessageBox.Show(
                    message,
                    "Tệp tin đã tồn tại " + tbPath.Text.Trim(),
                    MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    File.Delete(tbPath.Text.Trim());
                }
                else
                {
                    return;
                }
            }
            if (File.Exists(tbPath.Text.Trim() + ".tmp"))
            {
                File.Delete(tbPath.Text.Trim() + ".tmp");
            }
            /*--Set-Link-Download--*/
            downloader = new MultiThreadedWebDownloader(tbURL.Text)
            {
                /*--Set-Path-Download--*/
                DownloadPath = tbPath.Text.Trim() + ".tmp"
            };
            /*==Register the events of HttpDownloadClient.==*/
            downloader.DownloadCompleted += DownloadCompleted;
            downloader.DownloadProgressChanged += DownloadProgressChanged;
            downloader.StatusChanged += StatusChanged;
            /*--Set-Path-BeginDownload--*/
            downloader.BeginDownload();
        }
        private void BtnPause_Click(object sender, EventArgs e)
        {
            /*--Check Status Puase or Default*/
            if (downloader.Status == DownloadStatus.Paused)
            {
                /*==Resume-Download==*/
                downloader.Resume();
            }
            else if (downloader.Status == DownloadStatus.Downloading)
            {
                /*==Pause-Download==*/
                downloader.Pause();
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            /*==Cancel-Download==*/
            if (downloader != null)
            {
                downloader.Cancel();
            }
        }
        private void FrmDownload_Load(object sender, EventArgs e)
        {

        }

        #region[EventArgs]
        protected void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(
                new EventHandler<DownloadProgressChangedEventArgs>(DownloadProgressChangedHandler),
                sender, e);
        }
        protected void DownloadProgressChangedHandler(object sender, DownloadProgressChangedEventArgs e)
        {
            // Refresh the summary every second.
            if (DateTime.Now > lastNotificationTime.AddSeconds(1))
            {
                lbSummary.Text = String.Format(
                    "Received: {0}KB Total: {1}KB Speed: {2}KB/s  Threads: {3}",
                    e.ReceivedSize / 1024,
                    e.TotalSize / 1024,
                    e.DownloadSpeed / 1024,
                    downloader.DownloadThreadsCount);
                prgDownload.Value = (int)(e.ReceivedSize * 100 / e.TotalSize);
                lastNotificationTime = DateTime.Now;
            }
        }
        protected void DownloadCompleted(object sender, DownloadCompletedEventArgs e)
        {
            this.Invoke(
                new EventHandler<DownloadCompletedEventArgs>(DownloadCompletedHandler),
                sender, e);
        }
        protected void DownloadCompletedHandler(object sender, DownloadCompletedEventArgs e)
        {
            if (e.Error == null)
            {

                lbSummary.Text =
                                String.Format("Received: {0}KB, Total: {1}KB, Time: {2}:{3}:{4}",
                                e.DownloadedSize / 1024, e.TotalSize / 1024, e.TotalTime.Hours,
                                e.TotalTime.Minutes, e.TotalTime.Seconds);

                File.Move(tbPath.Text.Trim() + ".tmp", tbPath.Text.Trim());

                prgDownload.Value = 100;
            }
            else
            {
                lbSummary.Text = e.Error.Message;
                if (File.Exists(tbPath.Text.Trim() + ".tmp"))
                {
                    File.Delete(tbPath.Text.Trim() + ".tmp");
                }

                if (File.Exists(tbPath.Text.Trim()))
                {
                    File.Delete(tbPath.Text.Trim());
                }

                prgDownload.Value = 0;
            }
        }
        protected void StatusChanged(object sender, EventArgs e)
        {
            Invoke(new EventHandler(StatusChangedHanlder), sender, e);
        }
        protected void StatusChangedHanlder(object sender, EventArgs e)
        {
            /*==Refresh the status==*/
            lbStatus.Text = downloader.Status.ToString();
            switch (downloader.Status)
            {
                case DownloadStatus.Waiting:
                    lbStatus.Text = "Đang kiểm tra máy chủ...";
                    break;
                case DownloadStatus.Canceled:
                    lbStatus.Text = "Huỷ bỏ tiến trình";
                    break;
                case DownloadStatus.Completed:
                    lbStatus.Text = "Tải tệp tin hoàn tất";
                    break;
                case DownloadStatus.Downloading:
                    lbStatus.Text = "Đang tải tệp tin";
                    break;
                case DownloadStatus.Paused:
                    //Pause
                    btnCancel.Enabled = true;
                    btnDownload.Enabled = false;

                    // The "Resume" button.
                    btnPause.Enabled = true & downloader.IsRangeSupported;
                    tbPath.Enabled = false;
                    tbURL.Enabled = false;
                    break;
            }

            if (downloader.Status == DownloadStatus.Paused)
            {
                lbSummary.Text =
                   String.Format("Received: {0}KB, Total: {1}KB, Time: {2}:{3}:{4}",
                   downloader.DownloadedSize / 1024, downloader.TotalSize / 1024,
                   downloader.TotalUsedTime.Hours, downloader.TotalUsedTime.Minutes,
                   downloader.TotalUsedTime.Seconds);

                btnPause.Text = "Resume";
            }
            else
            {
                btnPause.Text = "Pause";
            }
        }
        #endregion
    }
}
