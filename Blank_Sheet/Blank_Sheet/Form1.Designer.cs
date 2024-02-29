
namespace Blank_Sheet
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBlankSheet = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUploadCSVFile = new System.Windows.Forms.Button();
            this.btnupdateoldcsvfile = new System.Windows.Forms.Button();
            this.btnUpdateSheet1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnBlankSheet);
            this.panel1.Location = new System.Drawing.Point(51, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1407, 86);
            this.panel1.TabIndex = 0;
            // 
            // btnBlankSheet
            // 
            this.btnBlankSheet.Location = new System.Drawing.Point(1248, 30);
            this.btnBlankSheet.Name = "btnBlankSheet";
            this.btnBlankSheet.Size = new System.Drawing.Size(100, 32);
            this.btnBlankSheet.TabIndex = 1;
            this.btnBlankSheet.Text = "Sheet";
            this.btnBlankSheet.UseVisualStyleBackColor = true;
            this.btnBlankSheet.Click += new System.EventHandler(this.btnBlankSheet_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.btnUpdateSheet1);
            this.panel2.Controls.Add(this.btnupdateoldcsvfile);
            this.panel2.Controls.Add(this.btnUploadCSVFile);
            this.panel2.Location = new System.Drawing.Point(52, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1407, 166);
            this.panel2.TabIndex = 1;
            // 
            // btnUploadCSVFile
            // 
            this.btnUploadCSVFile.Location = new System.Drawing.Point(361, 37);
            this.btnUploadCSVFile.Name = "btnUploadCSVFile";
            this.btnUploadCSVFile.Size = new System.Drawing.Size(100, 34);
            this.btnUploadCSVFile.TabIndex = 2;
            this.btnUploadCSVFile.Text = "UploadCSVFile";
            this.btnUploadCSVFile.UseVisualStyleBackColor = true;
            this.btnUploadCSVFile.Click += new System.EventHandler(this.btnUploadCSVFile_Click);
            // 
            // btnupdateoldcsvfile
            // 
            this.btnupdateoldcsvfile.Location = new System.Drawing.Point(768, 37);
            this.btnupdateoldcsvfile.Name = "btnupdateoldcsvfile";
            this.btnupdateoldcsvfile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnupdateoldcsvfile.Size = new System.Drawing.Size(100, 31);
            this.btnupdateoldcsvfile.TabIndex = 3;
            this.btnupdateoldcsvfile.Text = "UploadOldCsvFile";
            this.btnupdateoldcsvfile.UseVisualStyleBackColor = true;
            this.btnupdateoldcsvfile.Click += new System.EventHandler(this.btnupdateoldcsvfile_Click);
            // 
            // btnUpdateSheet1
            // 
            this.btnUpdateSheet1.Location = new System.Drawing.Point(579, 114);
            this.btnUpdateSheet1.Name = "btnUpdateSheet1";
            this.btnUpdateSheet1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUpdateSheet1.Size = new System.Drawing.Size(100, 31);
            this.btnUpdateSheet1.TabIndex = 4;
            this.btnUpdateSheet1.Text = "Process";
            this.btnUpdateSheet1.UseVisualStyleBackColor = true;
            this.btnUpdateSheet1.Click += new System.EventHandler(this.btnUpdateSheet1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 712);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBlankSheet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdateSheet1;
        private System.Windows.Forms.Button btnupdateoldcsvfile;
        private System.Windows.Forms.Button btnUploadCSVFile;
    }
}

