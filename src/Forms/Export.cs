using FileSplitTool.Commons;
using FileSplitTool.Extensions;
using FileSplitTool.Models;
using FileSplitTool.Properties;
using FileSplitTool.Validation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileSplitTool
{
    public partial class Export : Form
    {
        readonly OpenFileDialog openFile = new OpenFileDialog();
        //readonly List<ResultType> errors = new List<ResultType>();

        public Export()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
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
                            var input = new Input01(line.Length);
                            input.SetValue(line);
                            var errorCode = Input01Validation.Validation(input);
                            if (errorCode == ResultType.Success)
                            {
                                lbResult.Items.Add($"{input.RecordNumber.Value}{input.PAN.Value}");
                            }
                            else
                            {
                                lbResult.Items.Add(errorCode.GetDescription());
                                //errors.Add(errorCode);
                            }
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

        private void Form1_Load(object sender, EventArgs e)
        {
            openFile.Filter = "Xml Files (.xml)| *.xml";
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                FileName = "output.txt",
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
                MessageBoxHelper.Info(Resources.MSG_EXPORT_SUCCESS);
            }
        }
    }
}
