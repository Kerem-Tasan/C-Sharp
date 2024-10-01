namespace LTS_Mini
{
    partial class IstekTanimlari
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
            this.IstekTanimları_Grid = new System.Windows.Forms.DataGridView();
            this.ıstekKategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._LTS_MiniDataSet = new LTS_Mini._LTS_MiniDataSet();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.istekKategoriTableAdapter = new LTS_Mini._LTS_MiniDataSetTableAdapters.IstekKategoriTableAdapter();
            this.IstekEkle_btn = new System.Windows.Forms.Button();
            this.Guncelle_btn = new System.Windows.Forms.Button();
            this.sil_btn = new System.Windows.Forms.Button();
            this.Listele_btn = new System.Windows.Forms.Button();
            this.SilinenleriListele_btn = new System.Windows.Forms.Button();
            this.ıstekIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıstekAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDeleted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SilinmeNedeni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.IstekTanimları_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıstekKategoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._LTS_MiniDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // IstekTanimları_Grid
            // 
            this.IstekTanimları_Grid.AutoGenerateColumns = false;
            this.IstekTanimları_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IstekTanimları_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıstekIDDataGridViewTextBoxColumn,
            this.ıstekAdıDataGridViewTextBoxColumn,
            this.IsDeleted,
            this.SilinmeNedeni});
            this.IstekTanimları_Grid.DataSource = this.ıstekKategoriBindingSource;
            this.IstekTanimları_Grid.Location = new System.Drawing.Point(12, 55);
            this.IstekTanimları_Grid.Name = "IstekTanimları_Grid";
            this.IstekTanimları_Grid.RowHeadersWidth = 51;
            this.IstekTanimları_Grid.RowTemplate.Height = 24;
            this.IstekTanimları_Grid.Size = new System.Drawing.Size(762, 346);
            this.IstekTanimları_Grid.TabIndex = 0;
            this.IstekTanimları_Grid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // ıstekKategoriBindingSource
            // 
            this.ıstekKategoriBindingSource.DataMember = "IstekKategori";
            this.ıstekKategoriBindingSource.DataSource = this._LTS_MiniDataSet;
            // 
            // _LTS_MiniDataSet
            // 
            this._LTS_MiniDataSet.DataSetName = "_LTS_MiniDataSet";
            this._LTS_MiniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // istekKategoriTableAdapter
            // 
            this.istekKategoriTableAdapter.ClearBeforeFill = true;
            // 
            // IstekEkle_btn
            // 
            this.IstekEkle_btn.Location = new System.Drawing.Point(23, -1);
            this.IstekEkle_btn.Name = "IstekEkle_btn";
            this.IstekEkle_btn.Size = new System.Drawing.Size(75, 54);
            this.IstekEkle_btn.TabIndex = 1;
            this.IstekEkle_btn.Text = "Ekle";
            this.IstekEkle_btn.UseVisualStyleBackColor = true;
            this.IstekEkle_btn.Click += new System.EventHandler(this.IstekEkle_btn_Click);
            // 
            // Guncelle_btn
            // 
            this.Guncelle_btn.Location = new System.Drawing.Point(104, -1);
            this.Guncelle_btn.Name = "Guncelle_btn";
            this.Guncelle_btn.Size = new System.Drawing.Size(79, 54);
            this.Guncelle_btn.TabIndex = 2;
            this.Guncelle_btn.Text = "Güncelle";
            this.Guncelle_btn.UseVisualStyleBackColor = true;
            this.Guncelle_btn.Click += new System.EventHandler(this.Guncelle_btn_Click);
            // 
            // sil_btn
            // 
            this.sil_btn.Location = new System.Drawing.Point(189, -1);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(75, 54);
            this.sil_btn.TabIndex = 3;
            this.sil_btn.Text = "Sil";
            this.sil_btn.UseVisualStyleBackColor = true;
            this.sil_btn.Click += new System.EventHandler(this.sil_btn_Click);
            // 
            // Listele_btn
            // 
            this.Listele_btn.Location = new System.Drawing.Point(270, -1);
            this.Listele_btn.Name = "Listele_btn";
            this.Listele_btn.Size = new System.Drawing.Size(75, 50);
            this.Listele_btn.TabIndex = 4;
            this.Listele_btn.Text = "Aktifleri Listele";
            this.Listele_btn.UseVisualStyleBackColor = true;
            this.Listele_btn.Click += new System.EventHandler(this.Listele_btn_Click);
            // 
            // SilinenleriListele_btn
            // 
            this.SilinenleriListele_btn.Location = new System.Drawing.Point(351, -1);
            this.SilinenleriListele_btn.Name = "SilinenleriListele_btn";
            this.SilinenleriListele_btn.Size = new System.Drawing.Size(75, 50);
            this.SilinenleriListele_btn.TabIndex = 5;
            this.SilinenleriListele_btn.Text = "Silinenleri Listele";
            this.SilinenleriListele_btn.UseVisualStyleBackColor = true;
            this.SilinenleriListele_btn.Click += new System.EventHandler(this.SilinenleriListele_btn_Click);
            // 
            // ıstekIDDataGridViewTextBoxColumn
            // 
            this.ıstekIDDataGridViewTextBoxColumn.DataPropertyName = "IstekID";
            this.ıstekIDDataGridViewTextBoxColumn.HeaderText = "IstekID";
            this.ıstekIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıstekIDDataGridViewTextBoxColumn.Name = "ıstekIDDataGridViewTextBoxColumn";
            this.ıstekIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıstekIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // ıstekAdıDataGridViewTextBoxColumn
            // 
            this.ıstekAdıDataGridViewTextBoxColumn.DataPropertyName = "IstekAdı";
            this.ıstekAdıDataGridViewTextBoxColumn.HeaderText = "IstekAdı";
            this.ıstekAdıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıstekAdıDataGridViewTextBoxColumn.Name = "ıstekAdıDataGridViewTextBoxColumn";
            this.ıstekAdıDataGridViewTextBoxColumn.Width = 150;
            // 
            // IsDeleted
            // 
            this.IsDeleted.DataPropertyName = "IsDeleted";
            this.IsDeleted.HeaderText = "IsDeleted";
            this.IsDeleted.MinimumWidth = 6;
            this.IsDeleted.Name = "IsDeleted";
            this.IsDeleted.Width = 70;
            // 
            // SilinmeNedeni
            // 
            this.SilinmeNedeni.DataPropertyName = "SilinmeNedeni";
            this.SilinmeNedeni.HeaderText = "SilinmeNedeni";
            this.SilinmeNedeni.MinimumWidth = 6;
            this.SilinmeNedeni.Name = "SilinmeNedeni";
            this.SilinmeNedeni.Visible = false;
            this.SilinmeNedeni.Width = 200;
            // 
            // IstekTanimlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SilinenleriListele_btn);
            this.Controls.Add(this.Listele_btn);
            this.Controls.Add(this.sil_btn);
            this.Controls.Add(this.Guncelle_btn);
            this.Controls.Add(this.IstekEkle_btn);
            this.Controls.Add(this.IstekTanimları_Grid);
            this.Name = "IstekTanimlari";
            this.Text = "IstekTanimlari";
            this.Load += new System.EventHandler(this.IstekTanimlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IstekTanimları_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıstekKategoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._LTS_MiniDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView IstekTanimları_Grid;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private _LTS_MiniDataSet _LTS_MiniDataSet;
        private System.Windows.Forms.BindingSource ıstekKategoriBindingSource;
        private _LTS_MiniDataSetTableAdapters.IstekKategoriTableAdapter istekKategoriTableAdapter;
        private System.Windows.Forms.Button IstekEkle_btn;
        private System.Windows.Forms.Button Guncelle_btn;
        private System.Windows.Forms.Button sil_btn;
        private System.Windows.Forms.Button Listele_btn;
        private System.Windows.Forms.Button SilinenleriListele_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıstekIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıstekAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDeleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn SilinmeNedeni;
    }
}