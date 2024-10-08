namespace TaskApplication
{
    partial class KullanicEkle_Guncelle
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
            this.KullaniciAdi_lbl = new System.Windows.Forms.Label();
            this.Ad_txt = new System.Windows.Forms.TextBox();
            this.gorevDS = new TaskApplication.GorevDS();
            this.kayit_btn = new System.Windows.Forms.Button();
            this.K_ad_txt = new System.Windows.Forms.TextBox();
            this.Ad_lbl = new System.Windows.Forms.Label();
            this.Sifre_txt = new System.Windows.Forms.TextBox();
            this.Sifre_lbl = new System.Windows.Forms.Label();
            this.lbl_Tip = new System.Windows.Forms.Label();
            this.bsKullanici = new System.Windows.Forms.BindingSource(this.components);
            this.bsKullaniciTipi = new System.Windows.Forms.BindingSource(this.components);
            this.dtKullaniciTipi = new TaskApplication.GorevDSTableAdapters.KullaniciTipiTableAdapter();
            this.dtKullanici = new TaskApplication.GorevDSTableAdapters.KullaniciTblTableAdapter();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gorevDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKullanici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKullaniciTipi)).BeginInit();
            this.SuspendLayout();
            // 
            // KullaniciAdi_lbl
            // 
            this.KullaniciAdi_lbl.AutoSize = true;
            this.KullaniciAdi_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciAdi_lbl.Location = new System.Drawing.Point(197, 160);
            this.KullaniciAdi_lbl.Name = "KullaniciAdi_lbl";
            this.KullaniciAdi_lbl.Size = new System.Drawing.Size(130, 25);
            this.KullaniciAdi_lbl.TabIndex = 0;
            this.KullaniciAdi_lbl.Text = "Kullanıcı Adı :";
            // 
            // Ad_txt
            // 
            this.Ad_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsKullanici, "Ad", true));
            this.Ad_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ad_txt.Location = new System.Drawing.Point(360, 85);
            this.Ad_txt.Name = "Ad_txt";
            this.Ad_txt.Size = new System.Drawing.Size(181, 30);
            this.Ad_txt.TabIndex = 1;
            // 
            // gorevDS
            // 
            this.gorevDS.DataSetName = "GorevDS";
            this.gorevDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kayit_btn
            // 
            this.kayit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayit_btn.Location = new System.Drawing.Point(299, 359);
            this.kayit_btn.Name = "kayit_btn";
            this.kayit_btn.Size = new System.Drawing.Size(124, 38);
            this.kayit_btn.TabIndex = 2;
            this.kayit_btn.Text = "Kaydet";
            this.kayit_btn.UseVisualStyleBackColor = true;
            this.kayit_btn.Click += new System.EventHandler(this.kayit_btn_Click);
            // 
            // K_ad_txt
            // 
            this.K_ad_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsKullanici, "KullaniciAdi", true));
            this.K_ad_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.K_ad_txt.Location = new System.Drawing.Point(360, 155);
            this.K_ad_txt.Name = "K_ad_txt";
            this.K_ad_txt.Size = new System.Drawing.Size(181, 30);
            this.K_ad_txt.TabIndex = 4;
            // 
            // Ad_lbl
            // 
            this.Ad_lbl.AutoSize = true;
            this.Ad_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ad_lbl.Location = new System.Drawing.Point(212, 85);
            this.Ad_lbl.Name = "Ad_lbl";
            this.Ad_lbl.Size = new System.Drawing.Size(115, 25);
            this.Ad_lbl.TabIndex = 3;
            this.Ad_lbl.Text = "Ad Soyad  :";
            // 
            // Sifre_txt
            // 
            this.Sifre_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsKullanici, "Sifre", true));
            this.Sifre_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sifre_txt.Location = new System.Drawing.Point(360, 219);
            this.Sifre_txt.Name = "Sifre_txt";
            this.Sifre_txt.Size = new System.Drawing.Size(181, 30);
            this.Sifre_txt.TabIndex = 6;
            // 
            // Sifre_lbl
            // 
            this.Sifre_lbl.AutoSize = true;
            this.Sifre_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sifre_lbl.Location = new System.Drawing.Point(264, 219);
            this.Sifre_lbl.Name = "Sifre_lbl";
            this.Sifre_lbl.Size = new System.Drawing.Size(63, 25);
            this.Sifre_lbl.TabIndex = 5;
            this.Sifre_lbl.Text = "Sifre :";
            this.Sifre_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Tip
            // 
            this.lbl_Tip.AutoSize = true;
            this.lbl_Tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Tip.Location = new System.Drawing.Point(194, 280);
            this.lbl_Tip.Name = "lbl_Tip";
            this.lbl_Tip.Size = new System.Drawing.Size(133, 25);
            this.lbl_Tip.TabIndex = 8;
            this.lbl_Tip.Text = "Kullanıcı Tipi :";
            this.lbl_Tip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Tip.Visible = false;
            // 
            // bsKullanici
            // 
            this.bsKullanici.DataMember = "KullaniciTbl";
            this.bsKullanici.DataSource = this.gorevDS;
            // 
            // bsKullaniciTipi
            // 
            this.bsKullaniciTipi.DataMember = "KullaniciTipi";
            this.bsKullaniciTipi.DataSource = this.gorevDS;
            // 
            // dtKullaniciTipi
            // 
            this.dtKullaniciTipi.ClearBeforeFill = true;
            // 
            // dtKullanici
            // 
            this.dtKullanici.ClearBeforeFill = true;
            // 
            // cmbTip
            // 
            this.cmbTip.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsKullanici, "KullaniciTipi", true));
            this.cmbTip.DataSource = this.bsKullaniciTipi;
            this.cmbTip.DisplayMember = "TipAdi";
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(360, 280);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(181, 24);
            this.cmbTip.TabIndex = 9;
            this.cmbTip.ValueMember = "ID";
            this.cmbTip.Visible = false;
            // 
            // KullanicEkle_Guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.lbl_Tip);
            this.Controls.Add(this.Sifre_txt);
            this.Controls.Add(this.Sifre_lbl);
            this.Controls.Add(this.K_ad_txt);
            this.Controls.Add(this.Ad_lbl);
            this.Controls.Add(this.kayit_btn);
            this.Controls.Add(this.Ad_txt);
            this.Controls.Add(this.KullaniciAdi_lbl);
            this.Name = "KullanicEkle_Guncelle";
            this.Text = "KullanicEkle_Guncelle";
            this.Load += new System.EventHandler(this.KullanicEkle_Guncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gorevDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKullanici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKullaniciTipi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KullaniciAdi_lbl;
        private System.Windows.Forms.TextBox Ad_txt;
        private System.Windows.Forms.Button kayit_btn;
        private System.Windows.Forms.TextBox K_ad_txt;
        private System.Windows.Forms.Label Ad_lbl;
        private System.Windows.Forms.TextBox Sifre_txt;
        private System.Windows.Forms.Label Sifre_lbl;
        private GorevDS gorevDS;
        private System.Windows.Forms.Label lbl_Tip;
        private System.Windows.Forms.BindingSource bsKullanici;
        private System.Windows.Forms.BindingSource bsKullaniciTipi;
        private GorevDSTableAdapters.KullaniciTipiTableAdapter dtKullaniciTipi;
        private GorevDSTableAdapters.KullaniciTblTableAdapter dtKullanici;
        private System.Windows.Forms.ComboBox cmbTip;
    }
}