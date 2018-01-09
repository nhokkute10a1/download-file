namespace WPF
{
    partial class FrmCheckSum
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
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.btnCheckSum = new System.Windows.Forms.Button();
            this.grCheckSum = new System.Windows.Forms.DataGridView();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileMD5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grCheckSum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(12, 12);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(94, 23);
            this.btnChooseFile.TabIndex = 0;
            this.btnChooseFile.Text = "&Chọn tệp tin";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.BtnChooseFile_Click);
            // 
            // btnCheckSum
            // 
            this.btnCheckSum.Location = new System.Drawing.Point(112, 12);
            this.btnCheckSum.Name = "btnCheckSum";
            this.btnCheckSum.Size = new System.Drawing.Size(94, 23);
            this.btnCheckSum.TabIndex = 0;
            this.btnCheckSum.Text = "&CheckSum";
            this.btnCheckSum.UseVisualStyleBackColor = true;
            this.btnCheckSum.Click += new System.EventHandler(this.BtnCheckSum_Click);
            // 
            // grCheckSum
            // 
            this.grCheckSum.AllowUserToAddRows = false;
            this.grCheckSum.AllowUserToDeleteRows = false;
            this.grCheckSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grCheckSum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilePath,
            this.FileName,
            this.FileMD5});
            this.grCheckSum.Location = new System.Drawing.Point(12, 50);
            this.grCheckSum.Name = "grCheckSum";
            this.grCheckSum.ReadOnly = true;
            this.grCheckSum.Size = new System.Drawing.Size(626, 240);
            this.grCheckSum.TabIndex = 1;
            // 
            // FilePath
            // 
            this.FilePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FilePath.DataPropertyName = "FilePath";
            this.FilePath.HeaderText = "FilePath";
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FileName.DataPropertyName = "FileName";
            this.FileName.HeaderText = "FileName";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FileMD5
            // 
            this.FileMD5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FileMD5.DataPropertyName = "FileMD5";
            this.FileMD5.HeaderText = "FileMD5";
            this.FileMD5.Name = "FileMD5";
            this.FileMD5.ReadOnly = true;
            this.FileMD5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmCheckSum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 302);
            this.Controls.Add(this.grCheckSum);
            this.Controls.Add(this.btnCheckSum);
            this.Controls.Add(this.btnChooseFile);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmCheckSum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckSum File";
            ((System.ComponentModel.ISupportInitialize)(this.grCheckSum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button btnCheckSum;
        private System.Windows.Forms.DataGridView grCheckSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileMD5;
    }
}