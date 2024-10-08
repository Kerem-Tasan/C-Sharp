namespace TaskApplication
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dnemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dURToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IslemMenuStrip = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullaniciTblTableAdapter1 = new TaskApplication.GorevDSTableAdapters.KullaniciTblTableAdapter();
            this.Mdi_Panel = new System.Windows.Forms.Panel();
            this.görevDurumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.IslemMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dnemeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 28);
            // 
            // dnemeToolStripMenuItem
            // 
            this.dnemeToolStripMenuItem.Name = "dnemeToolStripMenuItem";
            this.dnemeToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.dnemeToolStripMenuItem.Text = "Dneme";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dURToolStripMenuItem,
            this.kullanıcıİşlemleriToolStripMenuItem,
            this.görevDurumToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 33);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1275, 31);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dURToolStripMenuItem
            // 
            this.dURToolStripMenuItem.Name = "dURToolStripMenuItem";
            this.dURToolStripMenuItem.Size = new System.Drawing.Size(88, 27);
            this.dURToolStripMenuItem.Text = "Görevler";
            this.dURToolStripMenuItem.Click += new System.EventHandler(this.dURToolStripMenuItem_Click);
            // 
            // kullanıcıİşlemleriToolStripMenuItem
            // 
            this.kullanıcıİşlemleriToolStripMenuItem.Name = "kullanıcıİşlemleriToolStripMenuItem";
            this.kullanıcıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(155, 27);
            this.kullanıcıİşlemleriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            this.kullanıcıİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıİşlemleriToolStripMenuItem_Click);
            // 
            // IslemMenuStrip
            // 
            this.IslemMenuStrip.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.IslemMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.IslemMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem});
            this.IslemMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.IslemMenuStrip.Name = "IslemMenuStrip";
            this.IslemMenuStrip.Size = new System.Drawing.Size(1275, 33);
            this.IslemMenuStrip.TabIndex = 4;
            this.IslemMenuStrip.Text = "menuStrip2";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // kullaniciTblTableAdapter1
            // 
            this.kullaniciTblTableAdapter1.ClearBeforeFill = true;
            // 
            // Mdi_Panel
            // 
            this.Mdi_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mdi_Panel.Location = new System.Drawing.Point(0, 64);
            this.Mdi_Panel.Name = "Mdi_Panel";
            this.Mdi_Panel.Size = new System.Drawing.Size(1275, 467);
            this.Mdi_Panel.TabIndex = 6;
            // 
            // görevDurumToolStripMenuItem
            // 
            this.görevDurumToolStripMenuItem.Name = "görevDurumToolStripMenuItem";
            this.görevDurumToolStripMenuItem.Size = new System.Drawing.Size(132, 27);
            this.görevDurumToolStripMenuItem.Text = "Görev Durum ";
            this.görevDurumToolStripMenuItem.Click += new System.EventHandler(this.görevDurumToolStripMenuItem_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 531);
            this.Controls.Add(this.Mdi_Panel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.IslemMenuStrip);
            this.IsMdiContainer = true;
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.IslemMenuStrip.ResumeLayout(false);
            this.IslemMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dnemeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dURToolStripMenuItem;
        private System.Windows.Forms.MenuStrip IslemMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private GorevDSTableAdapters.KullaniciTblTableAdapter kullaniciTblTableAdapter1;
        private System.Windows.Forms.Panel Mdi_Panel;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görevDurumToolStripMenuItem;
    }
}