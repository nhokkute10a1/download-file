namespace WPF
{
    partial class FrmMainForm
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbtientrinh = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelPerc = new System.Windows.Forms.Label();
            this.labelDownloaded = new System.Windows.Forms.Label();
            this.progressBarDownload = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtUrlDownload = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.btnChooseFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check Sum MD5";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(6, 58);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(322, 108);
            this.txtResult.TabIndex = 1;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(6, 24);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(98, 28);
            this.btnChooseFile.TabIndex = 0;
            this.btnChooseFile.Text = "&Chọn tệp";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.BtnChooseFile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbtientrinh);
            this.groupBox2.Controls.Add(this.labelSpeed);
            this.groupBox2.Controls.Add(this.labelPerc);
            this.groupBox2.Controls.Add(this.labelDownloaded);
            this.groupBox2.Controls.Add(this.progressBarDownload);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnDownload);
            this.groupBox2.Controls.Add(this.txtUrlDownload);
            this.groupBox2.Location = new System.Drawing.Point(352, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 252);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Download File";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 55;
            this.label6.Text = "Tốc độ tải::";
            // 
            // lbtientrinh
            // 
            this.lbtientrinh.AutoSize = true;
            this.lbtientrinh.Location = new System.Drawing.Point(6, 196);
            this.lbtientrinh.Name = "lbtientrinh";
            this.lbtientrinh.Size = new System.Drawing.Size(84, 17);
            this.lbtientrinh.TabIndex = 56;
            this.lbtientrinh.Text = "Tiến trình tải:";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.ForeColor = System.Drawing.Color.Red;
            this.labelSpeed.Location = new System.Drawing.Point(96, 222);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(33, 17);
            this.labelSpeed.TabIndex = 54;
            this.labelSpeed.Text = "0 kb";
            // 
            // labelPerc
            // 
            this.labelPerc.AutoSize = true;
            this.labelPerc.ForeColor = System.Drawing.Color.Red;
            this.labelPerc.Location = new System.Drawing.Point(154, 169);
            this.labelPerc.Name = "labelPerc";
            this.labelPerc.Size = new System.Drawing.Size(28, 17);
            this.labelPerc.TabIndex = 53;
            this.labelPerc.Text = "0%";
            // 
            // labelDownloaded
            // 
            this.labelDownloaded.AutoSize = true;
            this.labelDownloaded.ForeColor = System.Drawing.Color.Red;
            this.labelDownloaded.Location = new System.Drawing.Point(96, 196);
            this.labelDownloaded.Name = "labelDownloaded";
            this.labelDownloaded.Size = new System.Drawing.Size(44, 17);
            this.labelDownloaded.TabIndex = 52;
            this.labelDownloaded.Text = "0/0 kb";
            // 
            // progressBarDownload
            // 
            this.progressBarDownload.Location = new System.Drawing.Point(9, 143);
            this.progressBarDownload.Name = "progressBarDownload";
            this.progressBarDownload.Size = new System.Drawing.Size(313, 23);
            this.progressBarDownload.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Url download phải có định dạng là\r\nVí dụ : http://domain.com/FileName.phần mở rộn" +
    "g";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(236, 48);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(87, 25);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "&Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // txtUrlDownload
            // 
            this.txtUrlDownload.Location = new System.Drawing.Point(6, 49);
            this.txtUrlDownload.Name = "txtUrlDownload";
            this.txtUrlDownload.Size = new System.Drawing.Size(223, 25);
            this.txtUrlDownload.TabIndex = 0;
            this.txtUrlDownload.Text = "dl5.vtcgame.vn:2008/CF_Full_1272.zip";
            // 
            // FrmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 273);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WPF";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUrlDownload;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBarDownload;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbtientrinh;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelPerc;
        private System.Windows.Forms.Label labelDownloaded;
    }
}

