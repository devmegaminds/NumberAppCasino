
namespace Numberapp
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
            this.btnProcess = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnupdateoldcsvfile = new System.Windows.Forms.Button();
            this.btnUploadCSVFile = new System.Windows.Forms.Button();
            this.btnUpdateSheet1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btnBlankSheet);
            this.panel1.Location = new System.Drawing.Point(61, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1405, 95);
            this.panel1.TabIndex = 0;
            // 
            // btnBlankSheet
            // 
            this.btnBlankSheet.Location = new System.Drawing.Point(1260, 30);
            this.btnBlankSheet.Name = "btnBlankSheet";
            this.btnBlankSheet.Size = new System.Drawing.Size(100, 32);
            this.btnBlankSheet.TabIndex = 0;
            this.btnBlankSheet.Text = "Sheet";
            this.btnBlankSheet.UseVisualStyleBackColor = true;
            this.btnBlankSheet.Click += new System.EventHandler(this.btnBlankSheet_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.btnProcess);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnUploadImage);
            this.panel2.Location = new System.Drawing.Point(61, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1405, 362);
            this.panel2.TabIndex = 1;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(1133, 198);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(100, 34);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(346, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(859, 138);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(38, 44);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(100, 37);
            this.btnUploadImage.TabIndex = 0;
            this.btnUploadImage.Text = "UploadImage";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.btnupdateoldcsvfile);
            this.panel3.Controls.Add(this.btnUploadCSVFile);
            this.panel3.Controls.Add(this.btnUpdateSheet1);
            this.panel3.Location = new System.Drawing.Point(61, 598);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1405, 183);
            this.panel3.TabIndex = 2;
            // 
            // btnupdateoldcsvfile
            // 
            this.btnupdateoldcsvfile.Location = new System.Drawing.Point(815, 58);
            this.btnupdateoldcsvfile.Name = "btnupdateoldcsvfile";
            this.btnupdateoldcsvfile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnupdateoldcsvfile.Size = new System.Drawing.Size(100, 31);
            this.btnupdateoldcsvfile.TabIndex = 2;
            this.btnupdateoldcsvfile.Text = "UploadOldCsvFile";
            this.btnupdateoldcsvfile.UseVisualStyleBackColor = true;
            this.btnupdateoldcsvfile.Click += new System.EventHandler(this.btnupdateoldcsvfile_Click);
            // 
            // btnUploadCSVFile
            // 
            this.btnUploadCSVFile.Location = new System.Drawing.Point(363, 56);
            this.btnUploadCSVFile.Name = "btnUploadCSVFile";
            this.btnUploadCSVFile.Size = new System.Drawing.Size(100, 34);
            this.btnUploadCSVFile.TabIndex = 1;
            this.btnUploadCSVFile.Text = "UploadCSVFile";
            this.btnUploadCSVFile.UseVisualStyleBackColor = true;
            this.btnUploadCSVFile.Click += new System.EventHandler(this.btnUploadCSVFile_Click);
            // 
            // btnUpdateSheet1
            // 
            this.btnUpdateSheet1.Location = new System.Drawing.Point(591, 116);
            this.btnUpdateSheet1.Name = "btnUpdateSheet1";
            this.btnUpdateSheet1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUpdateSheet1.Size = new System.Drawing.Size(100, 31);
            this.btnUpdateSheet1.TabIndex = 0;
            this.btnUpdateSheet1.Text = "Process";
            this.btnUpdateSheet1.UseVisualStyleBackColor = true;
            this.btnUpdateSheet1.Click += new System.EventHandler(this.btnUpdateSheet1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 1014);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBlankSheet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUploadCSVFile;
        private System.Windows.Forms.Button btnUpdateSheet1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnupdateoldcsvfile;
    }
}

