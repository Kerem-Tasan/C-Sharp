namespace TheModul
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
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_kad = new System.Windows.Forms.TextBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ds_modul = new TheModul.ModulDBDataSet();
            this.bs_Kullanici = new System.Windows.Forms.BindingSource(this.components);
            this.Kullanici_TA = new TheModul.ModulDBDataSetTableAdapters.KullaniciTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ds_modul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Kullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_sifre
            // 
            this.txt_sifre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_Kullanici, "Sifre", true));
            this.txt_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.Location = new System.Drawing.Point(349, 224);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(195, 28);
            this.txt_sifre.TabIndex = 2;
            // 
            // txt_kad
            // 
            this.txt_kad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_Kullanici, "KAd", true));
            this.txt_kad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kad.Location = new System.Drawing.Point(349, 164);
            this.txt_kad.Name = "txt_kad";
            this.txt_kad.Size = new System.Drawing.Size(195, 28);
            this.txt_kad.TabIndex = 1;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(317, 307);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(96, 29);
            this.btn_Ekle.TabIndex = 3;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // txt_ad
            // 
            this.txt_ad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_Kullanici, "Ad", true));
            this.txt_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Location = new System.Drawing.Point(349, 98);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(195, 28);
            this.txt_ad.TabIndex = 0;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.Location = new System.Drawing.Point(270, 224);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(57, 24);
            this.lbl_sifre.TabIndex = 13;
            this.lbl_sifre.Text = "Şifre :";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad.Location = new System.Drawing.Point(270, 98);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(48, 24);
            this.lbl_ad.TabIndex = 12;
            this.lbl_ad.Text = "Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(204, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // ds_modul
            // 
            this.ds_modul.DataSetName = "ModulDBDataSet";
            this.ds_modul.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bs_Kullanici
            // 
            this.bs_Kullanici.DataMember = "KullaniciTbl";
            this.bs_Kullanici.DataSource = this.ds_modul;
            // 
            // Kullanici_TA
            // 
            this.Kullanici_TA.ClearBeforeFill = true;
            // 
            // KullaniciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 454);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kad);
            this.Controls.Add(this.btn_Ekle);
            this.Name = "KullaniciIslemleri";
            this.Text = "KullaniciIslemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KullaniciIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_modul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Kullanici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_kad;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label label1;
        private ModulDBDataSet ds_modul;
        private System.Windows.Forms.BindingSource bs_Kullanici;
        private ModulDBDataSetTableAdapters.KullaniciTblTableAdapter Kullanici_TA;
    }
}