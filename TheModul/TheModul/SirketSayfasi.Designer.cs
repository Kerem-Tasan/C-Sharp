namespace TheModul
{
    partial class SirketSayfasi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sirketTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.durumAyarlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ısDeletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.durumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bs_Sirket = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Modul = new TheModul.ModulDBDataSet();
            this.tbl_Sirket = new TheModul.ModulDBDataSetTableAdapters.SirketTblTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Sirket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Modul)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.güncelleToolStripMenuItem,
            this.durumAyarlaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1051, 28);
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
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(39, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCol,
            this.adDataGridViewTextBoxColumn,
            this.kayitTarihiDataGridViewTextBoxColumn,
            this.kIDDataGridViewTextBoxColumn,
            this.ısDeletedDataGridViewCheckBoxColumn,
            this.durumDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.sirketTblBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1051, 422);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // sirketTblBindingSource
            // 
            this.sirketTblBindingSource.DataMember = "SirketTbl";
            this.sirketTblBindingSource.DataSource = this.bs_Sirket;
            // 
            // durumAyarlaToolStripMenuItem
            // 
            this.durumAyarlaToolStripMenuItem.Name = "durumAyarlaToolStripMenuItem";
            this.durumAyarlaToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.durumAyarlaToolStripMenuItem.Text = "Durum Ayarla";
            this.durumAyarlaToolStripMenuItem.Click += new System.EventHandler(this.durumAyarlaToolStripMenuItem_Click);
            // 
            // IDCol
            // 
            this.IDCol.DataPropertyName = "ID";
            this.IDCol.HeaderText = "ID";
            this.IDCol.MinimumWidth = 6;
            this.IDCol.Name = "IDCol";
            this.IDCol.Visible = false;
            this.IDCol.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // kayitTarihiDataGridViewTextBoxColumn
            // 
            this.kayitTarihiDataGridViewTextBoxColumn.DataPropertyName = "KayitTarihi";
            this.kayitTarihiDataGridViewTextBoxColumn.HeaderText = "KayitTarihi";
            this.kayitTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kayitTarihiDataGridViewTextBoxColumn.Name = "kayitTarihiDataGridViewTextBoxColumn";
            this.kayitTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            this.kayitTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kIDDataGridViewTextBoxColumn
            // 
            this.kIDDataGridViewTextBoxColumn.DataPropertyName = "KID";
            this.kIDDataGridViewTextBoxColumn.HeaderText = "KID";
            this.kIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kIDDataGridViewTextBoxColumn.Name = "kIDDataGridViewTextBoxColumn";
            this.kIDDataGridViewTextBoxColumn.Visible = false;
            this.kIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ısDeletedDataGridViewCheckBoxColumn
            // 
            this.ısDeletedDataGridViewCheckBoxColumn.DataPropertyName = "IsDeleted";
            this.ısDeletedDataGridViewCheckBoxColumn.HeaderText = "IsDeleted";
            this.ısDeletedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.ısDeletedDataGridViewCheckBoxColumn.Name = "ısDeletedDataGridViewCheckBoxColumn";
            this.ısDeletedDataGridViewCheckBoxColumn.Visible = false;
            this.ısDeletedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // durumDataGridViewCheckBoxColumn
            // 
            this.durumDataGridViewCheckBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewCheckBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.durumDataGridViewCheckBoxColumn.Name = "durumDataGridViewCheckBoxColumn";
            this.durumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // bs_Sirket
            // 
            this.bs_Sirket.DataSource = this.ds_Modul;
            this.bs_Sirket.Position = 0;
            // 
            // ds_Modul
            // 
            this.ds_Modul.DataSetName = "ModulDBDataSet";
            this.ds_Modul.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_Sirket
            // 
            this.tbl_Sirket.ClearBeforeFill = true;
            // 
            // SirketSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SirketSayfasi";
            this.Text = "SirketSayfasi";
            this.Load += new System.EventHandler(this.SirketSayfasi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Sirket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Modul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bs_Sirket;
        private ModulDBDataSet ds_Modul;
        private ModulDBDataSetTableAdapters.SirketTblTableAdapter tbl_Sirket;
        private System.Windows.Forms.BindingSource sirketTblBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ısDeletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn durumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem durumAyarlaToolStripMenuItem;
    }
}