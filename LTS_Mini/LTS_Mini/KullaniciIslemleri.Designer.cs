namespace LTS_Mini
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
            this.KullaniciGrid = new System.Windows.Forms.DataGridView();
            this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._LTS_MiniDataSet = new LTS_Mini._LTS_MiniDataSet();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.kullaniciTableAdapter = new LTS_Mini._LTS_MiniDataSetTableAdapters.KullaniciTableAdapter();
            this.KullaniciEkle_btn = new System.Windows.Forms.Button();
            this.KullaniciGuncelleme_Btn = new System.Windows.Forms.Button();
            this.KullaniciSil_btn = new System.Windows.Forms.Button();
            this.KullaniciUndeleted_btn = new System.Windows.Forms.Button();
            this.KullaniciDeleted_btn = new System.Windows.Forms.Button();
            this.KullaniciID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silmeNedeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silindiMiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._LTS_MiniDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // KullaniciGrid
            // 
            this.KullaniciGrid.AutoGenerateColumns = false;
            this.KullaniciGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KullaniciGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KullaniciID,
            this.adSoyadDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.silmeNedeniDataGridViewTextBoxColumn,
            this.kullaniciTipiDataGridViewTextBoxColumn,
            this.kayitTarihiDataGridViewTextBoxColumn,
            this.silindiMiDataGridViewCheckBoxColumn});
            this.KullaniciGrid.DataSource = this.kullaniciBindingSource;
            this.KullaniciGrid.Location = new System.Drawing.Point(-2, 46);
            this.KullaniciGrid.Name = "KullaniciGrid";
            this.KullaniciGrid.ReadOnly = true;
            this.KullaniciGrid.RowHeadersWidth = 51;
            this.KullaniciGrid.RowTemplate.Height = 24;
            this.KullaniciGrid.Size = new System.Drawing.Size(1187, 400);
            this.KullaniciGrid.TabIndex = 0;
            this.KullaniciGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // kullaniciBindingSource
            // 
            this.kullaniciBindingSource.DataMember = "Kullanici";
            this.kullaniciBindingSource.DataSource = this._LTS_MiniDataSet;
            // 
            // _LTS_MiniDataSet
            // 
            this._LTS_MiniDataSet.DataSetName = "_LTS_MiniDataSet";
            this._LTS_MiniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullaniciTableAdapter
            // 
            this.kullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // KullaniciEkle_btn
            // 
            this.KullaniciEkle_btn.Location = new System.Drawing.Point(35, 1);
            this.KullaniciEkle_btn.Name = "KullaniciEkle_btn";
            this.KullaniciEkle_btn.Size = new System.Drawing.Size(75, 45);
            this.KullaniciEkle_btn.TabIndex = 1;
            this.KullaniciEkle_btn.Text = "Ekle";
            this.KullaniciEkle_btn.UseVisualStyleBackColor = true;
            this.KullaniciEkle_btn.Click += new System.EventHandler(this.KullaniciEkle_btn_Click);
            // 
            // KullaniciGuncelleme_Btn
            // 
            this.KullaniciGuncelleme_Btn.Location = new System.Drawing.Point(116, 1);
            this.KullaniciGuncelleme_Btn.Name = "KullaniciGuncelleme_Btn";
            this.KullaniciGuncelleme_Btn.Size = new System.Drawing.Size(75, 45);
            this.KullaniciGuncelleme_Btn.TabIndex = 2;
            this.KullaniciGuncelleme_Btn.Text = "Güncelle";
            this.KullaniciGuncelleme_Btn.UseVisualStyleBackColor = true;
            this.KullaniciGuncelleme_Btn.Click += new System.EventHandler(this.KullaniciGuncelleme_Btn_Click);
            // 
            // KullaniciSil_btn
            // 
            this.KullaniciSil_btn.Location = new System.Drawing.Point(197, 1);
            this.KullaniciSil_btn.Name = "KullaniciSil_btn";
            this.KullaniciSil_btn.Size = new System.Drawing.Size(75, 45);
            this.KullaniciSil_btn.TabIndex = 3;
            this.KullaniciSil_btn.Text = "Sil";
            this.KullaniciSil_btn.UseVisualStyleBackColor = true;
            this.KullaniciSil_btn.Click += new System.EventHandler(this.KullaniciSil_btn_Click);
            // 
            // KullaniciUndeleted_btn
            // 
            this.KullaniciUndeleted_btn.Location = new System.Drawing.Point(278, 1);
            this.KullaniciUndeleted_btn.Name = "KullaniciUndeleted_btn";
            this.KullaniciUndeleted_btn.Size = new System.Drawing.Size(72, 45);
            this.KullaniciUndeleted_btn.TabIndex = 4;
            this.KullaniciUndeleted_btn.Text = "Aktifleri Görüntüle";
            this.KullaniciUndeleted_btn.UseVisualStyleBackColor = true;
            this.KullaniciUndeleted_btn.Click += new System.EventHandler(this.KullaniciUndeleted_btn_Click);
            // 
            // KullaniciDeleted_btn
            // 
            this.KullaniciDeleted_btn.Location = new System.Drawing.Point(356, 1);
            this.KullaniciDeleted_btn.Name = "KullaniciDeleted_btn";
            this.KullaniciDeleted_btn.Size = new System.Drawing.Size(76, 45);
            this.KullaniciDeleted_btn.TabIndex = 5;
            this.KullaniciDeleted_btn.Text = "Silinenleri Görüntüle";
            this.KullaniciDeleted_btn.UseVisualStyleBackColor = true;
            this.KullaniciDeleted_btn.Click += new System.EventHandler(this.KullaniciDeleted_btn_Click);
            // 
            // KullaniciID
            // 
            this.KullaniciID.DataPropertyName = "KullaniciID";
            this.KullaniciID.HeaderText = "ID";
            this.KullaniciID.MinimumWidth = 6;
            this.KullaniciID.Name = "KullaniciID";
            this.KullaniciID.ReadOnly = true;
            this.KullaniciID.Width = 125;
            // 
            // adSoyadDataGridViewTextBoxColumn
            // 
            this.adSoyadDataGridViewTextBoxColumn.DataPropertyName = "AdSoyad";
            this.adSoyadDataGridViewTextBoxColumn.HeaderText = "Ad Soyad";
            this.adSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adSoyadDataGridViewTextBoxColumn.Name = "adSoyadDataGridViewTextBoxColumn";
            this.adSoyadDataGridViewTextBoxColumn.ReadOnly = true;
            this.adSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Şifre";
            this.sifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            this.sifreDataGridViewTextBoxColumn.ReadOnly = true;
            this.sifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // silmeNedeniDataGridViewTextBoxColumn
            // 
            this.silmeNedeniDataGridViewTextBoxColumn.DataPropertyName = "SilmeNedeni";
            this.silmeNedeniDataGridViewTextBoxColumn.HeaderText = "Silinme Nedeni";
            this.silmeNedeniDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.silmeNedeniDataGridViewTextBoxColumn.Name = "silmeNedeniDataGridViewTextBoxColumn";
            this.silmeNedeniDataGridViewTextBoxColumn.ReadOnly = true;
            this.silmeNedeniDataGridViewTextBoxColumn.Width = 125;
            // 
            // kullaniciTipiDataGridViewTextBoxColumn
            // 
            this.kullaniciTipiDataGridViewTextBoxColumn.DataPropertyName = "KullaniciTipi";
            this.kullaniciTipiDataGridViewTextBoxColumn.HeaderText = "Kullanıcı Tipi";
            this.kullaniciTipiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullaniciTipiDataGridViewTextBoxColumn.Name = "kullaniciTipiDataGridViewTextBoxColumn";
            this.kullaniciTipiDataGridViewTextBoxColumn.ReadOnly = true;
            this.kullaniciTipiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kayitTarihiDataGridViewTextBoxColumn
            // 
            this.kayitTarihiDataGridViewTextBoxColumn.DataPropertyName = "KayitTarihi";
            this.kayitTarihiDataGridViewTextBoxColumn.HeaderText = "Kayıt Tarihi";
            this.kayitTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kayitTarihiDataGridViewTextBoxColumn.Name = "kayitTarihiDataGridViewTextBoxColumn";
            this.kayitTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            this.kayitTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // silindiMiDataGridViewCheckBoxColumn
            // 
            this.silindiMiDataGridViewCheckBoxColumn.DataPropertyName = "SilindiMi";
            this.silindiMiDataGridViewCheckBoxColumn.HeaderText = "Silindi";
            this.silindiMiDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.silindiMiDataGridViewCheckBoxColumn.Name = "silindiMiDataGridViewCheckBoxColumn";
            this.silindiMiDataGridViewCheckBoxColumn.ReadOnly = true;
            this.silindiMiDataGridViewCheckBoxColumn.Width = 60;
            // 
            // KullaniciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 526);
            this.Controls.Add(this.KullaniciDeleted_btn);
            this.Controls.Add(this.KullaniciUndeleted_btn);
            this.Controls.Add(this.KullaniciSil_btn);
            this.Controls.Add(this.KullaniciGuncelleme_Btn);
            this.Controls.Add(this.KullaniciEkle_btn);
            this.Controls.Add(this.KullaniciGrid);
            this.Name = "KullaniciIslemleri";
            this.Text = "KullaniciIslemleri";
            this.Load += new System.EventHandler(this.KullaniciIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._LTS_MiniDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView KullaniciGrid;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private _LTS_MiniDataSet _LTS_MiniDataSet;
        private System.Windows.Forms.BindingSource kullaniciBindingSource;
        private _LTS_MiniDataSetTableAdapters.KullaniciTableAdapter kullaniciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanıcıAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button KullaniciEkle_btn;
        private System.Windows.Forms.Button KullaniciGuncelleme_Btn;
        private System.Windows.Forms.Button KullaniciSil_btn;
        private System.Windows.Forms.Button KullaniciUndeleted_btn;
        private System.Windows.Forms.Button KullaniciDeleted_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullaniciID;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn silmeNedeniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn silindiMiDataGridViewCheckBoxColumn;
    }
}