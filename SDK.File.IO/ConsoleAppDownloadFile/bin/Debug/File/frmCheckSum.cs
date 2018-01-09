using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WPF
{
    public partial class FrmCheckSum : Form
    {
        private string Msg = string.Empty;
        public FrmCheckSum()
        {
            InitializeComponent();
        }
        private void BtnChooseFile_Click(object sender, EventArgs e)
        {
            ChooseFile();
        }
        private void BtnCheckSum_Click(object sender, EventArgs e)
        {
            CheckSum();
        }

        #region[CheckSum]
        private void ChooseFile()
        {
            using (var Dialog = new OpenFileDialog())
            {
                Dialog.Title = "Chọn tệp tin";
                Dialog.Filter = "All files (*.*)|*.*";
                Dialog.Multiselect = true;
                if (Dialog.ShowDialog() == DialogResult.OK)
                {
                    ModelFile[] files = new ModelFile[Dialog.FileNames.Length];
                    int i = 0;
                    foreach (string f in Dialog.FileNames)
                    {
                        files[i] = new ModelFile
                        {
                            FilePath = Path.GetDirectoryName(f),
                            FileName = Path.GetFileName(f)
                        };
                        // MD5 checksum
                        using (var md5 = MD5.Create())
                        {
                            using (var stream = File.OpenRead(f))
                            {
                                files[i].FileMD5 = BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "");
                            }
                        }
                        i++;
                    }
                    grCheckSum.AutoGenerateColumns = false;
                    grCheckSum.DataSource = files;
                }
            }
        }
        private void CheckSum()
        {
            for (int i = 0; i < grCheckSum.Rows.Count; i++)
            {
                for (int j = i + 1; j < grCheckSum.Rows.Count; j++)
                {
                    if (grCheckSum["FileMD5", i].Value.ToString() == grCheckSum["FileMD5", j].Value.ToString())
                    {
                        grCheckSum.Rows[i].DefaultCellStyle.BackColor = Color.Gold;
                        grCheckSum.Rows[j].DefaultCellStyle.BackColor = Color.Gold;
                    }
                }
            }
            MessageBox.Show("Tìm thấy sự trùng lặp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
    public class ModelFile
    {
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public string FileMD5 { get; set; }
    }
}
