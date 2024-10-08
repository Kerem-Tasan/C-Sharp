namespace TaskApplication
{
    partial class KullaniciIslemleri
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
            this.Kullanici_Grid = new System.Windows.Forms.DataGridView();
            this.TipAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktifleriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silinenleriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silindiMiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.silmeNedeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gorevDS = new TaskApplication.GorevDS();
            this.kullaniciTblTableAdapter = new TaskApplication.GorevDSTableAdapters.KullaniciTblTableAdapter();
            this.kullaniciTipiTableAdapter1 = new TaskApplication.GorevDSTableAdapters.KullaniciTipiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Kullanici_Grid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevDS)).BeginInit();
            this.SuspendLayout();
            // 
            // Kullanici_Grid
            // 
            this.Kullanici_Grid.AutoGenerateColumns = false;
            this.Kullanici_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Kullanici_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.kullaniciAdiDataGridViewTextBoxColumn,
            this.TipAdi,
            this.dataGridViewTextBoxColumn1,
            this.sifreDataGridViewTextBoxColumn,
            this.kayitTarihiDataGridViewTextBoxColumn,
            this.silindiMiDataGridViewCheckBoxColumn,
            this.silmeNedeniDataGridViewTextBoxColumn});
            this.Kullanici_Grid.DataSource = this.kullaniciTblBindingSource;
            this.Kullanici_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Kullanici_Grid.Location = new System.Drawing.Point(0, 28);
            this.Kullanici_Grid.Name = "Kullanici_Grid";
            this.Kullanici_Grid.RowHeadersWidth = 51;
            this.Kullanici_Grid.RowTemplate.Height = 24;
            this.Kullanici_Grid.Size = new System.Drawing.Size(1484, 481);
            this.Kullanici_Grid.TabIndex = 1;
            this.Kullanici_Grid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Kullanici_Grid_CellMouseClick);
            // 
            // TipAdi
            // 
            this.TipAdi.DataPropertyName = "KTipi_TipTbl";
            this.TipAdi.HeaderText = "Kullanıcı Tipi";
            this.TipAdi.MinimumWidth = 6;
            this.TipAdi.Name = "TipAdi";
            this.TipAdi.Visible = false;
            this.TipAdi.Width = 70;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TipAdi";
            this.dataGridViewTextBoxColumn1.HeaderText = "TipAdi";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.güncelleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.aktifleriListeleToolStripMenuItem,
            this.silinenleriListeleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1484, 28);
            this.menuStrip1.TabIndex = 2;
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
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click_1);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(39, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click_1);
            // 
            // aktifleriListeleToolStripMenuItem
            // 
            this.aktifleriListeleToolStripMenuItem.Name = "aktifleriListeleToolStripMenuItem";
            this.aktifleriListeleToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.aktifleriListeleToolStripMenuItem.Text = "Aktifleri Listele";
            this.aktifleriListeleToolStripMenuItem.Click += new System.EventHandler(this.aktifleriListeleToolStripMenuItem_Click_1);
            // 
            // silinenleriListeleToolStripMenuItem
            // 
            this.silinenleriListeleToolStripMenuItem.Name = "silinenleriListeleToolStripMenuItem";
            this.silinenleriListeleToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.silinenleriListeleToolStripMenuItem.Text = "Silinenleri Listele";
            this.silinenleriListeleToolStripMenuItem.Click += new System.EventHandler(this.silinenleriListeleToolStripMenuItem_Click_1);
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.Width = 60;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 80;
            // 
            // kullaniciAdiDataGridViewTextBoxColumn
            // 
            this.kullaniciAdiDataGridViewTextBoxColumn.DataPropertyName = "KullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.HeaderText = "Kullanıcı Adı";
            this.kullaniciAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullaniciAdiDataGridViewTextBoxColumn.Name = "kullaniciAdiDataGridViewTextBoxColumn";
            this.kullaniciAdiDataGridViewTextBoxColumn.Width = 80;
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Şifre";
            this.sifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            this.sifreDataGridViewTextBoxColumn.Width = 80;
            // 
            // kayitTarihiDataGridViewTextBoxColumn
            // 
            this.kayitTarihiDataGridViewTextBoxColumn.DataPropertyName = "KayitTarihi";
            this.kayitTarihiDataGridViewTextBoxColumn.HeaderText = "Kayıt Tarihi";
            this.kayitTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kayitTarihiDataGridViewTextBoxColumn.Name = "kayitTarihiDataGridViewTextBoxColumn";
            this.kayitTarihiDataGridViewTextBoxColumn.Width = 120;
            // 
            // silindiMiDataGridViewCheckBoxColumn
            // 
            this.silindiMiDataGridViewCheckBoxColumn.DataPropertyName = "SilindiMi";
            this.silindiMiDataGridViewCheckBoxColumn.HeaderText = "Silindi mi";
            this.silindiMiDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.silindiMiDataGridViewCheckBoxColumn.Name = "silindiMiDataGridViewCheckBoxColumn";
            this.silindiMiDataGridViewCheckBoxColumn.Visible = false;
            this.silindiMiDataGridViewCheckBoxColumn.Width = 60;
            // 
            // silmeNedeniDataGridViewTextBoxColumn
            // 
            this.silmeNedeniDataGridViewTextBoxColumn.DataPropertyName = "SilmeNedeni";
            this.silmeNedeniDataGridViewTextBoxColumn.HeaderText = "Silme Nedeni";
            this.silmeNedeniDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.silmeNedeniDataGridViewTextBoxColumn.Name = "silmeNedeniDataGridViewTextBoxColumn";
            this.silmeNedeniDataGridViewTextBoxColumn.Visible = false;
            this.silmeNedeniDataGridViewTextBoxColumn.Width = 80;
            // 
            // kullaniciTblBindingSource
            // 
            this.kullaniciTblBindingSource.DataMember = "KullaniciTbl";
            this.kullaniciTblBindingSource.DataSource = this.gorevDS;
            // 
            // gorevDS
            // 
            this.gorevDS.DataSetName = "GorevDS";
            this.gorevDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullaniciTblTableAdapter
            // 
            this.kullaniciTblTableAdapter.ClearBeforeFill = true;
            // 
            // kullaniciTipiTableAdapter1
            // 
            this.kullaniciTipiTableAdapter1.ClearBeforeFill = true;
            // 
            // KullaniciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 509);
            this.Controls.Add(this.Kullanici_Grid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KullaniciIslemleri";
            this.Text = "KullaniciIslemleri";
            this.Load += new System.EventHandler(this.KullaniciIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Kullanici_Grid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Kullanici_Grid;
        private GorevDS gorevDS;
        private System.Windows.Forms.BindingSource kullaniciTblBindingSource;
        private GorevDSTableAdapters.KullaniciTblTableAdapter kullaniciTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktifleriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silinenleriListeleToolStripMenuItem;
        private GorevDSTableAdapters.KullaniciTipiTableAdapter kullaniciTipiTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn silindiMiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn silmeNedeniDataGridViewTextBoxColumn;
    }
}