namespace TheModul
{
    partial class Kilavuz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kilavuz));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.KaydetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SirketMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.KilavuzGrid = new System.Windows.Forms.DataGridView();
            this.bs_Kilavuz = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Modul = new TheModul.ModulDBDataSet();
            this.KilavuzTA = new TheModul.ModulDBDataSetTableAdapters.KilavuzTblTableAdapter();
            this.bs_Sirket = new System.Windows.Forms.BindingSource(this.components);
            this.Sirket_TA = new TheModul.ModulDBDataSetTableAdapters.SirketTblTableAdapter();
            this.LogKilavuz_TableAdapter = new TheModul.ModulDBDataSetTableAdapters.KilavuzLogTblTableAdapter();
            this.Tbl_SelectedSirket = new TheModul.ModulDBDataSetTableAdapters.SelectedSirketTableAdapter();
            this.ctx_Strip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resimlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IDData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mIcerikIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IcerikAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modulIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Onay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KilavuzGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Kilavuz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Modul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Sirket)).BeginInit();
            this.ctx_Strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KaydetMenuItem,
            this.SirketMenuItem,
            this.yToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1275, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // KaydetMenuItem
            // 
            this.KaydetMenuItem.Name = "KaydetMenuItem";
            this.KaydetMenuItem.Size = new System.Drawing.Size(69, 24);
            this.KaydetMenuItem.Text = "Kaydet";
            this.KaydetMenuItem.Click += new System.EventHandler(this.KaydetMenuItem_Click);
            // 
            // SirketMenuItem
            // 
            this.SirketMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bOŞToolStripMenuItem});
            this.SirketMenuItem.Name = "SirketMenuItem";
            this.SirketMenuItem.Size = new System.Drawing.Size(60, 24);
            this.SirketMenuItem.Text = "Şirket";
            this.SirketMenuItem.Click += new System.EventHandler(this.SirketMenuItem_Click);
            // 
            // bOŞToolStripMenuItem
            // 
            this.bOŞToolStripMenuItem.Name = "bOŞToolStripMenuItem";
            this.bOŞToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.bOŞToolStripMenuItem.Text = "BOŞ";
            this.bOŞToolStripMenuItem.Visible = false;
            // 
            // yToolStripMenuItem
            // 
            this.yToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yToolStripMenuItem.Image")));
            this.yToolStripMenuItem.Name = "yToolStripMenuItem";
            this.yToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.yToolStripMenuItem.Text = "Yenile";
            this.yToolStripMenuItem.Click += new System.EventHandler(this.yToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("resetToolStripMenuItem.Image")));
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(1118, 78);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(102, 21);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.Visible = false;
            // 
            // KilavuzGrid
            // 
            this.KilavuzGrid.AutoGenerateColumns = false;
            this.KilavuzGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KilavuzGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDData,
            this.mIcerikIDDataGridViewTextBoxColumn,
            this.IcerikAdi,
            this.modulIDDataGridViewTextBoxColumn,
            this.Adi,
            this.Onay,
            this.Aciklama,
            this.tarihDataGridViewTextBoxColumn});
            this.KilavuzGrid.ContextMenuStrip = this.ctx_Strip;
            this.KilavuzGrid.DataSource = this.bs_Kilavuz;
            this.KilavuzGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KilavuzGrid.Location = new System.Drawing.Point(0, 28);
            this.KilavuzGrid.Name = "KilavuzGrid";
            this.KilavuzGrid.RowHeadersWidth = 51;
            this.KilavuzGrid.RowTemplate.Height = 24;
            this.KilavuzGrid.Size = new System.Drawing.Size(1275, 422);
            this.KilavuzGrid.TabIndex = 2;
            this.KilavuzGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.KilavuzGrid_CellMouseClick);
            // 
            // bs_Kilavuz
            // 
            this.bs_Kilavuz.DataMember = "KilavuzTbl";
            this.bs_Kilavuz.DataSource = this.ds_Modul;
            // 
            // ds_Modul
            // 
            this.ds_Modul.DataSetName = "ModulDBDataSet";
            this.ds_Modul.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KilavuzTA
            // 
            this.KilavuzTA.ClearBeforeFill = true;
            // 
            // bs_Sirket
            // 
            this.bs_Sirket.DataSource = this.ds_Modul;
            this.bs_Sirket.Position = 0;
            // 
            // Sirket_TA
            // 
            this.Sirket_TA.ClearBeforeFill = true;
            // 
            // LogKilavuz_TableAdapter
            // 
            this.LogKilavuz_TableAdapter.ClearBeforeFill = true;
            // 
            // Tbl_SelectedSirket
            // 
            this.Tbl_SelectedSirket.ClearBeforeFill = true;
            // 
            // ctx_Strip
            // 
            this.ctx_Strip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctx_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resimlerToolStripMenuItem});
            this.ctx_Strip.Name = "ctx_Strip";
            this.ctx_Strip.Size = new System.Drawing.Size(136, 28);
            // 
            // resimlerToolStripMenuItem
            // 
            this.resimlerToolStripMenuItem.Name = "resimlerToolStripMenuItem";
            this.resimlerToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.resimlerToolStripMenuItem.Text = "Resimler";
            this.resimlerToolStripMenuItem.Click += new System.EventHandler(this.resimlerToolStripMenuItem_Click);
            // 
            // IDData
            // 
            this.IDData.DataPropertyName = "ID";
            this.IDData.HeaderText = "ID";
            this.IDData.MinimumWidth = 6;
            this.IDData.Name = "IDData";
            this.IDData.Width = 45;
            // 
            // mIcerikIDDataGridViewTextBoxColumn
            // 
            this.mIcerikIDDataGridViewTextBoxColumn.DataPropertyName = "MIcerikID";
            this.mIcerikIDDataGridViewTextBoxColumn.HeaderText = "MIcerikID";
            this.mIcerikIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mIcerikIDDataGridViewTextBoxColumn.Name = "mIcerikIDDataGridViewTextBoxColumn";
            this.mIcerikIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mIcerikIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // IcerikAdi
            // 
            this.IcerikAdi.DataPropertyName = "IcerikAdi";
            this.IcerikAdi.HeaderText = "İçerik Adı";
            this.IcerikAdi.MinimumWidth = 6;
            this.IcerikAdi.Name = "IcerikAdi";
            this.IcerikAdi.ReadOnly = true;
            this.IcerikAdi.Width = 125;
            // 
            // modulIDDataGridViewTextBoxColumn
            // 
            this.modulIDDataGridViewTextBoxColumn.DataPropertyName = "ModulID";
            this.modulIDDataGridViewTextBoxColumn.HeaderText = "ModulID";
            this.modulIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modulIDDataGridViewTextBoxColumn.Name = "modulIDDataGridViewTextBoxColumn";
            this.modulIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.modulIDDataGridViewTextBoxColumn.Visible = false;
            this.modulIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // Adi
            // 
            this.Adi.DataPropertyName = "Adi";
            this.Adi.HeaderText = "Modül Adı";
            this.Adi.MinimumWidth = 6;
            this.Adi.Name = "Adi";
            this.Adi.ReadOnly = true;
            this.Adi.Width = 125;
            // 
            // Onay
            // 
            this.Onay.DataPropertyName = "Onay";
            this.Onay.HeaderText = "Onay";
            this.Onay.MinimumWidth = 6;
            this.Onay.Name = "Onay";
            this.Onay.Width = 125;
            // 
            // Aciklama
            // 
            this.Aciklama.DataPropertyName = "OnayAciklamasi";
            this.Aciklama.HeaderText = "OnayAciklamasi";
            this.Aciklama.MinimumWidth = 6;
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.Width = 125;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            this.tarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // Kilavuz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 450);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.KilavuzGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Kilavuz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kilavuz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Kilavuz_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KilavuzGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Kilavuz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Modul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Sirket)).EndInit();
            this.ctx_Strip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem KaydetMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SirketMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOŞToolStripMenuItem;
        private ModulDBDataSet ds_Modul;
        private ModulDBDataSetTableAdapters.KilavuzTblTableAdapter KilavuzTA;
        private System.Windows.Forms.BindingSource bs_Sirket;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private ModulDBDataSetTableAdapters.SirketTblTableAdapter Sirket_TA;
        private System.Windows.Forms.DataGridView KilavuzGrid;
        private System.Windows.Forms.BindingSource bs_Kilavuz;
        private ModulDBDataSetTableAdapters.KilavuzLogTblTableAdapter LogKilavuz_TableAdapter;
        private System.Windows.Forms.ToolStripMenuItem yToolStripMenuItem;
        private ModulDBDataSetTableAdapters.SelectedSirketTableAdapter Tbl_SelectedSirket;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctx_Strip;
        private System.Windows.Forms.ToolStripMenuItem resimlerToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDData;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIcerikIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IcerikAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn modulIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Onay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
    }
}