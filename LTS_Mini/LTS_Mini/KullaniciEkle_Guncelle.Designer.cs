namespace LTS_Mini
{
    partial class KullaniciEkle_Guncelle
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
            this.fullname_lbl = new System.Windows.Forms.Label();
            this.KullaniciGrud_btn = new System.Windows.Forms.Button();
            this.KullaniciAdi_txt = new System.Windows.Forms.TextBox();
            this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._LTS_MiniDataSet = new LTS_Mini._LTS_MiniDataSet();
            this.kullanicisifre_txt = new System.Windows.Forms.TextBox();
            this.KullaniciSifre_lbl = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kullaniciTipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullaniciTableAdapter = new LTS_Mini._LTS_MiniDataSetTableAdapters.KullaniciTableAdapter();
            this.kullaniciTipTableAdapter = new LTS_Mini._LTS_MiniDataSetTableAdapters.KullaniciTipTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._LTS_MiniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciTipBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fullname_lbl
            // 
            this.fullname_lbl.AutoSize = true;
            this.fullname_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fullname_lbl.Location = new System.Drawing.Point(173, 115);
            this.fullname_lbl.Name = "fullname_lbl";
            this.fullname_lbl.Size = new System.Drawing.Size(100, 25);
            this.fullname_lbl.TabIndex = 0;
            this.fullname_lbl.Text = "Ad/Soyad";
            // 
            // KullaniciGrud_btn
            // 
            this.KullaniciGrud_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciGrud_btn.Location = new System.Drawing.Point(294, 319);
            this.KullaniciGrud_btn.Name = "KullaniciGrud_btn";
            this.KullaniciGrud_btn.Size = new System.Drawing.Size(132, 35);
            this.KullaniciGrud_btn.TabIndex = 1;
            this.KullaniciGrud_btn.Text = "Ekle";
            this.KullaniciGrud_btn.UseVisualStyleBackColor = true;
            this.KullaniciGrud_btn.Click += new System.EventHandler(this.KullaniciGrud_btn_Click);
            // 
            // KullaniciAdi_txt
            // 
            this.KullaniciAdi_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource, "AdSoyad", true));
            this.KullaniciAdi_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciAdi_txt.Location = new System.Drawing.Point(328, 115);
            this.KullaniciAdi_txt.Name = "KullaniciAdi_txt";
            this.KullaniciAdi_txt.Size = new System.Drawing.Size(163, 30);
            this.KullaniciAdi_txt.TabIndex = 2;
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
            // kullanicisifre_txt
            // 
            this.kullanicisifre_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource, "Sifre", true));
            this.kullanicisifre_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanicisifre_txt.Location = new System.Drawing.Point(328, 169);
            this.kullanicisifre_txt.Name = "kullanicisifre_txt";
            this.kullanicisifre_txt.Size = new System.Drawing.Size(163, 30);
            this.kullanicisifre_txt.TabIndex = 4;
            // 
            // KullaniciSifre_lbl
            // 
            this.KullaniciSifre_lbl.AutoSize = true;
            this.KullaniciSifre_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciSifre_lbl.Location = new System.Drawing.Point(212, 175);
            this.KullaniciSifre_lbl.Name = "KullaniciSifre_lbl";
            this.KullaniciSifre_lbl.Size = new System.Drawing.Size(52, 25);
            this.KullaniciSifre_lbl.TabIndex = 3;
            this.KullaniciSifre_lbl.Text = "Şifre";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource, "KullaniciAdi", true));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(328, 223);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(163, 30);
            this.textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(143, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kullanıcı Adı :";
            // 
            // kullaniciTipBindingSource
            // 
            this.kullaniciTipBindingSource.DataMember = "KullaniciTip";
            this.kullaniciTipBindingSource.DataSource = this._LTS_MiniDataSet;
            // 
            // kullaniciTableAdapter
            // 
            this.kullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // kullaniciTipTableAdapter
            // 
            this.kullaniciTipTableAdapter.ClearBeforeFill = true;
            // 
            // KullaniciEkle_Guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kullanicisifre_txt);
            this.Controls.Add(this.KullaniciSifre_lbl);
            this.Controls.Add(this.KullaniciAdi_txt);
            this.Controls.Add(this.KullaniciGrud_btn);
            this.Controls.Add(this.fullname_lbl);
            this.Name = "KullaniciEkle_Guncelle";
            this.Text = "KullaniciEkle_Guncelle";
            this.Load += new System.EventHandler(this.KullaniciEkle_Guncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._LTS_MiniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciTipBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fullname_lbl;
        private System.Windows.Forms.Button KullaniciGrud_btn;
        private System.Windows.Forms.TextBox KullaniciAdi_txt;
        private System.Windows.Forms.TextBox kullanicisifre_txt;
        private System.Windows.Forms.Label KullaniciSifre_lbl;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource kullaniciBindingSource;
        private _LTS_MiniDataSet _LTS_MiniDataSet;
        private _LTS_MiniDataSetTableAdapters.KullaniciTableAdapter kullaniciTableAdapter;
        private System.Windows.Forms.BindingSource kullaniciTipBindingSource;
        private _LTS_MiniDataSetTableAdapters.KullaniciTipTableAdapter kullaniciTipTableAdapter;
    }
}