namespace WindowsFormsApp3
{
    partial class frm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtx = new System.Windows.Forms.RichTextBox();
            this.fontAndColerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selaectFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selactColerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.fontAndColerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.saveToolStripMenuItem.Text = "Save AS";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(145, 26);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(142, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selToolStripMenuItem,
            this.copeToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pastToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // selToolStripMenuItem
            // 
            this.selToolStripMenuItem.Name = "selToolStripMenuItem";
            this.selToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.selToolStripMenuItem.Text = "Select All";
            this.selToolStripMenuItem.Click += new System.EventHandler(this.selToolStripMenuItem_Click);
            // 
            // copeToolStripMenuItem
            // 
            this.copeToolStripMenuItem.Name = "copeToolStripMenuItem";
            this.copeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.copeToolStripMenuItem.Text = "Copy";
            this.copeToolStripMenuItem.Click += new System.EventHandler(this.copeToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cutToolStripMenuItem.Text = "cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pastToolStripMenuItem
            // 
            this.pastToolStripMenuItem.Name = "pastToolStripMenuItem";
            this.pastToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pastToolStripMenuItem.Text = "past";
            this.pastToolStripMenuItem.Click += new System.EventHandler(this.pastToolStripMenuItem_Click);
            // 
            // rtx
            // 
            this.rtx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtx.Location = new System.Drawing.Point(0, 28);
            this.rtx.Name = "rtx";
            this.rtx.Size = new System.Drawing.Size(800, 422);
            this.rtx.TabIndex = 1;
            this.rtx.Text = "";
            // 
            // fontAndColerToolStripMenuItem
            // 
            this.fontAndColerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selaectFontToolStripMenuItem,
            this.selactColerToolStripMenuItem});
            this.fontAndColerToolStripMenuItem.Name = "fontAndColerToolStripMenuItem";
            this.fontAndColerToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.fontAndColerToolStripMenuItem.Text = "Font and coler";
            // 
            // selaectFontToolStripMenuItem
            // 
            this.selaectFontToolStripMenuItem.Name = "selaectFontToolStripMenuItem";
            this.selaectFontToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.selaectFontToolStripMenuItem.Text = "selaect font";
            this.selaectFontToolStripMenuItem.Click += new System.EventHandler(this.selaectFontToolStripMenuItem_Click);
            // 
            // selactColerToolStripMenuItem
            // 
            this.selactColerToolStripMenuItem.Name = "selactColerToolStripMenuItem";
            this.selactColerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.selactColerToolStripMenuItem.Text = "selact coler";
            this.selactColerToolStripMenuItem.Click += new System.EventHandler(this.selactColerToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtx);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm";
            this.Text = "MY txt editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pastToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtx;
        private System.Windows.Forms.ToolStripMenuItem fontAndColerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selaectFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selactColerToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

