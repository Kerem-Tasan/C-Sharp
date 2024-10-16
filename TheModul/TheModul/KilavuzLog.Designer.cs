namespace TheModul
{
    partial class KilavuzLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KilavuzLog));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bs_Log = new System.Windows.Forms.BindingSource(this.components);
            this.ds_modul = new TheModul.ModulDBDataSet();
            this.tbl_Log = new TheModul.ModulDBDataSetTableAdapters.KilavuzLogTblTableAdapter();
            this.tbl_Kilavuz = new TheModul.ModulDBDataSetTableAdapters.KilavuzTblTableAdapter();
            this.IDData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilavuzIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnayData = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.onayAciklamasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modulIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SirketData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_sirket = new TheModul.ModulDBDataSetTableAdapters.SirketTblTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Log)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_modul)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yenileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1358, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yenileToolStripMenuItem.Image")));
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.yenileToolStripMenuItem.Text = "Onayla";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDData,
            this.kilavuzIDDataGridViewTextBoxColumn,
            this.OnayData,
            this.onayAciklamasiDataGridViewTextBoxColumn,
            this.Ad,
            this.Adi,
            this.tarihDataGridViewTextBoxColumn,
            this.modulIDDataGridViewTextBoxColumn,
            this.SirketData});
            this.dataGridView1.DataSource = this.bs_Log;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1358, 596);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // bs_Log
            // 
            this.bs_Log.DataMember = "KilavuzLogTbl";
            this.bs_Log.DataSource = this.ds_modul;
            // 
            // ds_modul
            // 
            this.ds_modul.DataSetName = "ModulDBDataSet";
            this.ds_modul.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_Log
            // 
            this.tbl_Log.ClearBeforeFill = true;
            // 
            // tbl_Kilavuz
            // 
            this.tbl_Kilavuz.ClearBeforeFill = true;
            // 
            // IDData
            // 
            this.IDData.DataPropertyName = "ID";
            this.IDData.HeaderText = "ID";
            this.IDData.MinimumWidth = 6;
            this.IDData.Name = "IDData";
            this.IDData.Width = 125;
            // 
            // kilavuzIDDataGridViewTextBoxColumn
            // 
            this.kilavuzIDDataGridViewTextBoxColumn.DataPropertyName = "KilavuzID";
            this.kilavuzIDDataGridViewTextBoxColumn.HeaderText = "KilavuzID";
            this.kilavuzIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kilavuzIDDataGridViewTextBoxColumn.Name = "kilavuzIDDataGridViewTextBoxColumn";
            this.kilavuzIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // OnayData
            // 
            this.OnayData.DataPropertyName = "Onay";
            this.OnayData.HeaderText = "Onay";
            this.OnayData.MinimumWidth = 6;
            this.OnayData.Name = "OnayData";
            this.OnayData.Width = 125;
            // 
            // onayAciklamasiDataGridViewTextBoxColumn
            // 
            this.onayAciklamasiDataGridViewTextBoxColumn.DataPropertyName = "OnayAciklamasi";
            this.onayAciklamasiDataGridViewTextBoxColumn.HeaderText = "OnayAciklamasi";
            this.onayAciklamasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.onayAciklamasiDataGridViewTextBoxColumn.Name = "onayAciklamasiDataGridViewTextBoxColumn";
            this.onayAciklamasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "Ad";
            this.Ad.HeaderText = "Şirket Adı";
            this.Ad.MinimumWidth = 6;
            this.Ad.Name = "Ad";
            this.Ad.Width = 125;
            // 
            // Adi
            // 
            this.Adi.DataPropertyName = "Adi";
            this.Adi.HeaderText = "Modül Adı";
            this.Adi.MinimumWidth = 6;
            this.Adi.Name = "Adi";
            this.Adi.Width = 125;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // modulIDDataGridViewTextBoxColumn
            // 
            this.modulIDDataGridViewTextBoxColumn.DataPropertyName = "ModulID";
            this.modulIDDataGridViewTextBoxColumn.HeaderText = "ModulID";
            this.modulIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modulIDDataGridViewTextBoxColumn.Name = "modulIDDataGridViewTextBoxColumn";
            this.modulIDDataGridViewTextBoxColumn.Visible = false;
            this.modulIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // SirketData
            // 
            this.SirketData.DataPropertyName = "SirketID";
            this.SirketData.HeaderText = "SirketID";
            this.SirketData.MinimumWidth = 6;
            this.SirketData.Name = "SirketData";
            this.SirketData.Visible = false;
            this.SirketData.Width = 125;
            // 
            // tbl_sirket
            // 
            this.tbl_sirket.ClearBeforeFill = true;
            // 
            // KilavuzLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 624);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KilavuzLog";
            this.Text = "KilavuzLog";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KilavuzLog_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Log)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_modul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ModulDBDataSet ds_modul;
        private System.Windows.Forms.BindingSource bs_Log;
        private ModulDBDataSetTableAdapters.KilavuzLogTblTableAdapter tbl_Log;
        private ModulDBDataSetTableAdapters.KilavuzTblTableAdapter tbl_Kilavuz;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDData;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilavuzIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OnayData;
        private System.Windows.Forms.DataGridViewTextBoxColumn onayAciklamasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modulIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SirketData;
        private ModulDBDataSetTableAdapters.SirketTblTableAdapter tbl_sirket;
    }
}