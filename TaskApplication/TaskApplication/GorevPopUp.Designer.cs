namespace TaskApplication
{
    partial class GorevPopUp
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
            this.Pop_lbl = new System.Windows.Forms.Label();
            this.ekle_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gorevTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gorevDS = new TaskApplication.GorevDS();
            this.kullaniciTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullaniciTblTableAdapter = new TaskApplication.GorevDSTableAdapters.KullaniciTblTableAdapter();
            this.gorevTblTableAdapter = new TaskApplication.GorevDSTableAdapters.GorevTblTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gorevTipiTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gorevTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gorevLogTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gorevLogTblTableAdapter = new TaskApplication.GorevDSTableAdapters.GorevLogTblTableAdapter();
            this.gorevTipiTblTableAdapter = new TaskApplication.GorevDSTableAdapters.GorevTipiTblTableAdapter();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.BaslangicTarihi_dtp = new System.Windows.Forms.DateTimePicker();
            this.Bitis_dtp = new System.Windows.Forms.DateTimePicker();
            this.BaslangicTarihi_lbl = new System.Windows.Forms.Label();
            this.BitisTarihi_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gorevTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevTipiTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevTblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevLogTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Pop_lbl
            // 
            this.Pop_lbl.AutoSize = true;
            this.Pop_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Pop_lbl.Location = new System.Drawing.Point(50, 276);
            this.Pop_lbl.Name = "Pop_lbl";
            this.Pop_lbl.Size = new System.Drawing.Size(121, 26);
            this.Pop_lbl.TabIndex = 1;
            this.Pop_lbl.Text = "Görev Adı :";
            // 
            // ekle_btn
            // 
            this.ekle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle_btn.Location = new System.Drawing.Point(378, 433);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(111, 32);
            this.ekle_btn.TabIndex = 2;
            this.ekle_btn.Text = "Ekle";
            this.ekle_btn.UseVisualStyleBackColor = true;
            this.ekle_btn.Click += new System.EventHandler(this.ekle_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcılar :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // kullaniciTblBindingSource
            // 
            this.kullaniciTblBindingSource.DataMember = "KullaniciTbl";
            this.kullaniciTblBindingSource.DataSource = this.gorevDS;
            // 
            // kullaniciTblTableAdapter
            // 
            this.kullaniciTblTableAdapter.ClearBeforeFill = true;
            // 
            // gorevTblTableAdapter
            // 
            this.gorevTblTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(57, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Açıklama :";
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gorevTblBindingSource, "Aciklama", true));
            this.txt_Aciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Aciklama.Location = new System.Drawing.Point(207, 325);
            this.txt_Aciklama.Multiline = true;
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(483, 77);
            this.txt_Aciklama.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.gorevTblBindingSource, "GörevTipi", true));
            this.comboBox1.DataSource = this.gorevTipiTblBindingSource;
            this.comboBox1.DisplayMember = "TipAdi";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(207, 281);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "ID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gorevTipiTblBindingSource
            // 
            this.gorevTipiTblBindingSource.DataMember = "GorevTipiTbl";
            this.gorevTipiTblBindingSource.DataSource = this.gorevDS;
            // 
            // gorevTblBindingSource1
            // 
            this.gorevTblBindingSource1.DataMember = "GorevTbl";
            this.gorevTblBindingSource1.DataSource = this.gorevDS;
            // 
            // gorevLogTblBindingSource
            // 
            this.gorevLogTblBindingSource.DataMember = "GorevLogTbl";
            this.gorevLogTblBindingSource.DataSource = this.gorevDS;
            // 
            // gorevLogTblTableAdapter
            // 
            this.gorevLogTblTableAdapter.ClearBeforeFill = true;
            // 
            // gorevTipiTblTableAdapter
            // 
            this.gorevTipiTblTableAdapter.ClearBeforeFill = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.AllowDrop = true;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(207, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.ScrollAlwaysVisible = true;
            this.checkedListBox1.Size = new System.Drawing.Size(261, 240);
            this.checkedListBox1.TabIndex = 10;
            this.checkedListBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkedListBox1_MouseClick);
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // BaslangicTarihi_dtp
            // 
            this.BaslangicTarihi_dtp.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gorevTblBindingSource, "BaslangicTarihi", true));
            this.BaslangicTarihi_dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BaslangicTarihi_dtp.Location = new System.Drawing.Point(645, 71);
            this.BaslangicTarihi_dtp.Name = "BaslangicTarihi_dtp";
            this.BaslangicTarihi_dtp.Size = new System.Drawing.Size(238, 26);
            this.BaslangicTarihi_dtp.TabIndex = 11;
            // 
            // Bitis_dtp
            // 
            this.Bitis_dtp.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gorevTblBindingSource, "BitisTarihi", true));
            this.Bitis_dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Bitis_dtp.Location = new System.Drawing.Point(645, 109);
            this.Bitis_dtp.Name = "Bitis_dtp";
            this.Bitis_dtp.Size = new System.Drawing.Size(238, 26);
            this.Bitis_dtp.TabIndex = 12;
            // 
            // BaslangicTarihi_lbl
            // 
            this.BaslangicTarihi_lbl.AutoSize = true;
            this.BaslangicTarihi_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BaslangicTarihi_lbl.Location = new System.Drawing.Point(474, 71);
            this.BaslangicTarihi_lbl.Name = "BaslangicTarihi_lbl";
            this.BaslangicTarihi_lbl.Size = new System.Drawing.Size(140, 20);
            this.BaslangicTarihi_lbl.TabIndex = 13;
            this.BaslangicTarihi_lbl.Text = "Başlangıç Tarihi :";
            // 
            // BitisTarihi_lbl
            // 
            this.BitisTarihi_lbl.AutoSize = true;
            this.BitisTarihi_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BitisTarihi_lbl.Location = new System.Drawing.Point(514, 109);
            this.BitisTarihi_lbl.Name = "BitisTarihi_lbl";
            this.BitisTarihi_lbl.Size = new System.Drawing.Size(100, 20);
            this.BitisTarihi_lbl.TabIndex = 14;
            this.BitisTarihi_lbl.Text = "Bitiş Tarihi :";
            // 
            // GorevPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(940, 491);
            this.Controls.Add(this.BitisTarihi_lbl);
            this.Controls.Add(this.BaslangicTarihi_lbl);
            this.Controls.Add(this.Bitis_dtp);
            this.Controls.Add(this.BaslangicTarihi_dtp);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Aciklama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ekle_btn);
            this.Controls.Add(this.Pop_lbl);
            this.Name = "GorevPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GorevPopUp";
            this.Load += new System.EventHandler(this.GrupPopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gorevTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevTipiTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevTblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevLogTblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Pop_lbl;
        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.Label label1;
        private GorevDS gorevDS;
        private System.Windows.Forms.BindingSource kullaniciTblBindingSource;
        private GorevDSTableAdapters.KullaniciTblTableAdapter kullaniciTblTableAdapter;
        private System.Windows.Forms.BindingSource gorevTblBindingSource;
        private GorevDSTableAdapters.GorevTblTableAdapter gorevTblTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource gorevTblBindingSource1;
        private System.Windows.Forms.BindingSource gorevLogTblBindingSource;
        private GorevDSTableAdapters.GorevLogTblTableAdapter gorevLogTblTableAdapter;
        private System.Windows.Forms.BindingSource gorevTipiTblBindingSource;
        private GorevDSTableAdapters.GorevTipiTblTableAdapter gorevTipiTblTableAdapter;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DateTimePicker BaslangicTarihi_dtp;
        private System.Windows.Forms.DateTimePicker Bitis_dtp;
        private System.Windows.Forms.Label BaslangicTarihi_lbl;
        private System.Windows.Forms.Label BitisTarihi_lbl;
    }
}