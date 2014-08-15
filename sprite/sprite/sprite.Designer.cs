namespace WindowsFormsApplication1
{
    partial class sprite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sprite));
            this.btnGo = new System.Windows.Forms.Button();
            this.fbdDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.rbtnVertical = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnHorizontal = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.llMail = new System.Windows.Forms.LinkLabel();
            this.chkCompress = new System.Windows.Forms.CheckBox();
            this.btnCompress = new System.Windows.Forms.Button();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(290, 113);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(200, 23);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.TabIndex = 1;
            this.btnBrowser.Text = "Browser...";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 25);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(176, 21);
            this.txtPath.TabIndex = 2;
            // 
            // rbtnVertical
            // 
            this.rbtnVertical.AutoSize = true;
            this.rbtnVertical.Checked = true;
            this.rbtnVertical.Location = new System.Drawing.Point(6, 20);
            this.rbtnVertical.Name = "rbtnVertical";
            this.rbtnVertical.Size = new System.Drawing.Size(71, 16);
            this.rbtnVertical.TabIndex = 4;
            this.rbtnVertical.TabStop = true;
            this.rbtnVertical.Text = "Vertical";
            this.rbtnVertical.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnHorizontal);
            this.groupBox1.Controls.Add(this.rbtnVertical);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 47);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sprite Direction";
            // 
            // rbtnHorizontal
            // 
            this.rbtnHorizontal.AutoSize = true;
            this.rbtnHorizontal.Location = new System.Drawing.Point(83, 20);
            this.rbtnHorizontal.Name = "rbtnHorizontal";
            this.rbtnHorizontal.Size = new System.Drawing.Size(83, 16);
            this.rbtnHorizontal.TabIndex = 5;
            this.rbtnHorizontal.Text = "Horizontal";
            this.rbtnHorizontal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "© 2014 by";
            // 
            // llMail
            // 
            this.llMail.AutoSize = true;
            this.llMail.Location = new System.Drawing.Point(329, 158);
            this.llMail.Name = "llMail";
            this.llMail.Size = new System.Drawing.Size(47, 12);
            this.llMail.TabIndex = 7;
            this.llMail.TabStop = true;
            this.llMail.Text = "wuqiang";
            this.llMail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llMail_LinkClicked);
            // 
            // chkCompress
            // 
            this.chkCompress.AutoSize = true;
            this.chkCompress.Location = new System.Drawing.Point(290, 73);
            this.chkCompress.Name = "chkCompress";
            this.chkCompress.Size = new System.Drawing.Size(72, 16);
            this.chkCompress.TabIndex = 8;
            this.chkCompress.Text = "Compress";
            this.chkCompress.UseVisualStyleBackColor = true;
            // 
            // btnCompress
            // 
            this.btnCompress.Location = new System.Drawing.Point(290, 23);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(75, 23);
            this.btnCompress.TabIndex = 9;
            this.btnCompress.Text = "Compress";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(200, 73);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(84, 16);
            this.chkAll.TabIndex = 10;
            this.chkAll.Text = "All in one";
            this.chkAll.UseVisualStyleBackColor = true;
            // 
            // sprite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 179);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.chkCompress);
            this.Controls.Add(this.llMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.btnGo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "sprite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sprite";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.sprite_HelpButtonClicked);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.FolderBrowserDialog fbdDialog;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.RadioButton rbtnVertical;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnHorizontal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llMail;
        private System.Windows.Forms.CheckBox chkCompress;
        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.CheckBox chkAll;
    }
}

