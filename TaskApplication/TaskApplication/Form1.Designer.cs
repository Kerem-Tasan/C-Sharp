namespace TaskApplication
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GirisKullaniciAdi_lbl = new System.Windows.Forms.Label();
            this.Giris_btn = new System.Windows.Forms.Button();
            this.Giris_txt = new System.Windows.Forms.TextBox();
            this.GirisSifre_txt = new System.Windows.Forms.TextBox();
            this.GirisSifre_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kullaniciTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gorevDS = new TaskApplication.GorevDS();
            this.kullaniciTblTableAdapter = new TaskApplication.GorevDSTableAdapters.KullaniciTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevDS)).BeginInit();
            this.SuspendLayout();
            // 
            // GirisKullaniciAdi_lbl
            // 
            this.GirisKullaniciAdi_lbl.AutoSize = true;
            this.GirisKullaniciAdi_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisKullaniciAdi_lbl.Location = new System.Drawing.Point(179, 104);
            this.GirisKullaniciAdi_lbl.Name = "GirisKullaniciAdi_lbl";
            this.GirisKullaniciAdi_lbl.Size = new System.Drawing.Size(144, 26);
            this.GirisKullaniciAdi_lbl.TabIndex = 0;
            this.GirisKullaniciAdi_lbl.Text = "Kullanıcı Adı :";
            // 
            // Giris_btn
            // 
            this.Giris_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Giris_btn.Location = new System.Drawing.Point(288, 265);
            this.Giris_btn.Name = "Giris_btn";
            this.Giris_btn.Size = new System.Drawing.Size(135, 39);
            this.Giris_btn.TabIndex = 1;
            this.Giris_btn.Text = "Giriş Yap";
            this.Giris_btn.UseVisualStyleBackColor = true;
            this.Giris_btn.Click += new System.EventHandler(this.Giris_btn_Click);
            // 
            // Giris_txt
            // 
            this.Giris_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Giris_txt.Location = new System.Drawing.Point(360, 98);
            this.Giris_txt.Name = "Giris_txt";
            this.Giris_txt.Size = new System.Drawing.Size(180, 32);
            this.Giris_txt.TabIndex = 2;
            // 
            // GirisSifre_txt
            // 
            this.GirisSifre_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisSifre_txt.Location = new System.Drawing.Point(360, 181);
            this.GirisSifre_txt.Name = "GirisSifre_txt";
            this.GirisSifre_txt.Size = new System.Drawing.Size(180, 32);
            this.GirisSifre_txt.TabIndex = 4;
            // 
            // GirisSifre_lbl
            // 
            this.GirisSifre_lbl.AutoSize = true;
            this.GirisSifre_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisSifre_lbl.Location = new System.Drawing.Point(254, 187);
            this.GirisSifre_lbl.Name = "GirisSifre_lbl";
            this.GirisSifre_lbl.Size = new System.Drawing.Size(69, 26);
            this.GirisSifre_lbl.TabIndex = 3;
            this.GirisSifre_lbl.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(256, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hesabınız mı yok ? Kayıt Ol !";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GirisSifre_txt);
            this.Controls.Add(this.GirisSifre_lbl);
            this.Controls.Add(this.Giris_txt);
            this.Controls.Add(this.Giris_btn);
            this.Controls.Add(this.GirisKullaniciAdi_lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorevDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GirisKullaniciAdi_lbl;
        private System.Windows.Forms.Button Giris_btn;
        private System.Windows.Forms.TextBox Giris_txt;
        private System.Windows.Forms.TextBox GirisSifre_txt;
        private System.Windows.Forms.Label GirisSifre_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource kullaniciTblBindingSource;
        private GorevDS gorevDS;
        private GorevDSTableAdapters.KullaniciTblTableAdapter kullaniciTblTableAdapter;
    }
}

