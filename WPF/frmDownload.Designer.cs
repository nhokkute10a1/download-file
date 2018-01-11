namespace WPF
{
    partial class FrmDownload
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPause = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.lbSummary = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbPath = new System.Windows.Forms.Label();
            this.lbUrl = new System.Windows.Forms.Label();
            this.prgDownload = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(530, 64);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 15;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(615, 64);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(442, 64);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(82, 23);
            this.btnDownload.TabIndex = 14;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(68, 38);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(622, 25);
            this.tbPath.TabIndex = 11;
            this.tbPath.Text = "C:\\Users\\asus\\Downloads\\20172905Bw-server-real-time-app-zplus.zip";
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(67, 12);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(623, 25);
            this.tbURL.TabIndex = 12;
            this.tbURL.Text = "https://s3-us-west-1.amazonaws.com/elasticbeanstalk-us-west-1-833434519629/201729" +
    "05Bw-server-real-time-app-zplus.zip";
            // 
            // lbSummary
            // 
            this.lbSummary.AutoSize = true;
            this.lbSummary.Location = new System.Drawing.Point(4, 89);
            this.lbSummary.Name = "lbSummary";
            this.lbSummary.Size = new System.Drawing.Size(74, 17);
            this.lbSummary.TabIndex = 7;
            this.lbSummary.Text = "lbSummary";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(4, 119);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(54, 17);
            this.lbStatus.TabIndex = 8;
            this.lbStatus.Text = "lbStatus";
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(4, 42);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(72, 17);
            this.lbPath.TabIndex = 9;
            this.lbPath.Text = "Local Path";
            // 
            // lbUrl
            // 
            this.lbUrl.AutoSize = true;
            this.lbUrl.Location = new System.Drawing.Point(4, 16);
            this.lbUrl.Name = "lbUrl";
            this.lbUrl.Size = new System.Drawing.Size(38, 17);
            this.lbUrl.TabIndex = 10;
            this.lbUrl.Text = "URL";
            // 
            // prgDownload
            // 
            this.prgDownload.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prgDownload.Location = new System.Drawing.Point(0, 140);
            this.prgDownload.Name = "prgDownload";
            this.prgDownload.Size = new System.Drawing.Size(710, 16);
            this.prgDownload.TabIndex = 6;
            // 
            // FrmDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 156);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.lbSummary);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.lbUrl);
            this.Controls.Add(this.prgDownload);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmDownload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download Manager";
            this.Load += new System.EventHandler(this.FrmDownload_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Label lbSummary;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Label lbUrl;
        private System.Windows.Forms.ProgressBar prgDownload;
    }
}