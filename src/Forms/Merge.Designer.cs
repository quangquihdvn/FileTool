
namespace FileSplitTool
{
    partial class Merge
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
            this.txtFile1 = new System.Windows.Forms.TextBox();
            this.txtFile2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenFile1 = new System.Windows.Forms.Button();
            this.btnOpenFile2 = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.lblFile1Validate = new System.Windows.Forms.Label();
            this.btnMerge = new System.Windows.Forms.Button();
            this.lbResult2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtFile1
            // 
            this.txtFile1.Enabled = false;
            this.txtFile1.Location = new System.Drawing.Point(97, 15);
            this.txtFile1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFile1.Name = "txtFile1";
            this.txtFile1.Size = new System.Drawing.Size(429, 22);
            this.txtFile1.TabIndex = 0;
            // 
            // txtFile2
            // 
            this.txtFile2.Enabled = false;
            this.txtFile2.Location = new System.Drawing.Point(97, 64);
            this.txtFile2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFile2.Name = "txtFile2";
            this.txtFile2.Size = new System.Drawing.Size(429, 22);
            this.txtFile2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "File 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "File 2";
            // 
            // btnOpenFile1
            // 
            this.btnOpenFile1.Location = new System.Drawing.Point(555, 15);
            this.btnOpenFile1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenFile1.Name = "btnOpenFile1";
            this.btnOpenFile1.Size = new System.Drawing.Size(100, 28);
            this.btnOpenFile1.TabIndex = 4;
            this.btnOpenFile1.Text = "Select";
            this.btnOpenFile1.UseVisualStyleBackColor = true;
            this.btnOpenFile1.Click += new System.EventHandler(this.btnOpenFile1_Click);
            // 
            // btnOpenFile2
            // 
            this.btnOpenFile2.Location = new System.Drawing.Point(555, 63);
            this.btnOpenFile2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenFile2.Name = "btnOpenFile2";
            this.btnOpenFile2.Size = new System.Drawing.Size(100, 28);
            this.btnOpenFile2.TabIndex = 5;
            this.btnOpenFile2.Text = "Select";
            this.btnOpenFile2.UseVisualStyleBackColor = true;
            this.btnOpenFile2.Click += new System.EventHandler(this.btnOpenFile2_Click);
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.ItemHeight = 16;
            this.lbResult.Location = new System.Drawing.Point(16, 132);
            this.lbResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(491, 356);
            this.lbResult.TabIndex = 6;
            // 
            // lblFile1Validate
            // 
            this.lblFile1Validate.AutoSize = true;
            this.lblFile1Validate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile1Validate.ForeColor = System.Drawing.Color.Red;
            this.lblFile1Validate.Location = new System.Drawing.Point(16, 112);
            this.lblFile1Validate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFile1Validate.Name = "lblFile1Validate";
            this.lblFile1Validate.Size = new System.Drawing.Size(0, 17);
            this.lblFile1Validate.TabIndex = 7;
            this.lblFile1Validate.Visible = false;
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(437, 496);
            this.btnMerge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(217, 43);
            this.btnMerge.TabIndex = 8;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // lbResult2
            // 
            this.lbResult2.FormattingEnabled = true;
            this.lbResult2.ItemHeight = 16;
            this.lbResult2.Location = new System.Drawing.Point(540, 132);
            this.lbResult2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbResult2.Name = "lbResult2";
            this.lbResult2.Size = new System.Drawing.Size(509, 356);
            this.lbResult2.TabIndex = 9;
            // 
            // Merge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lbResult2);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.lblFile1Validate);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnOpenFile2);
            this.Controls.Add(this.btnOpenFile1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFile2);
            this.Controls.Add(this.txtFile1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Merge";
            this.Text = "Merge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFile1;
        private System.Windows.Forms.TextBox txtFile2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenFile1;
        private System.Windows.Forms.Button btnOpenFile2;
        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.Label lblFile1Validate;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.ListBox lbResult2;
    }
}