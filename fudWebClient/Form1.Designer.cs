namespace fudWebClient
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
            this.button1 = new System.Windows.Forms.Button();
            this.checkRun = new System.Windows.Forms.CheckBox();
            this.checkEncUrl = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkEncExe = new System.Windows.Forms.CheckBox();
            this.logTxt = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkFile = new System.Windows.Forms.CheckBox();
            this.checkDownload = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkRun
            // 
            this.checkRun.AutoSize = true;
            this.checkRun.Location = new System.Drawing.Point(6, 19);
            this.checkRun.Name = "checkRun";
            this.checkRun.Size = new System.Drawing.Size(46, 17);
            this.checkRun.TabIndex = 1;
            this.checkRun.Text = "Run";
            this.checkRun.UseVisualStyleBackColor = true;
            // 
            // checkEncUrl
            // 
            this.checkEncUrl.AutoSize = true;
            this.checkEncUrl.Location = new System.Drawing.Point(58, 19);
            this.checkEncUrl.Name = "checkEncUrl";
            this.checkEncUrl.Size = new System.Drawing.Size(78, 17);
            this.checkEncUrl.TabIndex = 2;
            this.checkEncUrl.Text = "Encrypt Url";
            this.checkEncUrl.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "URL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 177);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PoC";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkRun);
            this.groupBox2.Controls.Add(this.checkEncExe);
            this.groupBox2.Controls.Add(this.checkEncUrl);
            this.groupBox2.Location = new System.Drawing.Point(6, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 43);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // checkEncExe
            // 
            this.checkEncExe.AutoSize = true;
            this.checkEncExe.Location = new System.Drawing.Point(142, 19);
            this.checkEncExe.Name = "checkEncExe";
            this.checkEncExe.Size = new System.Drawing.Size(86, 17);
            this.checkEncExe.TabIndex = 4;
            this.checkEncExe.Text = "Encrypt EXE";
            this.checkEncExe.UseVisualStyleBackColor = true;
            // 
            // logTxt
            // 
            this.logTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.logTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logTxt.ForeColor = System.Drawing.Color.Lime;
            this.logTxt.Location = new System.Drawing.Point(12, 195);
            this.logTxt.Name = "logTxt";
            this.logTxt.Size = new System.Drawing.Size(243, 62);
            this.logTxt.TabIndex = 5;
            this.logTxt.Text = "Log";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkFile);
            this.groupBox3.Controls.Add(this.checkDownload);
            this.groupBox3.Location = new System.Drawing.Point(6, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 43);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Proxy Options";
            // 
            // checkFile
            // 
            this.checkFile.AutoSize = true;
            this.checkFile.Location = new System.Drawing.Point(6, 19);
            this.checkFile.Name = "checkFile";
            this.checkFile.Size = new System.Drawing.Size(42, 17);
            this.checkFile.TabIndex = 1;
            this.checkFile.Text = "File";
            this.checkFile.UseVisualStyleBackColor = true;
            this.checkFile.CheckedChanged += new System.EventHandler(this.checkFile_CheckedChanged);
            // 
            // checkDownload
            // 
            this.checkDownload.AutoSize = true;
            this.checkDownload.Location = new System.Drawing.Point(54, 20);
            this.checkDownload.Name = "checkDownload";
            this.checkDownload.Size = new System.Drawing.Size(74, 17);
            this.checkDownload.TabIndex = 2;
            this.checkDownload.Text = "Download";
            this.checkDownload.UseVisualStyleBackColor = true;
            this.checkDownload.CheckedChanged += new System.EventHandler(this.checkDownload_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 266);
            this.Controls.Add(this.logTxt);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "fudWebClient";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkRun;
        private System.Windows.Forms.CheckBox checkEncUrl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkEncExe;
        private System.Windows.Forms.RichTextBox logTxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkFile;
        private System.Windows.Forms.CheckBox checkDownload;
    }
}

