namespace SharepointUpload
{
    partial class SharepointUpload
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.folderTxt = new System.Windows.Forms.TextBox();
            this.linkTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.domainTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pathBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pathTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.folderTxt);
            this.groupBox1.Controls.Add(this.linkTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.domainTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pathBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pathTxt);
            this.groupBox1.Controls.Add(this.passTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.userTxt);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sharepoint data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Folder:";
            // 
            // folderTxt
            // 
            this.folderTxt.Location = new System.Drawing.Point(259, 77);
            this.folderTxt.Name = "folderTxt";
            this.folderTxt.Size = new System.Drawing.Size(111, 20);
            this.folderTxt.TabIndex = 11;
            this.folderTxt.Text = "SharepointFolder";
            // 
            // linkTxt
            // 
            this.linkTxt.Location = new System.Drawing.Point(215, 48);
            this.linkTxt.Name = "linkTxt";
            this.linkTxt.ReadOnly = true;
            this.linkTxt.Size = new System.Drawing.Size(262, 20);
            this.linkTxt.TabIndex = 10;
            this.linkTxt.Text = "https://sharepoint.domain.lan/path/to/service/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Link:";
            // 
            // domainTxt
            // 
            this.domainTxt.Location = new System.Drawing.Point(83, 77);
            this.domainTxt.Name = "domainTxt";
            this.domainTxt.ReadOnly = true;
            this.domainTxt.Size = new System.Drawing.Size(111, 20);
            this.domainTxt.TabIndex = 8;
            this.domainTxt.Text = "domain";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Domain:";
            // 
            // pathBtn
            // 
            this.pathBtn.Location = new System.Drawing.Point(444, 119);
            this.pathBtn.Name = "pathBtn";
            this.pathBtn.Size = new System.Drawing.Size(25, 23);
            this.pathBtn.TabIndex = 6;
            this.pathBtn.Text = "...";
            this.pathBtn.UseVisualStyleBackColor = true;
            this.pathBtn.Click += new System.EventHandler(this.pathBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Path:";
            // 
            // pathTxt
            // 
            this.pathTxt.Location = new System.Drawing.Point(22, 120);
            this.pathTxt.Name = "pathTxt";
            this.pathTxt.ReadOnly = true;
            this.pathTxt.Size = new System.Drawing.Size(419, 20);
            this.pathTxt.TabIndex = 4;
            this.pathTxt.Text = "C:\\Users\\username\\Desktop\\fileForUpload.tmp";
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(83, 48);
            this.passTxt.Name = "passTxt";
            this.passTxt.PasswordChar = '*';
            this.passTxt.ReadOnly = true;
            this.passTxt.Size = new System.Drawing.Size(111, 20);
            this.passTxt.TabIndex = 3;
            this.passTxt.Text = "strongPassword";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(83, 26);
            this.userTxt.Name = "userTxt";
            this.userTxt.ReadOnly = true;
            this.userTxt.Size = new System.Drawing.Size(111, 20);
            this.userTxt.TabIndex = 0;
            this.userTxt.Text = "username.login";
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(432, 175);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(75, 23);
            this.uploadBtn.TabIndex = 1;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SharepointUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 199);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "SharepointUpload";
            this.Text = "SharepointUpload";
            this.Load += new System.EventHandler(this.SharepointUpload_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pathTxt;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.Button pathBtn;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox domainTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox linkTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox folderTxt;
    }
}

