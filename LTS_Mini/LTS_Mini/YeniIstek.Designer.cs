namespace LTS_Mini
{
    partial class YeniIstek
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
            this.Gonderen_lbl = new System.Windows.Forms.Label();
            this.Konu_lbl = new System.Windows.Forms.Label();
            this.IstekKategorisi_lbl = new System.Windows.Forms.Label();
            this.IstekKategori_txt = new System.Windows.Forms.ComboBox();
            this.ıstekTbl1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._LTS_MiniDataSet = new LTS_Mini._LTS_MiniDataSet();
            this.ıstekKategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.konu_txt = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.TahminiBitis_date = new System.Windows.Forms.Label();
            this.yazilimci_cmb = new System.Windows.Forms.ComboBox();
            this.yazilimciAdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Yazılımcıadi_lbl = new System.Windows.Forms.Label();
            this.Tester_cmb = new System.Windows.Forms.ComboBox();
            this.testerAdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TesterAdi_lbl = new System.Windows.Forms.Label();
            this.KullaniciMesaj_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.YeniIstek_btn = new System.Windows.Forms.Button();
            this.FirmaAdi_cmb = new System.Windows.Forms.ComboBox();
            this.firmaTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.YöneticiMesaj_lbl = new System.Windows.Forms.Label();
            this.YoneticiMesaj_txt = new System.Windows.Forms.TextBox();
            this.TesterMesaj_lbl = new System.Windows.Forms.Label();
            this.TesterMesajı_txt = new System.Windows.Forms.TextBox();
            this.istekKategoriTableAdapter = new LTS_Mini._LTS_MiniDataSetTableAdapters.IstekKategoriTableAdapter();
            this.istekTbl1TableAdapter = new LTS_Mini._LTS_MiniDataSetTableAdapters.IstekTbl1TableAdapter();
            this.yazilimciAdTableAdapter = new LTS_Mini._LTS_MiniDataSetTableAdapters.YazilimciAdTableAdapter();
            this.testerAdTableAdapter = new LTS_Mini._LTS_MiniDataSetTableAdapters.TesterAdTableAdapter();
            this.firmaTblTableAdapter = new LTS_Mini._LTS_MiniDataSetTableAdapters.FirmaTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ıstekTbl1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._LTS_MiniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıstekKategoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimciAdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testerAdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaTblBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gonderen_lbl
            // 
            this.Gonderen_lbl.AutoSize = true;
            this.Gonderen_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Gonderen_lbl.Location = new System.Drawing.Point(44, 20);
            this.Gonderen_lbl.Name = "Gonderen_lbl";
            this.Gonderen_lbl.Size = new System.Drawing.Size(91, 20);
            this.Gonderen_lbl.TabIndex = 0;
            this.Gonderen_lbl.Text = "Firma Adı :";
            // 
            // Konu_lbl
            // 
            this.Konu_lbl.AutoSize = true;
            this.Konu_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Konu_lbl.Location = new System.Drawing.Point(78, 67);
            this.Konu_lbl.Name = "Konu_lbl";
            this.Konu_lbl.Size = new System.Drawing.Size(57, 20);
            this.Konu_lbl.TabIndex = 1;
            this.Konu_lbl.Text = "Konu :";
            // 
            // IstekKategorisi_lbl
            // 
            this.IstekKategorisi_lbl.AutoSize = true;
            this.IstekKategorisi_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IstekKategorisi_lbl.Location = new System.Drawing.Point(1, 109);
            this.IstekKategorisi_lbl.Name = "IstekKategorisi_lbl";
            this.IstekKategorisi_lbl.Size = new System.Drawing.Size(134, 20);
            this.IstekKategorisi_lbl.TabIndex = 2;
            this.IstekKategorisi_lbl.Text = "İstek Kategorisi :";
            // 
            // IstekKategori_txt
            // 
            this.IstekKategori_txt.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ıstekTbl1BindingSource, "IstekKategorisi", true));
            this.IstekKategori_txt.DataSource = this.ıstekKategoriBindingSource;
            this.IstekKategori_txt.DisplayMember = "IstekAdı";
            this.IstekKategori_txt.Enabled = false;
            this.IstekKategori_txt.FormattingEnabled = true;
            this.IstekKategori_txt.Location = new System.Drawing.Point(152, 109);
            this.IstekKategori_txt.Name = "IstekKategori_txt";
            this.IstekKategori_txt.Size = new System.Drawing.Size(128, 24);
            this.IstekKategori_txt.TabIndex = 7;
            this.IstekKategori_txt.ValueMember = "IstekID";
            // 
            // ıstekTbl1BindingSource
            // 
            this.ıstekTbl1BindingSource.DataMember = "IstekTbl1";
            this.ıstekTbl1BindingSource.DataSource = this._LTS_MiniDataSet;
            // 
            // _LTS_MiniDataSet
            // 
            this._LTS_MiniDataSet.DataSetName = "_LTS_MiniDataSet";
            this._LTS_MiniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ıstekKategoriBindingSource
            // 
            this.ıstekKategoriBindingSource.DataMember = "IstekKategori";
            this.ıstekKategoriBindingSource.DataSource = this._LTS_MiniDataSet;
            // 
            // konu_txt
            // 
            this.konu_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ıstekTbl1BindingSource, "Konu", true));
            this.konu_txt.Enabled = false;
            this.konu_txt.Location = new System.Drawing.Point(152, 65);
            this.konu_txt.Name = "konu_txt";
            this.konu_txt.Size = new System.Drawing.Size(128, 22);
            this.konu_txt.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ıstekTbl1BindingSource, "TahminiBitisTarihi", true));
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(545, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(146, 22);
            this.dateTimePicker2.TabIndex = 15;
            this.dateTimePicker2.Value = new System.DateTime(2024, 10, 1, 14, 11, 39, 0);
            // 
            // TahminiBitis_date
            // 
            this.TahminiBitis_date.AutoSize = true;
            this.TahminiBitis_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TahminiBitis_date.Location = new System.Drawing.Point(375, 12);
            this.TahminiBitis_date.Name = "TahminiBitis_date";
            this.TahminiBitis_date.Size = new System.Drawing.Size(164, 20);
            this.TahminiBitis_date.TabIndex = 14;
            this.TahminiBitis_date.Text = "Tahmini Bitiş Tarihi :";
            // 
            // yazilimci_cmb
            // 
            this.yazilimci_cmb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ıstekTbl1BindingSource, "Yazilimci", true));
            this.yazilimci_cmb.DataSource = this.yazilimciAdBindingSource;
            this.yazilimci_cmb.DisplayMember = "YazilimciAdi";
            this.yazilimci_cmb.Enabled = false;
            this.yazilimci_cmb.FormattingEnabled = true;
            this.yazilimci_cmb.Location = new System.Drawing.Point(158, 24);
            this.yazilimci_cmb.Name = "yazilimci_cmb";
            this.yazilimci_cmb.Size = new System.Drawing.Size(128, 24);
            this.yazilimci_cmb.TabIndex = 17;
            this.yazilimci_cmb.ValueMember = "YazilimciID";
            // 
            // yazilimciAdBindingSource
            // 
            this.yazilimciAdBindingSource.DataMember = "YazilimciAd";
            this.yazilimciAdBindingSource.DataSource = this._LTS_MiniDataSet;
            // 
            // Yazılımcıadi_lbl
            // 
            this.Yazılımcıadi_lbl.AutoSize = true;
            this.Yazılımcıadi_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yazılımcıadi_lbl.Location = new System.Drawing.Point(33, 24);
            this.Yazılımcıadi_lbl.Name = "Yazılımcıadi_lbl";
            this.Yazılımcıadi_lbl.Size = new System.Drawing.Size(86, 20);
            this.Yazılımcıadi_lbl.TabIndex = 16;
            this.Yazılımcıadi_lbl.Text = "Yazılımcı :";
            // 
            // Tester_cmb
            // 
            this.Tester_cmb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ıstekTbl1BindingSource, "Tester", true));
            this.Tester_cmb.DataSource = this.testerAdBindingSource;
            this.Tester_cmb.DisplayMember = "TesterAd";
            this.Tester_cmb.Enabled = false;
            this.Tester_cmb.FormattingEnabled = true;
            this.Tester_cmb.Location = new System.Drawing.Point(158, 71);
            this.Tester_cmb.Name = "Tester_cmb";
            this.Tester_cmb.Size = new System.Drawing.Size(128, 24);
            this.Tester_cmb.TabIndex = 19;
            this.Tester_cmb.ValueMember = "TesterID";
            // 
            // testerAdBindingSource
            // 
            this.testerAdBindingSource.DataMember = "TesterAd";
            this.testerAdBindingSource.DataSource = this._LTS_MiniDataSet;
            // 
            // TesterAdi_lbl
            // 
            this.TesterAdi_lbl.AutoSize = true;
            this.TesterAdi_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TesterAdi_lbl.Location = new System.Drawing.Point(24, 75);
            this.TesterAdi_lbl.Name = "TesterAdi_lbl";
            this.TesterAdi_lbl.Size = new System.Drawing.Size(95, 20);
            this.TesterAdi_lbl.TabIndex = 18;
            this.TesterAdi_lbl.Text = "Test Eden :";
            // 
            // KullaniciMesaj_txt
            // 
            this.KullaniciMesaj_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ıstekTbl1BindingSource, "IstekAciklamasi", true));
            this.KullaniciMesaj_txt.Enabled = false;
            this.KullaniciMesaj_txt.Location = new System.Drawing.Point(9, 182);
            this.KullaniciMesaj_txt.Multiline = true;
            this.KullaniciMesaj_txt.Name = "KullaniciMesaj_txt";
            this.KullaniciMesaj_txt.Size = new System.Drawing.Size(1030, 70);
            this.KullaniciMesaj_txt.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Metin Girin :";
            // 
            // YeniIstek_btn
            // 
            this.YeniIstek_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.YeniIstek_btn.Location = new System.Drawing.Point(-12, 409);
            this.YeniIstek_btn.Name = "YeniIstek_btn";
            this.YeniIstek_btn.Size = new System.Drawing.Size(1083, 33);
            this.YeniIstek_btn.TabIndex = 26;
            this.YeniIstek_btn.Text = "Gönder";
            this.YeniIstek_btn.UseVisualStyleBackColor = false;
            this.YeniIstek_btn.Click += new System.EventHandler(this.YeniIstek_btn_Click);
            // 
            // FirmaAdi_cmb
            // 
            this.FirmaAdi_cmb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ıstekTbl1BindingSource, "IstekGonderenKisi", true));
            this.FirmaAdi_cmb.DataSource = this.firmaTblBindingSource;
            this.FirmaAdi_cmb.DisplayMember = "FirmaAdi";
            this.FirmaAdi_cmb.Enabled = false;
            this.FirmaAdi_cmb.FormattingEnabled = true;
            this.FirmaAdi_cmb.Location = new System.Drawing.Point(152, 20);
            this.FirmaAdi_cmb.Name = "FirmaAdi_cmb";
            this.FirmaAdi_cmb.Size = new System.Drawing.Size(128, 24);
            this.FirmaAdi_cmb.TabIndex = 27;
            this.FirmaAdi_cmb.ValueMember = "FirmaID";
            this.FirmaAdi_cmb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // firmaTblBindingSource
            // 
            this.firmaTblBindingSource.DataMember = "FirmaTbl";
            this.firmaTblBindingSource.DataSource = this._LTS_MiniDataSet;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Tester_cmb);
            this.panel1.Controls.Add(this.Yazılımcıadi_lbl);
            this.panel1.Controls.Add(this.yazilimci_cmb);
            this.panel1.Controls.Add(this.TesterAdi_lbl);
            this.panel1.Location = new System.Drawing.Point(355, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 111);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.YöneticiMesaj_lbl);
            this.panel2.Controls.Add(this.YoneticiMesaj_txt);
            this.panel2.Controls.Add(this.TesterMesaj_lbl);
            this.panel2.Controls.Add(this.TesterMesajı_txt);
            this.panel2.Location = new System.Drawing.Point(9, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 117);
            this.panel2.TabIndex = 29;
            // 
            // YöneticiMesaj_lbl
            // 
            this.YöneticiMesaj_lbl.AutoSize = true;
            this.YöneticiMesaj_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YöneticiMesaj_lbl.Location = new System.Drawing.Point(533, 17);
            this.YöneticiMesaj_lbl.Name = "YöneticiMesaj_lbl";
            this.YöneticiMesaj_lbl.Size = new System.Drawing.Size(106, 17);
            this.YöneticiMesaj_lbl.TabIndex = 29;
            this.YöneticiMesaj_lbl.Text = "Yönetici Mesajı:";
            // 
            // YoneticiMesaj_txt
            // 
            this.YoneticiMesaj_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ıstekTbl1BindingSource, "YoneticiAciklama", true));
            this.YoneticiMesaj_txt.Enabled = false;
            this.YoneticiMesaj_txt.Location = new System.Drawing.Point(527, 46);
            this.YoneticiMesaj_txt.Multiline = true;
            this.YoneticiMesaj_txt.Name = "YoneticiMesaj_txt";
            this.YoneticiMesaj_txt.Size = new System.Drawing.Size(497, 53);
            this.YoneticiMesaj_txt.TabIndex = 28;
            // 
            // TesterMesaj_lbl
            // 
            this.TesterMesaj_lbl.AutoSize = true;
            this.TesterMesaj_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TesterMesaj_lbl.Location = new System.Drawing.Point(6, 17);
            this.TesterMesaj_lbl.Name = "TesterMesaj_lbl";
            this.TesterMesaj_lbl.Size = new System.Drawing.Size(97, 17);
            this.TesterMesaj_lbl.TabIndex = 27;
            this.TesterMesaj_lbl.Text = "Tester Mesajı:";
            // 
            // TesterMesajı_txt
            // 
            this.TesterMesajı_txt.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.ıstekTbl1BindingSource, "TesterAciklama", true));
            this.TesterMesajı_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ıstekTbl1BindingSource, "TesterAciklama", true));
            this.TesterMesajı_txt.Enabled = false;
            this.TesterMesajı_txt.Location = new System.Drawing.Point(6, 46);
            this.TesterMesajı_txt.Multiline = true;
            this.TesterMesajı_txt.Name = "TesterMesajı_txt";
            this.TesterMesajı_txt.Size = new System.Drawing.Size(485, 53);
            this.TesterMesajı_txt.TabIndex = 26;
            // 
            // istekKategoriTableAdapter
            // 
            this.istekKategoriTableAdapter.ClearBeforeFill = true;
            // 
            // istekTbl1TableAdapter
            // 
            this.istekTbl1TableAdapter.ClearBeforeFill = true;
            // 
            // yazilimciAdTableAdapter
            // 
            this.yazilimciAdTableAdapter.ClearBeforeFill = true;
            // 
            // testerAdTableAdapter
            // 
            this.testerAdTableAdapter.ClearBeforeFill = true;
            // 
            // firmaTblTableAdapter
            // 
            this.firmaTblTableAdapter.ClearBeforeFill = true;
            // 
            // YeniIstek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1070, 454);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FirmaAdi_cmb);
            this.Controls.Add(this.YeniIstek_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KullaniciMesaj_txt);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.TahminiBitis_date);
            this.Controls.Add(this.konu_txt);
            this.Controls.Add(this.IstekKategori_txt);
            this.Controls.Add(this.IstekKategorisi_lbl);
            this.Controls.Add(this.Konu_lbl);
            this.Controls.Add(this.Gonderen_lbl);
            this.Name = "YeniIstek";
            this.Text = "YeniIstek";
            this.Load += new System.EventHandler(this.YeniIstek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ıstekTbl1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._LTS_MiniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıstekKategoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimciAdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testerAdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaTblBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Gonderen_lbl;
        private System.Windows.Forms.Label Konu_lbl;
        private System.Windows.Forms.Label IstekKategorisi_lbl;
        private System.Windows.Forms.ComboBox IstekKategori_txt;
        private System.Windows.Forms.TextBox konu_txt;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label TahminiBitis_date;
        private System.Windows.Forms.ComboBox yazilimci_cmb;
        private System.Windows.Forms.Label Yazılımcıadi_lbl;
        private System.Windows.Forms.ComboBox Tester_cmb;
        private System.Windows.Forms.Label TesterAdi_lbl;
     
        private System.Windows.Forms.TextBox KullaniciMesaj_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button YeniIstek_btn;
        private System.Windows.Forms.ComboBox FirmaAdi_cmb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label YöneticiMesaj_lbl;
        private System.Windows.Forms.TextBox YoneticiMesaj_txt;
        private System.Windows.Forms.Label TesterMesaj_lbl;
        private System.Windows.Forms.TextBox TesterMesajı_txt;
        private _LTS_MiniDataSet _LTS_MiniDataSet;
        private System.Windows.Forms.BindingSource ıstekKategoriBindingSource;
        private _LTS_MiniDataSetTableAdapters.IstekKategoriTableAdapter istekKategoriTableAdapter;
        private System.Windows.Forms.BindingSource ıstekTbl1BindingSource;
        private _LTS_MiniDataSetTableAdapters.IstekTbl1TableAdapter istekTbl1TableAdapter;
        private System.Windows.Forms.BindingSource yazilimciAdBindingSource;
        private _LTS_MiniDataSetTableAdapters.YazilimciAdTableAdapter yazilimciAdTableAdapter;
        private System.Windows.Forms.BindingSource testerAdBindingSource;
        private _LTS_MiniDataSetTableAdapters.TesterAdTableAdapter testerAdTableAdapter;
        private System.Windows.Forms.BindingSource firmaTblBindingSource;
        private _LTS_MiniDataSetTableAdapters.FirmaTblTableAdapter firmaTblTableAdapter;
    }
}