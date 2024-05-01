
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBlankSheet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.step1progressBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenyourDesktop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imgInformation = new System.Windows.Forms.PictureBox();
            this.step2Progressbar = new System.Windows.Forms.ProgressBar();
            this.lbluploaddatacsvfilepath = new System.Windows.Forms.Label();
            this.lbluploadimagedatapath = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnUploadDataCSVFile = new System.Windows.Forms.Button();
            this.btnUploadImageData = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.step1backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBlankSheet
            // 
            this.btnBlankSheet.Location = new System.Drawing.Point(6, 45);
            this.btnBlankSheet.Name = "btnBlankSheet";
            this.btnBlankSheet.Size = new System.Drawing.Size(100, 32);
            this.btnBlankSheet.TabIndex = 1;
            this.btnBlankSheet.Text = "Create new Sheet";
            this.btnBlankSheet.UseVisualStyleBackColor = true;
            this.btnBlankSheet.Click += new System.EventHandler(this.btnBlankSheet_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.step1progressBar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnOpenyourDesktop);
            this.groupBox1.Controls.Add(this.btnBlankSheet);
            this.groupBox1.Location = new System.Drawing.Point(26, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1370, 93);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1 Create a balnk Sheet";
            // 
            // step1progressBar
            // 
            this.step1progressBar.Location = new System.Drawing.Point(983, 45);
            this.step1progressBar.Name = "step1progressBar";
            this.step1progressBar.Size = new System.Drawing.Size(100, 23);
            this.step1progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.step1progressBar.TabIndex = 5;
            this.step1progressBar.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Note: This file name would be \"ddMMyyyyHHmmss.csv\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Note: This file will store on your desktop";
            // 
            // btnOpenyourDesktop
            // 
            this.btnOpenyourDesktop.Location = new System.Drawing.Point(449, 45);
            this.btnOpenyourDesktop.Name = "btnOpenyourDesktop";
            this.btnOpenyourDesktop.Size = new System.Drawing.Size(108, 32);
            this.btnOpenyourDesktop.TabIndex = 2;
            this.btnOpenyourDesktop.Text = "Open your desktop";
            this.btnOpenyourDesktop.UseVisualStyleBackColor = true;
            this.btnOpenyourDesktop.Click += new System.EventHandler(this.btnOpenyourDesktop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.imgInformation);
            this.groupBox2.Controls.Add(this.step2Progressbar);
            this.groupBox2.Controls.Add(this.lbluploaddatacsvfilepath);
            this.groupBox2.Controls.Add(this.lbluploadimagedatapath);
            this.groupBox2.Controls.Add(this.btnProcess);
            this.groupBox2.Controls.Add(this.btnUploadDataCSVFile);
            this.groupBox2.Controls.Add(this.btnUploadImageData);
            this.groupBox2.Location = new System.Drawing.Point(26, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1353, 238);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 2 Process Image data";
            // 
            // imgInformation
            // 
            this.imgInformation.Image = global::Blank_Sheet.Properties.Resources.img;
            this.imgInformation.Location = new System.Drawing.Point(981, 50);
            this.imgInformation.Name = "imgInformation";
            this.imgInformation.Size = new System.Drawing.Size(17, 22);
            this.imgInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgInformation.TabIndex = 8;
            this.imgInformation.TabStop = false;
            this.imgInformation.Click += new System.EventHandler(this.imgInformation_Click);
            // 
            // step2Progressbar
            // 
            this.step2Progressbar.Location = new System.Drawing.Point(598, 183);
            this.step2Progressbar.Name = "step2Progressbar";
            this.step2Progressbar.Size = new System.Drawing.Size(100, 23);
            this.step2Progressbar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.step2Progressbar.TabIndex = 7;
            this.step2Progressbar.Visible = false;
            // 
            // lbluploaddatacsvfilepath
            // 
            this.lbluploaddatacsvfilepath.AutoSize = true;
            this.lbluploaddatacsvfilepath.Location = new System.Drawing.Point(849, 113);
            this.lbluploaddatacsvfilepath.Name = "lbluploaddatacsvfilepath";
            this.lbluploaddatacsvfilepath.Size = new System.Drawing.Size(0, 13);
            this.lbluploaddatacsvfilepath.TabIndex = 6;
            // 
            // lbluploadimagedatapath
            // 
            this.lbluploadimagedatapath.AutoSize = true;
            this.lbluploadimagedatapath.Location = new System.Drawing.Point(6, 102);
            this.lbluploadimagedatapath.Name = "lbluploadimagedatapath";
            this.lbluploadimagedatapath.Size = new System.Drawing.Size(0, 13);
            this.lbluploadimagedatapath.TabIndex = 5;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(438, 174);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(119, 32);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnUploadDataCSVFile
            // 
            this.btnUploadDataCSVFile.Location = new System.Drawing.Point(844, 50);
            this.btnUploadDataCSVFile.Name = "btnUploadDataCSVFile";
            this.btnUploadDataCSVFile.Size = new System.Drawing.Size(130, 32);
            this.btnUploadDataCSVFile.TabIndex = 3;
            this.btnUploadDataCSVFile.Text = "Upload Data CSV File";
            this.btnUploadDataCSVFile.UseVisualStyleBackColor = true;
            this.btnUploadDataCSVFile.Click += new System.EventHandler(this.btnUploadDataCSVFile_Click_1);
            // 
            // btnUploadImageData
            // 
            this.btnUploadImageData.Location = new System.Drawing.Point(9, 50);
            this.btnUploadImageData.Name = "btnUploadImageData";
            this.btnUploadImageData.Size = new System.Drawing.Size(114, 32);
            this.btnUploadImageData.TabIndex = 2;
            this.btnUploadImageData.Text = "Upload Image Data";
            this.btnUploadImageData.UseVisualStyleBackColor = true;
            this.btnUploadImageData.Click += new System.EventHandler(this.btnUploadImageData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 712);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NumberApp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBlankSheet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenyourDesktop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUploadDataCSVFile;
        private System.Windows.Forms.Button btnUploadImageData;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lbluploadimagedatapath;
        private System.Windows.Forms.Label lbluploaddatacsvfilepath;
        private System.Windows.Forms.ProgressBar step2Progressbar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox imgInformation;
        private System.Windows.Forms.ProgressBar step1progressBar;
        private System.ComponentModel.BackgroundWorker step1backgroundWorker1;
    }
}

