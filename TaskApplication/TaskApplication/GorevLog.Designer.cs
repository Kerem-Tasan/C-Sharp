namespace TaskApplication
{
    partial class GorevLog
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
            this.GorevLogGrid = new System.Windows.Forms.DataGridView();
            this.gorevLogTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gorevDS = new TaskApplication.GorevDS();
            this.gorevLogTblTableAdapter = new TaskApplication.GorevDSTableAdapters.GorevLogTblTableAdapter();
            this.ıDDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciOnayliMiData = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kullaniciOnayAciklamasiData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiOnayliMiData = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.yoneticiOnayAciklamaData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GörevTipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GorevID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GorevLogGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevLogTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevDS)).BeginInit();
            this.SuspendLayout();
            // 
            // GorevLogGrid
            // 
            this.GorevLogGrid.AutoGenerateColumns = false;
            this.GorevLogGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GorevLogGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGrid,
            this.Ad,
            this.kullaniciOnayliMiData,
            this.kullaniciOnayAciklamasiData,
            this.yoneticiOnayliMiData,
            this.yoneticiOnayAciklamaData,
            this.GörevTipi,
            this.GorevID,
            this.TipAdi});
            this.GorevLogGrid.DataSource = this.gorevLogTblBindingSource;
            this.GorevLogGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GorevLogGrid.Location = new System.Drawing.Point(0, 0);
            this.GorevLogGrid.Name = "GorevLogGrid";
            this.GorevLogGrid.RowHeadersWidth = 51;
            this.GorevLogGrid.RowTemplate.Height = 24;
            this.GorevLogGrid.Size = new System.Drawing.Size(1283, 606);
            this.GorevLogGrid.TabIndex = 1;
            this.GorevLogGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GorevLogGrid_CellFormatting);
            // 
            // gorevLogTblBindingSource
            // 
            this.gorevLogTblBindingSource.DataMember = "GorevLogTbl";
            this.gorevLogTblBindingSource.DataSource = this.gorevDS;
            // 
            // gorevDS
            // 
            this.gorevDS.DataSetName = "GorevDS";
            this.gorevDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gorevLogTblTableAdapter
            // 
            this.gorevLogTblTableAdapter.ClearBeforeFill = true;
            // 
            // ıDDataGrid
            // 
            this.ıDDataGrid.DataPropertyName = "ID";
            this.ıDDataGrid.HeaderText = "ID";
            this.ıDDataGrid.MinimumWidth = 6;
            this.ıDDataGrid.Name = "ıDDataGrid";
            this.ıDDataGrid.Width = 60;
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "Ad";
            this.Ad.HeaderText = "Ad";
            this.Ad.MinimumWidth = 6;
            this.Ad.Name = "Ad";
            this.Ad.Width = 125;
            // 
            // kullaniciOnayliMiData
            // 
            this.kullaniciOnayliMiData.DataPropertyName = "KullaniciOnayliMi";
            this.kullaniciOnayliMiData.HeaderText = "Kullanıcı Onayı ";
            this.kullaniciOnayliMiData.MinimumWidth = 6;
            this.kullaniciOnayliMiData.Name = "kullaniciOnayliMiData";
            this.kullaniciOnayliMiData.Width = 125;
            // 
            // kullaniciOnayAciklamasiData
            // 
            this.kullaniciOnayAciklamasiData.DataPropertyName = "KullaniciOnayAciklamasi";
            this.kullaniciOnayAciklamasiData.HeaderText = "Kullanıcı Açıklaması";
            this.kullaniciOnayAciklamasiData.MinimumWidth = 6;
            this.kullaniciOnayAciklamasiData.Name = "kullaniciOnayAciklamasiData";
            this.kullaniciOnayAciklamasiData.Width = 125;
            // 
            // yoneticiOnayliMiData
            // 
            this.yoneticiOnayliMiData.DataPropertyName = "YoneticiOnayliMi";
            this.yoneticiOnayliMiData.HeaderText = "Yönetici Onayı";
            this.yoneticiOnayliMiData.MinimumWidth = 6;
            this.yoneticiOnayliMiData.Name = "yoneticiOnayliMiData";
            this.yoneticiOnayliMiData.Width = 125;
            // 
            // yoneticiOnayAciklamaData
            // 
            this.yoneticiOnayAciklamaData.DataPropertyName = "YoneticiOnayAciklama";
            this.yoneticiOnayAciklamaData.HeaderText = "Yönetici Açıklama";
            this.yoneticiOnayAciklamaData.MinimumWidth = 6;
            this.yoneticiOnayAciklamaData.Name = "yoneticiOnayAciklamaData";
            this.yoneticiOnayAciklamaData.Width = 125;
            // 
            // GörevTipi
            // 
            this.GörevTipi.DataPropertyName = "GörevTipi";
            this.GörevTipi.HeaderText = "GörevTipi";
            this.GörevTipi.MinimumWidth = 6;
            this.GörevTipi.Name = "GörevTipi";
            this.GörevTipi.Visible = false;
            this.GörevTipi.Width = 125;
            // 
            // GorevID
            // 
            this.GorevID.DataPropertyName = "GorevID";
            this.GorevID.HeaderText = "GorevID";
            this.GorevID.MinimumWidth = 6;
            this.GorevID.Name = "GorevID";
            this.GorevID.Visible = false;
            this.GorevID.Width = 125;
            // 
            // TipAdi
            // 
            this.TipAdi.DataPropertyName = "TipAdi";
            this.TipAdi.HeaderText = "TipAdi";
            this.TipAdi.MinimumWidth = 6;
            this.TipAdi.Name = "TipAdi";
            this.TipAdi.Width = 125;
            // 
            // GorevLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 606);
            this.Controls.Add(this.GorevLogGrid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GorevLog";
            this.Text = "GorevLog";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GorevLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GorevLogGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevLogTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView GorevLogGrid;
        private GorevDS gorevDS;
        private System.Windows.Forms.BindingSource gorevLogTblBindingSource;
        private GorevDSTableAdapters.GorevLogTblTableAdapter gorevLogTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn kullaniciOnayliMiData;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciOnayAciklamasiData;
        private System.Windows.Forms.DataGridViewCheckBoxColumn yoneticiOnayliMiData;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiOnayAciklamaData;
        private System.Windows.Forms.DataGridViewTextBoxColumn GörevTipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GorevID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipAdi;
    }
}