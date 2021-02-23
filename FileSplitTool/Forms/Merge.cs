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
    public partial class Merge : Form
    {
        readonly OpenFileDialog openFile = new OpenFileDialog();
        readonly List<Input01> inputs01 = new List<Input01>();
        readonly List<Input02> inputs02 = new List<Input02>();

        public Merge()
        {
            InitializeComponent();
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                FileName = "merge.txt",
                Filter = "Text Files (.txt)| *.txt"
            };
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                var path = saveFile.FileName;
                var minLine = Math.Min(inputs01.Count, inputs02.Count);
                TextWriter txt = new StreamWriter(path);
                for (var i = 0; i < minLine; i++)
                {
                    var mergeline = MergeLineHelper.MergeLine(inputs01[i], inputs02[i]);
                    var resultType = InputValidation.Validate(inputs01[i], inputs02[i]);
                    txt.Write($"{mergeline}|{resultType.GetHashCode().ConvertErrorCode()}{Environment.NewLine}");
                }
                txt.Close();
                MessageBoxHelper.Info(Resources.MSG_MERGE_FILE_SUCCESS);
            }
        }

        private void btnOpenFile1_Click(object sender, EventArgs e)
        {
            string line = "";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                lbResult.Items.Clear();
                txtFile1.Text = openFile.FileName;
                StreamReader sr = new StreamReader(openFile.FileName);
                try
                {
                    while (line != null)
                    {
                        line = sr.ReadLine();
                        if (line != null)
                        {
                            var input = new Input01();
                            input.SetValue(line);
                            inputs01.Add(input);
                            var errorCode = Input01Validation.Validation(input);
                            var result = errorCode.GetDescription();
                            lbResult.Items.Add(result);
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

        private void btnOpenFile2_Click(object sender, EventArgs e)
        {
            string line = "";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                lbResult2.Items.Clear();
                txtFile2.Text = openFile.FileName;
                StreamReader sr = new StreamReader(openFile.FileName);
                try
                {
                    while (line != null)
                    {
                        line = sr.ReadLine();
                        if (line != null)
                        {
                            var input = new Input02();
                            input.SetValue(line);
                            inputs02.Add(input);
                            var errorCode = Input02Validation.Validation(input);
                            var result = errorCode.GetDescription();
                            lbResult2.Items.Add(result);
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

        
    }
}
