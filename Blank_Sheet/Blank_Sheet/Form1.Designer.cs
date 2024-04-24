
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
            this.btnopenyourdesktop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbluploaddatacsvfilepath = new System.Windows.Forms.Label();
            this.lbluploadimagedatapath = new System.Windows.Forms.Label();
            this.btnprocess = new System.Windows.Forms.Button();
            this.btnuploaddatacsvfile = new System.Windows.Forms.Button();
            this.btnuploadimagedata = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.step1backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.groupBox1.Controls.Add(this.btnopenyourdesktop);
            this.groupBox1.Controls.Add(this.btnBlankSheet);
            this.groupBox1.Location = new System.Drawing.Point(26, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1370, 93);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1 Create a balnk Sheet";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // btnopenyourdesktop
            // 
            this.btnopenyourdesktop.Location = new System.Drawing.Point(449, 45);
            this.btnopenyourdesktop.Name = "btnopenyourdesktop";
            this.btnopenyourdesktop.Size = new System.Drawing.Size(108, 32);
            this.btnopenyourdesktop.TabIndex = 2;
            this.btnopenyourdesktop.Text = "Open your desktop";
            this.btnopenyourdesktop.UseVisualStyleBackColor = true;
            this.btnopenyourdesktop.Click += new System.EventHandler(this.btnopenyourdesktop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.lbluploaddatacsvfilepath);
            this.groupBox2.Controls.Add(this.lbluploadimagedatapath);
            this.groupBox2.Controls.Add(this.btnprocess);
            this.groupBox2.Controls.Add(this.btnuploaddatacsvfile);
            this.groupBox2.Controls.Add(this.btnuploadimagedata);
            this.groupBox2.Location = new System.Drawing.Point(26, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1353, 238);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 2 Process Image data";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Blank_Sheet.Properties.Resources.games_valorant_icon_2048x2048_68la6c9i;
            this.pictureBox1.Location = new System.Drawing.Point(981, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(598, 183);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Visible = false;
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
            // btnprocess
            // 
            this.btnprocess.Location = new System.Drawing.Point(438, 174);
            this.btnprocess.Name = "btnprocess";
            this.btnprocess.Size = new System.Drawing.Size(119, 32);
            this.btnprocess.TabIndex = 4;
            this.btnprocess.Text = "Process";
            this.btnprocess.UseVisualStyleBackColor = true;
            this.btnprocess.Click += new System.EventHandler(this.btnprocess_Click);
            // 
            // btnuploaddatacsvfile
            // 
            this.btnuploaddatacsvfile.Location = new System.Drawing.Point(844, 50);
            this.btnuploaddatacsvfile.Name = "btnuploaddatacsvfile";
            this.btnuploaddatacsvfile.Size = new System.Drawing.Size(130, 32);
            this.btnuploaddatacsvfile.TabIndex = 3;
            this.btnuploaddatacsvfile.Text = "Upload Data CSV File";
            this.btnuploaddatacsvfile.UseVisualStyleBackColor = true;
            this.btnuploaddatacsvfile.Click += new System.EventHandler(this.btnuploaddatacsvfile_Click);
            // 
            // btnuploadimagedata
            // 
            this.btnuploadimagedata.Location = new System.Drawing.Point(6, 50);
            this.btnuploadimagedata.Name = "btnuploadimagedata";
            this.btnuploadimagedata.Size = new System.Drawing.Size(114, 32);
            this.btnuploadimagedata.TabIndex = 2;
            this.btnuploadimagedata.Text = "Upload Image Data";
            this.btnuploadimagedata.UseVisualStyleBackColor = true;
            this.btnuploadimagedata.Click += new System.EventHandler(this.btnuploadimagedata_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBlankSheet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnopenyourdesktop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnuploaddatacsvfile;
        private System.Windows.Forms.Button btnuploadimagedata;
        private System.Windows.Forms.Button btnprocess;
        private System.Windows.Forms.Label lbluploadimagedatapath;
        private System.Windows.Forms.Label lbluploaddatacsvfilepath;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar step1progressBar;
        private System.ComponentModel.BackgroundWorker step1backgroundWorker1;
    }
}

