using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace WPF
{
    public partial class FrmDownloadForm : Form
    {
        const int BUFFER_SIZE = 1448;
        public FrmDownloadForm()
        {
            InitializeComponent();
            lblDownloadComplete.Visible = false;
        }
        private void FrmDownloadForm_Load(object sender, EventArgs e)
        {
            lblStatusDescr.Text = "";
            lblContentLength.Text = "";
            lblBytesRead.Text = "";
            lblRate.Text = "";
        }
        private void BtnGetFile_Click(object sender, EventArgs e)
        {

        }

        #region[Download-File]
        private void DownloadFile(string RemoteUrl,string Dest)
        {
           
            Uri fileURI = new Uri(txtURI.Text);


        }
        #endregion
    }
}
