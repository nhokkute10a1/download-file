namespace WPF
{
    partial class FrmDownloadManager
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lbTotalBytesToReceive = new System.Windows.Forms.Label();
            this.lbPercent = new System.Windows.Forms.Label();
            this.lbBytesReceived = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtRemoteUrl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDir);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnDownload);
            this.groupBox1.Controls.Add(this.lbTotalBytesToReceive);
            this.groupBox1.Controls.Add(this.lbPercent);
            this.groupBox1.Controls.Add(this.lbBytesReceived);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDir);
            this.groupBox1.Controls.Add(this.txtRemoteUrl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Download Manager";
            // 
            // btnDir
            // 
            this.btnDir.Location = new System.Drawing.Point(480, 65);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(28, 27);
            this.btnDir.TabIndex = 5;
            this.btnDir.Text = "...";
            this.btnDir.UseVisualStyleBackColor = true;
            this.btnDir.Click += new System.EventHandler(this.BtnDir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tiến trình";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(421, 183);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 36);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Huỷ bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(328, 183);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(87, 36);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "&Dừng lại";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(235, 183);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(87, 36);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "&Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // lbTotalBytesToReceive
            // 
            this.lbTotalBytesToReceive.AutoSize = true;
            this.lbTotalBytesToReceive.Location = new System.Drawing.Point(90, 157);
            this.lbTotalBytesToReceive.Name = "lbTotalBytesToReceive";
            this.lbTotalBytesToReceive.Size = new System.Drawing.Size(15, 17);
            this.lbTotalBytesToReceive.TabIndex = 2;
            this.lbTotalBytesToReceive.Text = "0";
            // 
            // lbPercent
            // 
            this.lbPercent.AutoSize = true;
            this.lbPercent.Location = new System.Drawing.Point(90, 96);
            this.lbPercent.Name = "lbPercent";
            this.lbPercent.Size = new System.Drawing.Size(28, 17);
            this.lbPercent.TabIndex = 2;
            this.lbPercent.Text = "0%";
            // 
            // lbBytesReceived
            // 
            this.lbBytesReceived.AutoSize = true;
            this.lbBytesReceived.Location = new System.Drawing.Point(90, 126);
            this.lbBytesReceived.Name = "lbBytesReceived";
            this.lbBytesReceived.Size = new System.Drawing.Size(15, 17);
            this.lbBytesReceived.TabIndex = 2;
            this.lbBytesReceived.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dung lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tốc độ tải";
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(93, 65);
            this.txtDir.Name = "txtDir";
            this.txtDir.ReadOnly = true;
            this.txtDir.Size = new System.Drawing.Size(380, 25);
            this.txtDir.TabIndex = 1;
            // 
            // txtRemoteUrl
            // 
            this.txtRemoteUrl.Location = new System.Drawing.Point(93, 37);
            this.txtRemoteUrl.Name = "txtRemoteUrl";
            this.txtRemoteUrl.Size = new System.Drawing.Size(415, 25);
            this.txtRemoteUrl.TabIndex = 0;
            this.txtRemoteUrl.Text = "http://dl5.vtcgame.vn:2008/CF_Full_1272.zip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nơi lưu trữ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Url máy chủ";
            // 
            // FrmDownloadManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 249);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmDownloadManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download Manager";
            this.Load += new System.EventHandler(this.FrmDownloadManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRemoteUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbBytesReceived;
        private System.Windows.Forms.Label lbTotalBytesToReceive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPercent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Button btnDir;
    }
}