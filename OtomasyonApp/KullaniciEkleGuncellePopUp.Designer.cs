namespace OtomasyonApp
{
    partial class KullaniciEkleGuncellePopUp
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
            this.kullaniciform_btn = new System.Windows.Forms.Button();
            this.KullaniciForm_teltxt = new System.Windows.Forms.TextBox();
            this.kullanıcıDbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset = new OtomasyonApp.dataset();
            this.KullaniciForm_mailtxt = new System.Windows.Forms.TextBox();
            this.KullaniciForm_SifreTxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.KullaniciForm_Lnametxt = new System.Windows.Forms.TextBox();
            this.KullaniciForm_adtxt = new System.Windows.Forms.TextBox();
            this.KullaniciForm_Nicktxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.kullanıcıDbTableAdapter = new OtomasyonApp.datasetTableAdapters.KullanıcıDbTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcıDbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).BeginInit();
            this.SuspendLayout();
            // 
            // kullaniciform_btn
            // 
            this.kullaniciform_btn.Location = new System.Drawing.Point(331, 311);
            this.kullaniciform_btn.Name = "kullaniciform_btn";
            this.kullaniciform_btn.Size = new System.Drawing.Size(85, 30);
            this.kullaniciform_btn.TabIndex = 26;
            this.kullaniciform_btn.Text = "EKLE";
            this.kullaniciform_btn.UseVisualStyleBackColor = true;
            this.kullaniciform_btn.Click += new System.EventHandler(this.kullaniciform_btn_Click);
            // 
            // KullaniciForm_teltxt
            // 
            this.KullaniciForm_teltxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullanıcıDbBindingSource, "TelefonNo", true));
            this.KullaniciForm_teltxt.Location = new System.Drawing.Point(466, 210);
            this.KullaniciForm_teltxt.Multiline = true;
            this.KullaniciForm_teltxt.Name = "KullaniciForm_teltxt";
            this.KullaniciForm_teltxt.Size = new System.Drawing.Size(146, 25);
            this.KullaniciForm_teltxt.TabIndex = 25;
            // 
            // kullanıcıDbBindingSource
            // 
            this.kullanıcıDbBindingSource.DataMember = "KullanıcıDb";
            this.kullanıcıDbBindingSource.DataSource = this.dataset;
            // 
            // dataset
            // 
            this.dataset.DataSetName = "dataset";
            this.dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KullaniciForm_mailtxt
            // 
            this.KullaniciForm_mailtxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullanıcıDbBindingSource, "Email", true));
            this.KullaniciForm_mailtxt.Location = new System.Drawing.Point(466, 146);
            this.KullaniciForm_mailtxt.Multiline = true;
            this.KullaniciForm_mailtxt.Name = "KullaniciForm_mailtxt";
            this.KullaniciForm_mailtxt.Size = new System.Drawing.Size(146, 22);
            this.KullaniciForm_mailtxt.TabIndex = 24;
            // 
            // KullaniciForm_SifreTxt
            // 
            this.KullaniciForm_SifreTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullanıcıDbBindingSource, "Sifre", true));
            this.KullaniciForm_SifreTxt.Location = new System.Drawing.Point(466, 71);
            this.KullaniciForm_SifreTxt.Multiline = true;
            this.KullaniciForm_SifreTxt.Name = "KullaniciForm_SifreTxt";
            this.KullaniciForm_SifreTxt.Size = new System.Drawing.Size(146, 23);
            this.KullaniciForm_SifreTxt.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(382, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 16);
            this.label14.TabIndex = 22;
            this.label14.Text = "Telefon :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(394, 148);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 16);
            this.label15.TabIndex = 21;
            this.label15.Text = "E mail :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(401, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 16);
            this.label16.TabIndex = 20;
            this.label16.Text = "Şifre :";
            // 
            // KullaniciForm_Lnametxt
            // 
            this.KullaniciForm_Lnametxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullanıcıDbBindingSource, "Soyad", true));
            this.KullaniciForm_Lnametxt.Location = new System.Drawing.Point(224, 152);
            this.KullaniciForm_Lnametxt.Multiline = true;
            this.KullaniciForm_Lnametxt.Name = "KullaniciForm_Lnametxt";
            this.KullaniciForm_Lnametxt.Size = new System.Drawing.Size(117, 19);
            this.KullaniciForm_Lnametxt.TabIndex = 19;
            // 
            // KullaniciForm_adtxt
            // 
            this.KullaniciForm_adtxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullanıcıDbBindingSource, "Ad", true));
            this.KullaniciForm_adtxt.Location = new System.Drawing.Point(224, 74);
            this.KullaniciForm_adtxt.Multiline = true;
            this.KullaniciForm_adtxt.Name = "KullaniciForm_adtxt";
            this.KullaniciForm_adtxt.Size = new System.Drawing.Size(117, 22);
            this.KullaniciForm_adtxt.TabIndex = 18;
            // 
            // KullaniciForm_Nicktxt
            // 
            this.KullaniciForm_Nicktxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullanıcıDbBindingSource, "KullanıcıAdı", true));
            this.KullaniciForm_Nicktxt.Location = new System.Drawing.Point(224, 216);
            this.KullaniciForm_Nicktxt.Multiline = true;
            this.KullaniciForm_Nicktxt.Name = "KullaniciForm_Nicktxt";
            this.KullaniciForm_Nicktxt.Size = new System.Drawing.Size(117, 23);
            this.KullaniciForm_Nicktxt.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(120, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "Soyad :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(143, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "Ad :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(88, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Kullanıcı Adı :";
            // 
            // kullanıcıDbTableAdapter
            // 
            this.kullanıcıDbTableAdapter.ClearBeforeFill = true;
            // 
            // KullaniciEkleGuncellePopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.kullaniciform_btn);
            this.Controls.Add(this.KullaniciForm_teltxt);
            this.Controls.Add(this.KullaniciForm_mailtxt);
            this.Controls.Add(this.KullaniciForm_SifreTxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.KullaniciForm_Lnametxt);
            this.Controls.Add(this.KullaniciForm_adtxt);
            this.Controls.Add(this.KullaniciForm_Nicktxt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Name = "KullaniciEkleGuncellePopUp";
            this.Text = "KullaniciEkleGuncellePopUp";
            this.Load += new System.EventHandler(this.KullaniciEkleGuncellePopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcıDbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kullaniciform_btn;
        private System.Windows.Forms.TextBox KullaniciForm_teltxt;
        private System.Windows.Forms.TextBox KullaniciForm_mailtxt;
        private System.Windows.Forms.TextBox KullaniciForm_SifreTxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox KullaniciForm_Lnametxt;
        private System.Windows.Forms.TextBox KullaniciForm_adtxt;
        private System.Windows.Forms.TextBox KullaniciForm_Nicktxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private dataset dataset;
        private System.Windows.Forms.BindingSource kullanıcıDbBindingSource;
        private datasetTableAdapters.KullanıcıDbTableAdapter kullanıcıDbTableAdapter;
    }
}