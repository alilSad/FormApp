
namespace WindowsFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.newTS = new System.Windows.Forms.ToolStripMenuItem();
            this.openTS = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTS = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsTS = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutTS = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.cutTS = new System.Windows.Forms.ToolStripMenuItem();
            this.copyTS = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteTS = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newTS2 = new System.Windows.Forms.ToolStripButton();
            this.openTS2 = new System.Windows.Forms.ToolStripButton();
            this.saveTS2 = new System.Windows.Forms.ToolStripButton();
            this.saveAsTS2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.boldTS = new System.Windows.Forms.ToolStripButton();
            this.italicTS = new System.Windows.Forms.ToolStripButton();
            this.underlineTS = new System.Windows.Forms.ToolStripButton();
            this.fontsizeTS = new System.Windows.Forms.ToolStripComboBox();
            this.aboutTS2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.usernameLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.copyTS2 = new System.Windows.Forms.ToolStripButton();
            this.pasteTS2 = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStrip,
            this.editToolStrip,
            this.helpToolStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1227, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStrip
            // 
            this.fileToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTS,
            this.openTS,
            this.saveTS,
            this.saveAsTS,
            this.logOutTS});
            this.fileToolStrip.Name = "fileToolStrip";
            this.fileToolStrip.Size = new System.Drawing.Size(37, 20);
            this.fileToolStrip.Text = "File";
            // 
            // newTS
            // 
            this.newTS.Image = ((System.Drawing.Image)(resources.GetObject("newTS.Image")));
            this.newTS.Name = "newTS";
            this.newTS.Size = new System.Drawing.Size(117, 22);
            this.newTS.Text = "New";
            this.newTS.Click += new System.EventHandler(this.newTS_Click);
            // 
            // openTS
            // 
            this.openTS.Image = ((System.Drawing.Image)(resources.GetObject("openTS.Image")));
            this.openTS.Name = "openTS";
            this.openTS.Size = new System.Drawing.Size(117, 22);
            this.openTS.Text = "Open";
            // 
            // saveTS
            // 
            this.saveTS.Image = ((System.Drawing.Image)(resources.GetObject("saveTS.Image")));
            this.saveTS.Name = "saveTS";
            this.saveTS.Size = new System.Drawing.Size(117, 22);
            this.saveTS.Text = "Save";
            // 
            // saveAsTS
            // 
            this.saveAsTS.Image = ((System.Drawing.Image)(resources.GetObject("saveAsTS.Image")));
            this.saveAsTS.Name = "saveAsTS";
            this.saveAsTS.Size = new System.Drawing.Size(117, 22);
            this.saveAsTS.Text = "Save As";
            // 
            // logOutTS
            // 
            this.logOutTS.Image = ((System.Drawing.Image)(resources.GetObject("logOutTS.Image")));
            this.logOutTS.Name = "logOutTS";
            this.logOutTS.Size = new System.Drawing.Size(117, 22);
            this.logOutTS.Text = "Log Out";
            // 
            // editToolStrip
            // 
            this.editToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutTS,
            this.copyTS,
            this.pasteTS});
            this.editToolStrip.Name = "editToolStrip";
            this.editToolStrip.Size = new System.Drawing.Size(39, 20);
            this.editToolStrip.Text = "Edit";
            // 
            // cutTS
            // 
            this.cutTS.Image = ((System.Drawing.Image)(resources.GetObject("cutTS.Image")));
            this.cutTS.Name = "cutTS";
            this.cutTS.Size = new System.Drawing.Size(180, 22);
            this.cutTS.Text = "Cut";
            // 
            // copyTS
            // 
            this.copyTS.Image = ((System.Drawing.Image)(resources.GetObject("copyTS.Image")));
            this.copyTS.Name = "copyTS";
            this.copyTS.Size = new System.Drawing.Size(180, 22);
            this.copyTS.Text = "Copy";
            // 
            // pasteTS
            // 
            this.pasteTS.Image = ((System.Drawing.Image)(resources.GetObject("pasteTS.Image")));
            this.pasteTS.Name = "pasteTS";
            this.pasteTS.Size = new System.Drawing.Size(180, 22);
            this.pasteTS.Text = "Paste";
            // 
            // helpToolStrip
            // 
            this.helpToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTS});
            this.helpToolStrip.Name = "helpToolStrip";
            this.helpToolStrip.Size = new System.Drawing.Size(44, 20);
            this.helpToolStrip.Text = "Help";
            // 
            // aboutTS
            // 
            this.aboutTS.Image = ((System.Drawing.Image)(resources.GetObject("aboutTS.Image")));
            this.aboutTS.Name = "aboutTS";
            this.aboutTS.Size = new System.Drawing.Size(107, 22);
            this.aboutTS.Text = "About";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTS2,
            this.openTS2,
            this.saveTS2,
            this.saveAsTS2,
            this.toolStripSeparator1,
            this.boldTS,
            this.italicTS,
            this.underlineTS,
            this.fontsizeTS,
            this.aboutTS2,
            this.toolStripSeparator2,
            this.usernameLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1227, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newTS2
            // 
            this.newTS2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newTS2.Image = ((System.Drawing.Image)(resources.GetObject("newTS2.Image")));
            this.newTS2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newTS2.Name = "newTS2";
            this.newTS2.Size = new System.Drawing.Size(23, 22);
            // 
            // openTS2
            // 
            this.openTS2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openTS2.Image = ((System.Drawing.Image)(resources.GetObject("openTS2.Image")));
            this.openTS2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openTS2.Name = "openTS2";
            this.openTS2.Size = new System.Drawing.Size(23, 22);
            // 
            // saveTS2
            // 
            this.saveTS2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveTS2.Image = ((System.Drawing.Image)(resources.GetObject("saveTS2.Image")));
            this.saveTS2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveTS2.Name = "saveTS2";
            this.saveTS2.Size = new System.Drawing.Size(23, 22);
            // 
            // saveAsTS2
            // 
            this.saveAsTS2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveAsTS2.Image = ((System.Drawing.Image)(resources.GetObject("saveAsTS2.Image")));
            this.saveAsTS2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsTS2.Name = "saveAsTS2";
            this.saveAsTS2.Size = new System.Drawing.Size(23, 22);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // boldTS
            // 
            this.boldTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldTS.Image = ((System.Drawing.Image)(resources.GetObject("boldTS.Image")));
            this.boldTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldTS.Name = "boldTS";
            this.boldTS.Size = new System.Drawing.Size(23, 22);
            // 
            // italicTS
            // 
            this.italicTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicTS.Image = ((System.Drawing.Image)(resources.GetObject("italicTS.Image")));
            this.italicTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicTS.Name = "italicTS";
            this.italicTS.Size = new System.Drawing.Size(23, 22);
            // 
            // underlineTS
            // 
            this.underlineTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underlineTS.Image = ((System.Drawing.Image)(resources.GetObject("underlineTS.Image")));
            this.underlineTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineTS.Name = "underlineTS";
            this.underlineTS.Size = new System.Drawing.Size(23, 22);
            // 
            // fontsizeTS
            // 
            this.fontsizeTS.Name = "fontsizeTS";
            this.fontsizeTS.Size = new System.Drawing.Size(121, 25);
            this.fontsizeTS.Click += new System.EventHandler(this.fontsizeTS_Click);
            // 
            // aboutTS2
            // 
            this.aboutTS2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aboutTS2.Image = ((System.Drawing.Image)(resources.GetObject("aboutTS2.Image")));
            this.aboutTS2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutTS2.Name = "aboutTS2";
            this.aboutTS2.Size = new System.Drawing.Size(23, 22);
            this.aboutTS2.Text = "toolStripButton8";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(66, 22);
            this.usernameLabel.Text = "Username: ";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.copyTS2,
            this.pasteTS2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 49);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(24, 593);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(21, 20);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "cutTS2";
            // 
            // copyTS2
            // 
            this.copyTS2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyTS2.Image = ((System.Drawing.Image)(resources.GetObject("copyTS2.Image")));
            this.copyTS2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyTS2.Name = "copyTS2";
            this.copyTS2.Size = new System.Drawing.Size(21, 20);
            this.copyTS2.Text = "toolStripButton2";
            // 
            // pasteTS2
            // 
            this.pasteTS2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteTS2.Image = ((System.Drawing.Image)(resources.GetObject("pasteTS2.Image")));
            this.pasteTS2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteTS2.Name = "pasteTS2";
            this.pasteTS2.Size = new System.Drawing.Size(21, 20);
            this.pasteTS2.Text = "toolStripButton3";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(28, 53);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(951, 577);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 642);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStrip;
        private System.Windows.Forms.ToolStripMenuItem newTS;
        private System.Windows.Forms.ToolStripMenuItem editToolStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStrip;
        private System.Windows.Forms.ToolStripMenuItem openTS;
        private System.Windows.Forms.ToolStripMenuItem saveTS;
        private System.Windows.Forms.ToolStripMenuItem saveAsTS;
        private System.Windows.Forms.ToolStripMenuItem logOutTS;
        private System.Windows.Forms.ToolStripMenuItem cutTS;
        private System.Windows.Forms.ToolStripMenuItem copyTS;
        private System.Windows.Forms.ToolStripMenuItem pasteTS;
        private System.Windows.Forms.ToolStripMenuItem aboutTS;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newTS2;
        private System.Windows.Forms.ToolStripButton openTS2;
        private System.Windows.Forms.ToolStripButton saveTS2;
        private System.Windows.Forms.ToolStripButton saveAsTS2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton boldTS;
        private System.Windows.Forms.ToolStripButton italicTS;
        private System.Windows.Forms.ToolStripButton underlineTS;
        private System.Windows.Forms.ToolStripComboBox fontsizeTS;
        private System.Windows.Forms.ToolStripButton aboutTS2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton copyTS2;
        private System.Windows.Forms.ToolStripButton pasteTS2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.ToolStripLabel usernameLabel;
    }
}