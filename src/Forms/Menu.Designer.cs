
namespace FileSplitTool
{
    partial class Menu
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
            this.btnOpenExportForm = new System.Windows.Forms.Button();
            this.btnOpenMergeForm = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenExportForm
            // 
            this.btnOpenExportForm.Location = new System.Drawing.Point(23, 29);
            this.btnOpenExportForm.Name = "btnOpenExportForm";
            this.btnOpenExportForm.Size = new System.Drawing.Size(119, 39);
            this.btnOpenExportForm.TabIndex = 0;
            this.btnOpenExportForm.Text = "Export";
            this.btnOpenExportForm.UseVisualStyleBackColor = true;
            this.btnOpenExportForm.Click += new System.EventHandler(this.btnOpenExportForm_Click);
            // 
            // btnOpenMergeForm
            // 
            this.btnOpenMergeForm.Location = new System.Drawing.Point(185, 28);
            this.btnOpenMergeForm.Name = "btnOpenMergeForm";
            this.btnOpenMergeForm.Size = new System.Drawing.Size(119, 41);
            this.btnOpenMergeForm.TabIndex = 1;
            this.btnOpenMergeForm.Text = "Merge";
            this.btnOpenMergeForm.UseVisualStyleBackColor = true;
            this.btnOpenMergeForm.Click += new System.EventHandler(this.btnOpenMergeForm_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(23, 95);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(119, 39);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 167);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnOpenMergeForm);
            this.Controls.Add(this.btnOpenExportForm);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenExportForm;
        private System.Windows.Forms.Button btnOpenMergeForm;
        private System.Windows.Forms.Button btnConvert;
    }
}