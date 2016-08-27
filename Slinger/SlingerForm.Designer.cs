namespace Slinger
{
    partial class SlingerForm
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
            if(disposing && (components != null))
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
            this.buttonChooseFile = new System.Windows.Forms.Button();
            this.textBoxHashTarget = new System.Windows.Forms.TextBox();
            this.buttonUncheckAll = new System.Windows.Forms.Button();
            this.buttonCheckAll = new System.Windows.Forms.Button();
            this.checkBoxRipeMd160 = new System.Windows.Forms.CheckBox();
            this.textBoxRipeMd160 = new System.Windows.Forms.TextBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxMd5 = new System.Windows.Forms.TextBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxSha512 = new System.Windows.Forms.CheckBox();
            this.checkBoxSha384 = new System.Windows.Forms.CheckBox();
            this.checkBoxSha256 = new System.Windows.Forms.CheckBox();
            this.textBoxSha384 = new System.Windows.Forms.TextBox();
            this.textBoxSha256 = new System.Windows.Forms.TextBox();
            this.textBoxSha1 = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.checkBoxSha1 = new System.Windows.Forms.CheckBox();
            this.checkBoxMd5 = new System.Windows.Forms.CheckBox();
            this.textBoxSha512 = new System.Windows.Forms.TextBox();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.groupBox1.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonChooseFile);
            this.groupBox1.Controls.Add(this.textBoxHashTarget);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 55);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Or String To Hash";
            // 
            // buttonChooseFile
            // 
            this.buttonChooseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChooseFile.Location = new System.Drawing.Point(832, 17);
            this.buttonChooseFile.Name = "buttonChooseFile";
            this.buttonChooseFile.Size = new System.Drawing.Size(75, 23);
            this.buttonChooseFile.TabIndex = 1;
            this.buttonChooseFile.Text = "Choose File";
            this.buttonChooseFile.UseVisualStyleBackColor = true;
            this.buttonChooseFile.Click += new System.EventHandler(this.ButtonChooseFileClick);
            // 
            // textBoxHashTarget
            // 
            this.textBoxHashTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHashTarget.Location = new System.Drawing.Point(6, 19);
            this.textBoxHashTarget.Name = "textBoxHashTarget";
            this.textBoxHashTarget.Size = new System.Drawing.Size(820, 20);
            this.textBoxHashTarget.TabIndex = 0;
            // 
            // buttonUncheckAll
            // 
            this.buttonUncheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUncheckAll.Location = new System.Drawing.Point(93, 259);
            this.buttonUncheckAll.Name = "buttonUncheckAll";
            this.buttonUncheckAll.Size = new System.Drawing.Size(75, 23);
            this.buttonUncheckAll.TabIndex = 38;
            this.buttonUncheckAll.Text = "Uncheck All";
            this.buttonUncheckAll.UseVisualStyleBackColor = true;
            this.buttonUncheckAll.Click += new System.EventHandler(this.ButtonUncheckAllClick);
            // 
            // buttonCheckAll
            // 
            this.buttonCheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCheckAll.Location = new System.Drawing.Point(12, 259);
            this.buttonCheckAll.Name = "buttonCheckAll";
            this.buttonCheckAll.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckAll.TabIndex = 37;
            this.buttonCheckAll.Text = "Check All";
            this.buttonCheckAll.UseVisualStyleBackColor = true;
            this.buttonCheckAll.Click += new System.EventHandler(this.ButtonCheckAllClick);
            // 
            // checkBoxRipeMd160
            // 
            this.checkBoxRipeMd160.AutoSize = true;
            this.checkBoxRipeMd160.Checked = true;
            this.checkBoxRipeMd160.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRipeMd160.Location = new System.Drawing.Point(12, 231);
            this.checkBoxRipeMd160.Name = "checkBoxRipeMd160";
            this.checkBoxRipeMd160.Size = new System.Drawing.Size(86, 17);
            this.checkBoxRipeMd160.TabIndex = 36;
            this.checkBoxRipeMd160.Text = "RIPEMD160";
            this.checkBoxRipeMd160.UseVisualStyleBackColor = true;
            // 
            // textBoxRipeMd160
            // 
            this.textBoxRipeMd160.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRipeMd160.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxRipeMd160.Location = new System.Drawing.Point(104, 229);
            this.textBoxRipeMd160.Name = "textBoxRipeMd160";
            this.textBoxRipeMd160.ReadOnly = true;
            this.textBoxRipeMd160.Size = new System.Drawing.Size(826, 20);
            this.textBoxRipeMd160.TabIndex = 35;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // textBoxMd5
            // 
            this.textBoxMd5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMd5.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxMd5.Location = new System.Drawing.Point(104, 98);
            this.textBoxMd5.Name = "textBoxMd5";
            this.textBoxMd5.ReadOnly = true;
            this.textBoxMd5.Size = new System.Drawing.Size(826, 20);
            this.textBoxMd5.TabIndex = 25;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // checkBoxSha512
            // 
            this.checkBoxSha512.AutoSize = true;
            this.checkBoxSha512.Checked = true;
            this.checkBoxSha512.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSha512.Location = new System.Drawing.Point(12, 205);
            this.checkBoxSha512.Name = "checkBoxSha512";
            this.checkBoxSha512.Size = new System.Drawing.Size(66, 17);
            this.checkBoxSha512.TabIndex = 34;
            this.checkBoxSha512.Text = "SHA512";
            this.checkBoxSha512.UseVisualStyleBackColor = true;
            // 
            // checkBoxSha384
            // 
            this.checkBoxSha384.AutoSize = true;
            this.checkBoxSha384.Checked = true;
            this.checkBoxSha384.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSha384.Location = new System.Drawing.Point(12, 179);
            this.checkBoxSha384.Name = "checkBoxSha384";
            this.checkBoxSha384.Size = new System.Drawing.Size(66, 17);
            this.checkBoxSha384.TabIndex = 33;
            this.checkBoxSha384.Text = "SHA384";
            this.checkBoxSha384.UseVisualStyleBackColor = true;
            // 
            // checkBoxSha256
            // 
            this.checkBoxSha256.AutoSize = true;
            this.checkBoxSha256.Checked = true;
            this.checkBoxSha256.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSha256.Location = new System.Drawing.Point(12, 153);
            this.checkBoxSha256.Name = "checkBoxSha256";
            this.checkBoxSha256.Size = new System.Drawing.Size(66, 17);
            this.checkBoxSha256.TabIndex = 32;
            this.checkBoxSha256.Text = "SHA256";
            this.checkBoxSha256.UseVisualStyleBackColor = true;
            // 
            // textBoxSha384
            // 
            this.textBoxSha384.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSha384.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSha384.Location = new System.Drawing.Point(104, 177);
            this.textBoxSha384.Name = "textBoxSha384";
            this.textBoxSha384.ReadOnly = true;
            this.textBoxSha384.Size = new System.Drawing.Size(826, 20);
            this.textBoxSha384.TabIndex = 28;
            // 
            // textBoxSha256
            // 
            this.textBoxSha256.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSha256.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSha256.Location = new System.Drawing.Point(104, 151);
            this.textBoxSha256.Name = "textBoxSha256";
            this.textBoxSha256.ReadOnly = true;
            this.textBoxSha256.Size = new System.Drawing.Size(826, 20);
            this.textBoxSha256.TabIndex = 27;
            // 
            // textBoxSha1
            // 
            this.textBoxSha1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSha1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSha1.Location = new System.Drawing.Point(104, 125);
            this.textBoxSha1.Name = "textBoxSha1";
            this.textBoxSha1.ReadOnly = true;
            this.textBoxSha1.Size = new System.Drawing.Size(826, 20);
            this.textBoxSha1.TabIndex = 26;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalculate.Location = new System.Drawing.Point(855, 259);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 24;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculateClick);
            // 
            // checkBoxSha1
            // 
            this.checkBoxSha1.AutoSize = true;
            this.checkBoxSha1.Checked = true;
            this.checkBoxSha1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSha1.Location = new System.Drawing.Point(12, 127);
            this.checkBoxSha1.Name = "checkBoxSha1";
            this.checkBoxSha1.Size = new System.Drawing.Size(54, 17);
            this.checkBoxSha1.TabIndex = 31;
            this.checkBoxSha1.Text = "SHA1";
            this.checkBoxSha1.UseVisualStyleBackColor = true;
            // 
            // checkBoxMd5
            // 
            this.checkBoxMd5.AutoSize = true;
            this.checkBoxMd5.Checked = true;
            this.checkBoxMd5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMd5.Location = new System.Drawing.Point(12, 101);
            this.checkBoxMd5.Name = "checkBoxMd5";
            this.checkBoxMd5.Size = new System.Drawing.Size(49, 17);
            this.checkBoxMd5.TabIndex = 30;
            this.checkBoxMd5.Text = "MD5";
            this.checkBoxMd5.UseVisualStyleBackColor = true;
            // 
            // textBoxSha512
            // 
            this.textBoxSha512.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSha512.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSha512.Location = new System.Drawing.Point(104, 203);
            this.textBoxSha512.Name = "textBoxSha512";
            this.textBoxSha512.ReadOnly = true;
            this.textBoxSha512.Size = new System.Drawing.Size(826, 20);
            this.textBoxSha512.TabIndex = 29;
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(942, 24);
            this.menuStripMain.TabIndex = 39;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // SlingerForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 288);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonUncheckAll);
            this.Controls.Add(this.buttonCheckAll);
            this.Controls.Add(this.checkBoxRipeMd160);
            this.Controls.Add(this.textBoxRipeMd160);
            this.Controls.Add(this.textBoxMd5);
            this.Controls.Add(this.checkBoxSha512);
            this.Controls.Add(this.checkBoxSha384);
            this.Controls.Add(this.checkBoxSha256);
            this.Controls.Add(this.textBoxSha384);
            this.Controls.Add(this.textBoxSha256);
            this.Controls.Add(this.textBoxSha1);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.checkBoxSha1);
            this.Controls.Add(this.checkBoxMd5);
            this.Controls.Add(this.textBoxSha512);
            this.Controls.Add(this.menuStripMain);
            this.MaximumSize = new System.Drawing.Size(1000, 327);
            this.MinimumSize = new System.Drawing.Size(535, 326);
            this.Name = "SlingerForm";
            this.Text = "Slinger";
            this.Load += new System.EventHandler(this.SlingerFormLoad);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SlingerFormDragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SlingerFormDragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonChooseFile;
        private System.Windows.Forms.TextBox textBoxHashTarget;
        private System.Windows.Forms.Button buttonUncheckAll;
        private System.Windows.Forms.Button buttonCheckAll;
        private System.Windows.Forms.CheckBox checkBoxRipeMd160;
        private System.Windows.Forms.TextBox textBoxRipeMd160;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxMd5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxSha512;
        private System.Windows.Forms.CheckBox checkBoxSha384;
        private System.Windows.Forms.CheckBox checkBoxSha256;
        private System.Windows.Forms.TextBox textBoxSha384;
        private System.Windows.Forms.TextBox textBoxSha256;
        private System.Windows.Forms.TextBox textBoxSha1;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.CheckBox checkBoxSha1;
        private System.Windows.Forms.CheckBox checkBoxMd5;
        private System.Windows.Forms.TextBox textBoxSha512;
        private System.Windows.Forms.MenuStrip menuStripMain;
    }
}

