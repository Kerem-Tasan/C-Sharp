namespace TheModul
{
    partial class Anasayfa
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
            this.modulIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kılavuzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kılavuzDurumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şirketİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resimİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mdi_Panel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modulIslemleriToolStripMenuItem,
            this.modelToolStripMenuItem,
            this.kılavuzToolStripMenuItem,
            this.kılavuzDurumToolStripMenuItem,
            this.şirketİşlemleriToolStripMenuItem,
            this.resimİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1033, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modulIslemleriToolStripMenuItem
            // 
            this.modulIslemleriToolStripMenuItem.Name = "modulIslemleriToolStripMenuItem";
            this.modulIslemleriToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.modulIslemleriToolStripMenuItem.Text = "Modül İşlemleri";
            this.modulIslemleriToolStripMenuItem.Click += new System.EventHandler(this.modulIslemleriToolStripMenuItem_Click);
            // 
            // modelToolStripMenuItem
            // 
            this.modelToolStripMenuItem.Name = "modelToolStripMenuItem";
            this.modelToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.modelToolStripMenuItem.Text = "Modül İçerik ";
            this.modelToolStripMenuItem.Click += new System.EventHandler(this.modelToolStripMenuItem_Click);
            // 
            // kılavuzToolStripMenuItem
            // 
            this.kılavuzToolStripMenuItem.Name = "kılavuzToolStripMenuItem";
            this.kılavuzToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.kılavuzToolStripMenuItem.Text = "Kılavuz";
            this.kılavuzToolStripMenuItem.Click += new System.EventHandler(this.kılavuzToolStripMenuItem_Click);
            // 
            // kılavuzDurumToolStripMenuItem
            // 
            this.kılavuzDurumToolStripMenuItem.Name = "kılavuzDurumToolStripMenuItem";
            this.kılavuzDurumToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.kılavuzDurumToolStripMenuItem.Text = "Kılavuz Durum";
            this.kılavuzDurumToolStripMenuItem.Click += new System.EventHandler(this.kılavuzDurumToolStripMenuItem_Click);
            // 
            // şirketİşlemleriToolStripMenuItem
            // 
            this.şirketİşlemleriToolStripMenuItem.Name = "şirketİşlemleriToolStripMenuItem";
            this.şirketİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.şirketİşlemleriToolStripMenuItem.Text = "Şirket İşlemleri";
            this.şirketİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.şirketİşlemleriToolStripMenuItem_Click);
            // 
            // resimİşlemleriToolStripMenuItem
            // 
            this.resimİşlemleriToolStripMenuItem.Name = "resimİşlemleriToolStripMenuItem";
            this.resimİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.resimİşlemleriToolStripMenuItem.Text = "Resim İşlemleri";
            this.resimİşlemleriToolStripMenuItem.Visible = false;
            this.resimİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.resimİşlemleriToolStripMenuItem_Click);
            // 
            // Mdi_Panel
            // 
            this.Mdi_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mdi_Panel.Location = new System.Drawing.Point(0, 28);
            this.Mdi_Panel.Name = "Mdi_Panel";
            this.Mdi_Panel.Size = new System.Drawing.Size(1033, 498);
            this.Mdi_Panel.TabIndex = 2;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 526);
            this.Controls.Add(this.Mdi_Panel);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modulIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kılavuzToolStripMenuItem;
        private System.Windows.Forms.Panel Mdi_Panel;
        private System.Windows.Forms.ToolStripMenuItem modelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kılavuzDurumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şirketİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resimİşlemleriToolStripMenuItem;
    }
}