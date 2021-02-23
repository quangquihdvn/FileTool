using System;
using System.Windows.Forms;

namespace FileSplitTool
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnOpenExportForm_Click(object sender, EventArgs e)
        {
            Export export = new Export();
            export.Show();
        }

        private void btnOpenMergeForm_Click(object sender, EventArgs e)
        {
            Merge merge = new Merge();
            merge.Show();
        }
    }
}
