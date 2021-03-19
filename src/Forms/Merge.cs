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
        List<Input01> inputs01 = new List<Input01>();
        List<Input02> inputs02 = new List<Input02>();

        public Merge()
        {
            InitializeComponent();
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            var errorLines = new List<string>();
            SaveFileDialog saveSuccessFile = new SaveFileDialog
            {
                FileName = "success.txt",
                Filter = "Text Files (.txt)| *.txt"
            };
            if (saveSuccessFile.ShowDialog() == DialogResult.OK)
            {
                var path = saveSuccessFile.FileName;
                var minLine = Math.Min(inputs01.Count, inputs02.Count);
                TextWriter txt = new StreamWriter(path);
                
                for (var i = 0; i < minLine; i++)
                {
                    var mergeline = MergeLineHelper.MergeLine(inputs01[i], inputs02[i]);
                    var resultType = InputValidation.Validate(inputs01[i], inputs02[i]);
                    if(resultType == ResultType.Success)
                    {
                        var successLine = $"{mergeline}{Environment.NewLine}";
                        txt.Write(successLine);
                    }
                    else
                    {
                        var errorLine = $"{mergeline}|{resultType.GetHashCode().ConvertErrorCode()}{Environment.NewLine}";
                        errorLines.Add(errorLine);
                    }
                }
                txt.Close();
                
            }

            if (errorLines.Any())
            {
                SaveFileDialog saveErrorFile = new SaveFileDialog
                {
                    FileName = "error.txt",
                    Filter = "Text Files (.txt)| *.txt"
                };
                if (saveErrorFile.ShowDialog() == DialogResult.OK)
                {
                    var path = saveErrorFile.FileName;
                    TextWriter errorTxt = new StreamWriter(path);
                    foreach(var line in errorLines)
                    {
                        errorTxt.Write(line);
                    }
                    errorTxt.Close();
                }
            }
            MessageBoxHelper.Info(Resources.MSG_MERGE_FILE_SUCCESS);
        }
        
        private void btnOpenFile1_Click(object sender, EventArgs e)
        {
            string line = "";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                lbResult.Items.Clear();
                inputs01 = new List<Input01>();
                txtFile1.Text = openFile.FileName;
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
                inputs02 = new List<Input02>();
                txtFile2.Text = openFile.FileName;
                StreamReader sr = new StreamReader(openFile.FileName);
                try
                {
                    while (line != null)
                    {
                        line = sr.ReadLine();
                        if (line != null)
                        {
                            var input = new Input02(line.Length);
                            input.SetValue(line);
                            inputs02.Add(input);
                            var errorCode = Input02Validation.Validation(input);
                            var result = errorCode.GetDescription();
                            lbResult2.Items.Add(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBoxHelper.Error(Resources.MSG_INVALID_FILE_CONTENT);
                }
                sr.Close();
            }
        }

        
    }
}
