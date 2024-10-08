namespace TaskApplication
{
    partial class GorevSayfası
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
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.page_Bekleyen = new System.Windows.Forms.TabPage();
            this.GorevGrid = new System.Windows.Forms.DataGridView();
            this.IdData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KullaniciOnayli = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YoneticiOnayli = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CtxStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kullanıcıOnayıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıOnayAçıklamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiOnayıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiOnayAçıklamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gorevTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gorevDS = new TaskApplication.GorevDS();
            this.ıDData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KullaniciOnayliMi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.KullaniciOnayAciklamasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YoneticiOnayliMi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.YoneticiOnayAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KullaniciID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GörevTipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TamamlandiMi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.KayitTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaslangicTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KullaniciTipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorevTblTableAdapter = new TaskApplication.GorevDSTableAdapters.GorevTblTableAdapter();
            this.gorevLogTblTableAdapter1 = new TaskApplication.GorevDSTableAdapters.GorevLogTblTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.page_Bekleyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GorevGrid)).BeginInit();
            this.CtxStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gorevTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevDS)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.güncelleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1339, 28);
            this.menuStrip1.TabIndex = 6;
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
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(39, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.page_Bekleyen);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 28);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1339, 422);
            this.TabControl.TabIndex = 7;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // page_Bekleyen
            // 
            this.page_Bekleyen.Controls.Add(this.GorevGrid);
            this.page_Bekleyen.Location = new System.Drawing.Point(4, 25);
            this.page_Bekleyen.Name = "page_Bekleyen";
            this.page_Bekleyen.Padding = new System.Windows.Forms.Padding(3);
            this.page_Bekleyen.Size = new System.Drawing.Size(1331, 393);
            this.page_Bekleyen.TabIndex = 0;
            this.page_Bekleyen.Text = "Bekleyen İstekler";
            this.page_Bekleyen.UseVisualStyleBackColor = true;
            // 
            // GorevGrid
            // 
            this.GorevGrid.AutoGenerateColumns = false;
            this.GorevGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GorevGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdData,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.KullaniciOnayli,
            this.dataGridViewTextBoxColumn15,
            this.YoneticiOnayli,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewCheckBoxColumn8,
            this.dataGridViewTextBoxColumn24});
            this.GorevGrid.ContextMenuStrip = this.CtxStrip;
            this.GorevGrid.DataSource = this.gorevTblBindingSource;
            this.GorevGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GorevGrid.Location = new System.Drawing.Point(3, 3);
            this.GorevGrid.Name = "GorevGrid";
            this.GorevGrid.ReadOnly = true;
            this.GorevGrid.RowHeadersWidth = 51;
            this.GorevGrid.RowTemplate.Height = 24;
            this.GorevGrid.Size = new System.Drawing.Size(1325, 387);
            this.GorevGrid.TabIndex = 3;
            this.GorevGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GorevGrid_CellFormatting);
            this.GorevGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GorevGrid_CellMouseClick);
            // 
            // IdData
            // 
            this.IdData.DataPropertyName = "ID";
            this.IdData.HeaderText = "ID";
            this.IdData.MinimumWidth = 6;
            this.IdData.Name = "IdData";
            this.IdData.ReadOnly = true;
            this.IdData.Width = 60;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "KullaniciID";
            this.dataGridViewTextBoxColumn17.HeaderText = "KullaniciID";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 71;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Ad";
            this.dataGridViewTextBoxColumn18.HeaderText = "Ad";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 80;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "TipAdi";
            this.dataGridViewTextBoxColumn21.HeaderText = "TipAdi";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 70;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "KullaniciID";
            this.dataGridViewTextBoxColumn19.HeaderText = "KullaniciID";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 80;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Aciklama";
            this.dataGridViewTextBoxColumn20.HeaderText = "Aciklama";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 80;
            // 
            // KullaniciOnayli
            // 
            this.KullaniciOnayli.DataPropertyName = "KullaniciOnayliMi";
            this.KullaniciOnayli.HeaderText = "KullaniciOnayliMi";
            this.KullaniciOnayli.MinimumWidth = 6;
            this.KullaniciOnayli.Name = "KullaniciOnayli";
            this.KullaniciOnayli.ReadOnly = true;
            this.KullaniciOnayli.Width = 60;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "KullaniciOnayAciklamasi";
            this.dataGridViewTextBoxColumn15.HeaderText = "KullaniciOnayAciklamasi";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 80;
            // 
            // YoneticiOnayli
            // 
            this.YoneticiOnayli.DataPropertyName = "YoneticiOnayliMi";
            this.YoneticiOnayli.HeaderText = "YoneticiOnayliMi";
            this.YoneticiOnayli.MinimumWidth = 6;
            this.YoneticiOnayli.Name = "YoneticiOnayli";
            this.YoneticiOnayli.ReadOnly = true;
            this.YoneticiOnayli.Visible = false;
            this.YoneticiOnayli.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "YoneticiOnayAciklama";
            this.dataGridViewTextBoxColumn16.HeaderText = "YoneticiOnayAciklama";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Visible = false;
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "KayitTarihi";
            this.dataGridViewTextBoxColumn22.HeaderText = "KayitTarihi";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Width = 125;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "BaslangicTarihi";
            this.dataGridViewTextBoxColumn23.HeaderText = "BaslangicTarihi";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Width = 125;
            // 
            // dataGridViewCheckBoxColumn8
            // 
            this.dataGridViewCheckBoxColumn8.DataPropertyName = "TamamlandiMi";
            this.dataGridViewCheckBoxColumn8.HeaderText = "TamamlandiMi";
            this.dataGridViewCheckBoxColumn8.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn8.Name = "dataGridViewCheckBoxColumn8";
            this.dataGridViewCheckBoxColumn8.ReadOnly = true;
            this.dataGridViewCheckBoxColumn8.Visible = false;
            this.dataGridViewCheckBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "BitisTarihi";
            this.dataGridViewTextBoxColumn24.HeaderText = "BitisTarihi";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Width = 125;
            // 
            // CtxStrip
            // 
            this.CtxStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CtxStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıOnayıToolStripMenuItem,
            this.kullanıcıOnayAçıklamaToolStripMenuItem,
            this.yöneticiOnayıToolStripMenuItem,
            this.yöneticiOnayAçıklamaToolStripMenuItem});
            this.CtxStrip.Name = "contextMenuStrip1";
            this.CtxStrip.Size = new System.Drawing.Size(238, 100);
            // 
            // kullanıcıOnayıToolStripMenuItem
            // 
            this.kullanıcıOnayıToolStripMenuItem.Name = "kullanıcıOnayıToolStripMenuItem";
            this.kullanıcıOnayıToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.kullanıcıOnayıToolStripMenuItem.Text = "Kullanıcı Onayı";
            this.kullanıcıOnayıToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıOnayıToolStripMenuItem_Click);
            // 
            // kullanıcıOnayAçıklamaToolStripMenuItem
            // 
            this.kullanıcıOnayAçıklamaToolStripMenuItem.Name = "kullanıcıOnayAçıklamaToolStripMenuItem";
            this.kullanıcıOnayAçıklamaToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.kullanıcıOnayAçıklamaToolStripMenuItem.Text = "Kullanıcı Onay Açıklama";
            this.kullanıcıOnayAçıklamaToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıOnayAçıklamaToolStripMenuItem_Click);
            // 
            // yöneticiOnayıToolStripMenuItem
            // 
            this.yöneticiOnayıToolStripMenuItem.Name = "yöneticiOnayıToolStripMenuItem";
            this.yöneticiOnayıToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.yöneticiOnayıToolStripMenuItem.Text = "Yönetici Onayı";
            this.yöneticiOnayıToolStripMenuItem.Click += new System.EventHandler(this.yöneticiOnayıToolStripMenuItem_Click);
            // 
            // yöneticiOnayAçıklamaToolStripMenuItem
            // 
            this.yöneticiOnayAçıklamaToolStripMenuItem.Name = "yöneticiOnayAçıklamaToolStripMenuItem";
            this.yöneticiOnayAçıklamaToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.yöneticiOnayAçıklamaToolStripMenuItem.Text = "Yönetici Onay Açıklama";
            this.yöneticiOnayAçıklamaToolStripMenuItem.Click += new System.EventHandler(this.yöneticiOnayAçıklamaToolStripMenuItem_Click);
            // 
            // gorevTblBindingSource
            // 
            this.gorevTblBindingSource.DataMember = "GorevTbl";
            this.gorevTblBindingSource.DataSource = this.gorevDS;
            // 
            // gorevDS
            // 
            this.gorevDS.DataSetName = "GorevDS";
            this.gorevDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ıDData
            // 
            this.ıDData.DataPropertyName = "ID";
            this.ıDData.HeaderText = "ID";
            this.ıDData.MinimumWidth = 6;
            this.ıDData.Name = "ıDData";
            this.ıDData.Width = 60;
            // 
            // KullaniciOnayliMi
            // 
            this.KullaniciOnayliMi.DataPropertyName = "KullaniciOnayliMi";
            this.KullaniciOnayliMi.HeaderText = "KullaniciOnayliMi";
            this.KullaniciOnayliMi.MinimumWidth = 6;
            this.KullaniciOnayliMi.Name = "KullaniciOnayliMi";
            this.KullaniciOnayliMi.Visible = false;
            this.KullaniciOnayliMi.Width = 60;
            // 
            // KullaniciOnayAciklamasi
            // 
            this.KullaniciOnayAciklamasi.DataPropertyName = "KullaniciOnayAciklamasi";
            this.KullaniciOnayAciklamasi.HeaderText = "KullaniciOnayAciklamasi";
            this.KullaniciOnayAciklamasi.MinimumWidth = 6;
            this.KullaniciOnayAciklamasi.Name = "KullaniciOnayAciklamasi";
            this.KullaniciOnayAciklamasi.Width = 125;
            // 
            // YoneticiOnayliMi
            // 
            this.YoneticiOnayliMi.DataPropertyName = "YoneticiOnayliMi";
            this.YoneticiOnayliMi.HeaderText = "YoneticiOnayliMi";
            this.YoneticiOnayliMi.MinimumWidth = 6;
            this.YoneticiOnayliMi.Name = "YoneticiOnayliMi";
            this.YoneticiOnayliMi.Width = 60;
            // 
            // YoneticiOnayAciklama
            // 
            this.YoneticiOnayAciklama.DataPropertyName = "YoneticiOnayAciklama";
            this.YoneticiOnayAciklama.HeaderText = "YoneticiOnayAciklama";
            this.YoneticiOnayAciklama.MinimumWidth = 6;
            this.YoneticiOnayAciklama.Name = "YoneticiOnayAciklama";
            this.YoneticiOnayAciklama.Width = 125;
            // 
            // KullaniciID
            // 
            this.KullaniciID.DataPropertyName = "KullaniciID";
            this.KullaniciID.HeaderText = "KullaniciID";
            this.KullaniciID.MinimumWidth = 6;
            this.KullaniciID.Name = "KullaniciID";
            this.KullaniciID.Width = 125;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "KullaniciOnayliMi";
            this.dataGridViewCheckBoxColumn2.HeaderText = "KullaniciOnayliMi";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "KullaniciOnayAciklamasi";
            this.dataGridViewTextBoxColumn9.HeaderText = "KullaniciOnayAciklamasi";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "YoneticiOnayliMi";
            this.dataGridViewCheckBoxColumn3.HeaderText = "YoneticiOnayliMi";
            this.dataGridViewCheckBoxColumn3.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "YoneticiOnayAciklama";
            this.dataGridViewTextBoxColumn10.HeaderText = "YoneticiOnayAciklama";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "KullaniciID";
            this.dataGridViewTextBoxColumn11.HeaderText = "KullaniciID";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // GörevTipi
            // 
            this.GörevTipi.DataPropertyName = "GörevTipi";
            this.GörevTipi.HeaderText = "GörevTipi";
            this.GörevTipi.MinimumWidth = 6;
            this.GörevTipi.Name = "GörevTipi";
            this.GörevTipi.Width = 125;
            // 
            // Aciklama
            // 
            this.Aciklama.DataPropertyName = "Aciklama";
            this.Aciklama.HeaderText = "Aciklama";
            this.Aciklama.MinimumWidth = 6;
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.Width = 125;
            // 
            // TamamlandiMi
            // 
            this.TamamlandiMi.DataPropertyName = "TamamlandiMi";
            this.TamamlandiMi.HeaderText = "TamamlandiMi";
            this.TamamlandiMi.MinimumWidth = 6;
            this.TamamlandiMi.Name = "TamamlandiMi";
            this.TamamlandiMi.Width = 125;
            // 
            // KayitTarihi
            // 
            this.KayitTarihi.DataPropertyName = "KayitTarihi";
            this.KayitTarihi.HeaderText = "KayitTarihi";
            this.KayitTarihi.MinimumWidth = 6;
            this.KayitTarihi.Name = "KayitTarihi";
            this.KayitTarihi.Width = 125;
            // 
            // BaslangicTarihi
            // 
            this.BaslangicTarihi.DataPropertyName = "BaslangicTarihi";
            this.BaslangicTarihi.HeaderText = "BaslangicTarihi";
            this.BaslangicTarihi.MinimumWidth = 6;
            this.BaslangicTarihi.Name = "BaslangicTarihi";
            this.BaslangicTarihi.Width = 125;
            // 
            // BitisTarihi
            // 
            this.BitisTarihi.DataPropertyName = "BitisTarihi";
            this.BitisTarihi.HeaderText = "BitisTarihi";
            this.BitisTarihi.MinimumWidth = 6;
            this.BitisTarihi.Name = "BitisTarihi";
            this.BitisTarihi.Width = 125;
            // 
            // TipAdi
            // 
            this.TipAdi.DataPropertyName = "TipAdi";
            this.TipAdi.HeaderText = "TipAdi";
            this.TipAdi.MinimumWidth = 6;
            this.TipAdi.Name = "TipAdi";
            this.TipAdi.Width = 125;
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "Ad";
            this.Ad.HeaderText = "Ad";
            this.Ad.MinimumWidth = 6;
            this.Ad.Name = "Ad";
            this.Ad.Width = 125;
            // 
            // KullaniciTipi
            // 
            this.KullaniciTipi.DataPropertyName = "KullaniciTipi";
            this.KullaniciTipi.HeaderText = "KullaniciTipi";
            this.KullaniciTipi.MinimumWidth = 6;
            this.KullaniciTipi.Name = "KullaniciTipi";
            this.KullaniciTipi.Width = 125;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "KullaniciOnayliMi";
            this.dataGridViewCheckBoxColumn4.HeaderText = "KullaniciOnayliMi";
            this.dataGridViewCheckBoxColumn4.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "KullaniciOnayAciklamasi";
            this.dataGridViewTextBoxColumn12.HeaderText = "KullaniciOnayAciklamasi";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.DataPropertyName = "YoneticiOnayliMi";
            this.dataGridViewCheckBoxColumn5.HeaderText = "YoneticiOnayliMi";
            this.dataGridViewCheckBoxColumn5.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            this.dataGridViewCheckBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "YoneticiOnayAciklama";
            this.dataGridViewTextBoxColumn13.HeaderText = "YoneticiOnayAciklama";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // gorevTblTableAdapter
            // 
            this.gorevTblTableAdapter.ClearBeforeFill = true;
            // 
            // gorevLogTblTableAdapter1
            // 
            this.gorevLogTblTableAdapter1.ClearBeforeFill = true;
            // 
            // GorevSayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 450);
            this.ContextMenuStrip = this.CtxStrip;
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GorevSayfası";
            this.Text = "GorevSayfası";
            this.Load += new System.EventHandler(this.GorevSayfası_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.page_Bekleyen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GorevGrid)).EndInit();
            this.CtxStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gorevTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GorevDS gorevDS;
        private System.Windows.Forms.BindingSource gorevTblBindingSource;
        private GorevDSTableAdapters.GorevTblTableAdapter gorevTblTableAdapter;
        private GorevDSTableAdapters.GorevLogTblTableAdapter gorevLogTblTableAdapter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage page_Bekleyen;
        private System.Windows.Forms.ContextMenuStrip CtxStrip;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıOnayıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıOnayAçıklamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiOnayıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiOnayAçıklamaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDData;
        private System.Windows.Forms.DataGridViewCheckBoxColumn KullaniciOnayliMi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullaniciOnayAciklamasi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn YoneticiOnayliMi;
        private System.Windows.Forms.DataGridViewTextBoxColumn YoneticiOnayAciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullaniciID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn GörevTipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TamamlandiMi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KayitTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaslangicTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullaniciTipi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridView GorevGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewCheckBoxColumn KullaniciOnayli;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewCheckBoxColumn YoneticiOnayli;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
    }
}