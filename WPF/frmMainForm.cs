using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using FileDownloader.CheckSum;
namespace WPF
{
    public partial class FrmMainForm : Form
    {
        Stopwatch sw = new Stopwatch();//Tính toán tốc độ tải tệp tin
        public FrmMainForm()
        {
            InitializeComponent();
        }
        private void BtnChooseFile_Click(object sender, EventArgs e)
        {
            CheckSumFile();
        }
        private void BtnDownload_Click(object sender, EventArgs e)
        {
            //var RemoteUrl = "http://dl5.vtcgame.vn:2008/CF_Full_1272.zip";
            using (var Dialog = new SaveFileDialog())
            {
                Dialog.Title = "Lưu tệp tin mã hoá";
                Dialog.Filter = "Tệp tin (*.*)|*.*";
                Dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (Dialog.ShowDialog() == DialogResult.OK)
                {
                    DownloadFile(txtUrlDownload.Text, Dialog.FileName);
                }
            }
        }


        #region[Open-File]
        private void CheckSumFile()
        {
            try
            {
                using (var Dialog = new OpenFileDialog())
                {
                    Dialog.Title = "Mở tệp tin mã hoá";
                    Dialog.Filter = "Tệp tin (*.*)|*.*";
                    Dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {
                        txtResult.Text = CheckSum.Instance.CreatedCheckSumMD5(Dialog.FileName);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region[DownloadFile]
        private void DownloadFile(string RemoteUrl,string Dest)
        {
            using (var webClient = new WebClient())
            {
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                var URL = RemoteUrl.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ? new Uri(RemoteUrl) : new Uri("http://" + RemoteUrl);
                sw.Start();
                try
                {
                    webClient.DownloadFileAsync(URL, Dest);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
           /*==Tính toán tốc độ download==*/
            labelSpeed.Text = string.Format("{0} kb/s", (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00"));

           /*==Cập nhật tiến trình tải==*/
            progressBarDownload.Value = e.ProgressPercentage;

           /*==Hiễn thị phần trăm==*/
            labelPerc.Text = e.ProgressPercentage.ToString() + "%";

            /*==Cập nhật tiến trình==*/
            labelDownloaded.Text = string.Format("{0} MB's / {1} MB's",
                (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
                (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));
        }
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            sw.Reset();
            if (e.Cancelled == true)
            {
                MessageBox.Show("Download bị huỷ bỏ");
            }
            else
            {
                MessageBox.Show("Download hoàn thành");
            }
        }
        #endregion
    }
}
