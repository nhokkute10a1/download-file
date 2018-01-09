using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FileDownloader;
namespace WPF
{
    public partial class FrmDownloadManager : Form
    {
        private readonly static IFileDownloader _Filedownload = 
            new FileDownloader.FileDownloader();
        public FrmDownloadManager()
        {
            InitializeComponent();
            ResetLable();
        }
        private void BtnDir_Click(object sender, EventArgs e)
        {
            ChooseDir();
        }
        private void BtnDownload_Click(object sender, EventArgs e)
        {
            DownloadFile();
        }
        private void BtnStop_Click(object sender, EventArgs e)
        {
            //var Src = new Uri(txtRemoteUrl.Text);
            //var Dest = txtDir.Text;
            //_Filedownload.DownloadFileAsync(Src, Dest);
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            _Filedownload.CancelDownloadAsync();
        }
        private void FrmDownloadManager_Load(object sender, EventArgs e)
        {

        }

        #region[Event]
        protected void DownloadFileCompleted(object sender, DownloadFileCompletedArgs eventArgs)
        {
            /*
                CompletedState : Succeeded,Canceled,Failed
             */
            if (eventArgs.State == CompletedState.Succeeded)
            {
                lbPercent.Text = "Hoàn tất";
            }
            else if (eventArgs.State == CompletedState.Canceled)
            {
                lbPercent.Text = "0%";
            }
            else
            {
                MessageBox.Show("Tải tệp tin thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected void OnDownloadProgressChanged(object sender, DownloadFileProgressChangedArgs args)
        {
            lbPercent.Text = args.ProgressPercentage.ToString() + "%";
            lbBytesReceived.Text = string.Format("{0:0,00} bytes", args.BytesReceived);
            lbTotalBytesToReceive.Text = string.Format("{0:0,00} Total bytes", args.TotalBytesToReceive);
        }
        #endregion

        #region[Method]
        protected void DownloadCacheImplementation()
        {

        }
        protected void DownloadFile()
        {
            /*==Start-Download==*/
            if (string.IsNullOrEmpty(txtRemoteUrl.Text))
            {
                MessageBox.Show("Vui lòng điền vào đường dẫn tải tệp tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrEmpty(txtDir.Text))
            {
                MessageBox.Show("Chọn đường dẫn lưu tệp tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var Src = new Uri(txtRemoteUrl.Text);
                var Dest = txtDir.Text;
                _Filedownload.DownloadProgressChanged += OnDownloadProgressChanged;
                _Filedownload.DownloadFileCompleted += DownloadFileCompleted;
                _Filedownload.DownloadFileAsync(Src, Dest);
            }
        }
        private void ChooseDir()
        {
            using (var DiaLog = new SaveFileDialog())
            {
                DiaLog.Title = "Lưu tệp tin";
                DiaLog.Filter = "Tệp tin (*.*)|*.*";
                DiaLog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (DiaLog.ShowDialog() == DialogResult.OK)
                {
                    txtDir.Text = DiaLog.FileName;
                }
            }
        }
        private void ResetLable()
        {
            lbBytesReceived.Text = "bytes";
            lbTotalBytesToReceive.Text = "MB";
            lbPercent.Text = "0%";
        }
        #endregion
    }
}
