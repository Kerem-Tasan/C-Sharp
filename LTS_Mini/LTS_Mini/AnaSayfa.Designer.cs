namespace LTS_Mini
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.MdiPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yeniİstekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.işlemPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.isteklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istekTanımlarıToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._LTS_MiniDataSet1 = new LTS_Mini._LTS_MiniDataSet();
            this.ıstekTbl1TableAdapter1 = new LTS_Mini._LTS_MiniDataSetTableAdapters.IstekTbl1TableAdapter();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._LTS_MiniDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // MdiPanel
            // 
            this.MdiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MdiPanel.Location = new System.Drawing.Point(0, 84);
            this.MdiPanel.Name = "MdiPanel";
            this.MdiPanel.Size = new System.Drawing.Size(1247, 616);
            this.MdiPanel.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniİstekToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.kapatToolStripMenuItem,
            this.silToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 56);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1247, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yeniİstekToolStripMenuItem
            // 
            this.yeniİstekToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yeniİstekToolStripMenuItem.Image")));
            this.yeniİstekToolStripMenuItem.Name = "yeniİstekToolStripMenuItem";
            this.yeniİstekToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.yeniİstekToolStripMenuItem.Text = "Yeni İstek";
            this.yeniİstekToolStripMenuItem.Click += new System.EventHandler(this.yeniİstekToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kaydetToolStripMenuItem.Image")));
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.kaydetToolStripMenuItem.Text = "Güncelle";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kapatToolStripMenuItem.Image")));
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("silToolStripMenuItem.Image")));
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Visible = false;
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemPaneliToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 28);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1247, 28);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // işlemPaneliToolStripMenuItem
            // 
            this.işlemPaneliToolStripMenuItem.Name = "işlemPaneliToolStripMenuItem";
            this.işlemPaneliToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.işlemPaneliToolStripMenuItem.Text = "İşlem Paneli";
            // 
            // menuStrip3
            // 
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.isteklerToolStripMenuItem,
            this.kullanıcıİşlemleriToolStripMenuItem,
            this.istekTanımlarıToolStripMenuItem1});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(1247, 28);
            this.menuStrip3.TabIndex = 8;
            this.menuStrip3.Text = "menuStrip3";
            this.menuStrip3.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip3_ItemClicked);
            // 
            // isteklerToolStripMenuItem
            // 
            this.isteklerToolStripMenuItem.Name = "isteklerToolStripMenuItem";
            this.isteklerToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.isteklerToolStripMenuItem.Text = "İstekler";
            this.isteklerToolStripMenuItem.Click += new System.EventHandler(this.isteklerToolStripMenuItem_Click);
            // 
            // kullanıcıİşlemleriToolStripMenuItem
            // 
            this.kullanıcıİşlemleriToolStripMenuItem.Name = "kullanıcıİşlemleriToolStripMenuItem";
            this.kullanıcıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.kullanıcıİşlemleriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            this.kullanıcıİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıİşlemleriToolStripMenuItem_Click);
            // 
            // istekTanımlarıToolStripMenuItem1
            // 
            this.istekTanımlarıToolStripMenuItem1.Name = "istekTanımlarıToolStripMenuItem1";
            this.istekTanımlarıToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.istekTanımlarıToolStripMenuItem1.Text = "İstek Tanımları";
            this.istekTanımlarıToolStripMenuItem1.Click += new System.EventHandler(this.istekTanımlarıToolStripMenuItem1_Click);
            // 
            // _LTS_MiniDataSet1
            // 
            this._LTS_MiniDataSet1.DataSetName = "_LTS_MiniDataSet";
            this._LTS_MiniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ıstekTbl1TableAdapter1
            // 
            this.ıstekTbl1TableAdapter1.ClearBeforeFill = true;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 680);
            this.Controls.Add(this.MdiPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\"";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._LTS_MiniDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem işlemPaneliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniİstekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isteklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istekTanımlarıToolStripMenuItem1;
        public System.Windows.Forms.MenuStrip menuStrip3;
        public System.Windows.Forms.Panel MdiPanel;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private _LTS_MiniDataSet _LTS_MiniDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private _LTS_MiniDataSetTableAdapters.IstekTbl1TableAdapter ıstekTbl1TableAdapter1;
    }
}