using FileSplitTool.Commons;
using FileSplitTool.Models;
using FileSplitTool.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSplitTool.Forms
{
    public partial class Convert : Form
    {
        readonly OpenFileDialog openFile = new OpenFileDialog();
        public Convert()
        {
            InitializeComponent();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            string line = "";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                lbResult.Items.Clear();
                txtFileName.Text = openFile.FileName;
                StreamReader sr = new StreamReader(openFile.FileName);
                try
                {
                    while (line != null)
                    {
                        line = sr.ReadLine();
                        if (line != null)
                        {
                            var input = new ConvertFile();
                            input.SetValue(line);
                            var newLine = input.MergeFile();
                            lbResult.Items.Add(newLine);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBoxHelper.Error(Resources.MSG_INVALID_FILE_CONTENT);
                }
                sr.Close();
            }
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                FileName = "convert.txt",
                Filter = "Text Files (.txt)| *.txt"
            };
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                var path = saveFile.FileName;
                TextWriter txt = new StreamWriter(path);
                foreach (var item in lbResult.Items)
                {
                    txt.Write(item.ToString() + Environment.NewLine);
                }
                txt.Close();
                MessageBoxHelper.Info(Resources.MSG_CONVERT_SUCCESS);
            }
        }

        private void Convert_Load(object sender, EventArgs e)
        {
            
        }
    }
}
