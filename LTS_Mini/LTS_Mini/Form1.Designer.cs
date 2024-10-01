namespace LTS_Mini
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
            this.LoginUserName_lbl = new System.Windows.Forms.Label();
            this.Login_btn = new System.Windows.Forms.Button();
            this.LoginUsername_txt = new System.Windows.Forms.TextBox();
            this.LoginSifre_txt = new System.Windows.Forms.TextBox();
            this.LoginSifre_lbl = new System.Windows.Forms.Label();
            this.Kayit_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginUserName_lbl
            // 
            this.LoginUserName_lbl.AutoSize = true;
            this.LoginUserName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginUserName_lbl.Location = new System.Drawing.Point(186, 129);
            this.LoginUserName_lbl.Name = "LoginUserName_lbl";
            this.LoginUserName_lbl.Size = new System.Drawing.Size(130, 25);
            this.LoginUserName_lbl.TabIndex = 0;
            this.LoginUserName_lbl.Text = "Kullanıcı Adı :";
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(314, 260);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(107, 42);
            this.Login_btn.TabIndex = 1;
            this.Login_btn.Text = "Giriş";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // LoginUsername_txt
            // 
            this.LoginUsername_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginUsername_txt.Location = new System.Drawing.Point(341, 124);
            this.LoginUsername_txt.Name = "LoginUsername_txt";
            this.LoginUsername_txt.Size = new System.Drawing.Size(162, 30);
            this.LoginUsername_txt.TabIndex = 2;
            this.LoginUsername_txt.TabStop = false;
            // 
            // LoginSifre_txt
            // 
            this.LoginSifre_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginSifre_txt.Location = new System.Drawing.Point(341, 194);
            this.LoginSifre_txt.Name = "LoginSifre_txt";
            this.LoginSifre_txt.Size = new System.Drawing.Size(162, 30);
            this.LoginSifre_txt.TabIndex = 4;
            this.LoginSifre_txt.TabStop = false;
            // 
            // LoginSifre_lbl
            // 
            this.LoginSifre_lbl.AutoSize = true;
            this.LoginSifre_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginSifre_lbl.Location = new System.Drawing.Point(253, 197);
            this.LoginSifre_lbl.Name = "LoginSifre_lbl";
            this.LoginSifre_lbl.Size = new System.Drawing.Size(63, 25);
            this.LoginSifre_lbl.TabIndex = 3;
            this.LoginSifre_lbl.Text = "Şifre :";
            // 
            // Kayit_lbl
            // 
            this.Kayit_lbl.AutoSize = true;
            this.Kayit_lbl.Location = new System.Drawing.Point(268, 322);
            this.Kayit_lbl.Name = "Kayit_lbl";
            this.Kayit_lbl.Size = new System.Drawing.Size(204, 16);
            this.Kayit_lbl.TabIndex = 5;
            this.Kayit_lbl.Text = "Hesabın Yok mu? Hesap Oluştur.";
            this.Kayit_lbl.Click += new System.EventHandler(this.Kayit_lbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Kayit_lbl);
            this.Controls.Add(this.LoginSifre_txt);
            this.Controls.Add(this.LoginSifre_lbl);
            this.Controls.Add(this.LoginUsername_txt);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.LoginUserName_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginUserName_lbl;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.TextBox LoginUsername_txt;
        private System.Windows.Forms.TextBox LoginSifre_txt;
        private System.Windows.Forms.Label LoginSifre_lbl;
        private System.Windows.Forms.Label Kayit_lbl;
    }
}

