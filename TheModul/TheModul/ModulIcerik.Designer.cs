namespace TheModul
{
    partial class ModulIcerik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModulIcerik));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıcerikAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıcerikAciklamasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modulIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_model = new System.Windows.Forms.BindingSource(this.components);
            this.ds_modul = new TheModul.ModulDBDataSet();
            this.tbl_ModulIcerik = new TheModul.ModulDBDataSetTableAdapters.Modul_IcerikTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_model)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_modul)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.güncelleToolStripMenuItem,
            this.yenileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1111, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yenileToolStripMenuItem.Image")));
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDData,
            this.Adi,
            this.ıcerikAdiDataGridViewTextBoxColumn,
            this.ıcerikAciklamasiDataGridViewTextBoxColumn,
            this.kayitTarihiDataGridViewTextBoxColumn,
            this.modulIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bs_model;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1111, 451);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // ıDData
            // 
            this.ıDData.DataPropertyName = "ID";
            this.ıDData.HeaderText = "ID";
            this.ıDData.MinimumWidth = 6;
            this.ıDData.Name = "ıDData";
            this.ıDData.Width = 60;
            // 
            // Adi
            // 
            this.Adi.DataPropertyName = "Adi";
            this.Adi.HeaderText = "Adi";
            this.Adi.MinimumWidth = 6;
            this.Adi.Name = "Adi";
            this.Adi.Width = 125;
            // 
            // ıcerikAdiDataGridViewTextBoxColumn
            // 
            this.ıcerikAdiDataGridViewTextBoxColumn.DataPropertyName = "IcerikAdi";
            this.ıcerikAdiDataGridViewTextBoxColumn.HeaderText = "IcerikAdi";
            this.ıcerikAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıcerikAdiDataGridViewTextBoxColumn.Name = "ıcerikAdiDataGridViewTextBoxColumn";
            this.ıcerikAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıcerikAciklamasiDataGridViewTextBoxColumn
            // 
            this.ıcerikAciklamasiDataGridViewTextBoxColumn.DataPropertyName = "IcerikAciklamasi";
            this.ıcerikAciklamasiDataGridViewTextBoxColumn.HeaderText = "IcerikAciklamasi";
            this.ıcerikAciklamasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıcerikAciklamasiDataGridViewTextBoxColumn.Name = "ıcerikAciklamasiDataGridViewTextBoxColumn";
            this.ıcerikAciklamasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kayitTarihiDataGridViewTextBoxColumn
            // 
            this.kayitTarihiDataGridViewTextBoxColumn.DataPropertyName = "KayitTarihi";
            this.kayitTarihiDataGridViewTextBoxColumn.HeaderText = "KayitTarihi";
            this.kayitTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kayitTarihiDataGridViewTextBoxColumn.Name = "kayitTarihiDataGridViewTextBoxColumn";
            this.kayitTarihiDataGridViewTextBoxColumn.Width = 125;
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
            // bs_model
            // 
            this.bs_model.DataMember = "Modul_Icerik";
            this.bs_model.DataSource = this.ds_modul;
            // 
            // ds_modul
            // 
            this.ds_modul.DataSetName = "ModulDBDataSet";
            this.ds_modul.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_ModulIcerik
            // 
            this.tbl_ModulIcerik.ClearBeforeFill = true;
            // 
            // ModulIcerik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 479);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ModulIcerik";
            this.Text = "ModulIcerik";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ModulIcerik_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_model)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_modul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ModulDBDataSet ds_modul;
        private System.Windows.Forms.BindingSource bs_model;
        private ModulDBDataSetTableAdapters.Modul_IcerikTableAdapter tbl_ModulIcerik;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıcerikAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıcerikAciklamasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modulIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
    }
}