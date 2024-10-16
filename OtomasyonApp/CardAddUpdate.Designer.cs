namespace OtomasyonApp
{
    partial class CardAddUpdate
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.hesapAltGrupDbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardDBDataSet = new OtomasyonApp.CardDBDataSet();
            this.hesapKartıDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.hesapKartTuruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.hesapKartTipiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hesapKartıDBTableAdapter = new OtomasyonApp.CardDBDataSetTableAdapters.HesapKartıDBTableAdapter();
            this.hesapKartTipiTableAdapter = new OtomasyonApp.CardDBDataSetTableAdapters.HesapKartTipiTableAdapter();
            this.hesapKartTuruTableAdapter = new OtomasyonApp.CardDBDataSetTableAdapters.HesapKartTuruTableAdapter();
            this.hesapGrupDBTableAdapter = new OtomasyonApp.CardDBDataSetTableAdapters.HesapGrupDBTableAdapter();
            this.hesapAltGrupDbTableAdapter = new OtomasyonApp.CardDBDataSetTableAdapters.HesapAltGrupDbTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.hesapGrupDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hesapKartTuruBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sehir_cmb = new System.Windows.Forms.Label();
            this.ilce_cmb = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.sehirlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.ıLCEDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sehirlerTableAdapter = new OtomasyonApp.CardDBDataSetTableAdapters.SehirlerTableAdapter();
            this.iLCEDBTableAdapter = new OtomasyonApp.CardDBDataSetTableAdapters.ILCEDBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hesapAltGrupDbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartıDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartTuruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartTipiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapGrupDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartTuruBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıLCEDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 41);
            this.button1.TabIndex = 39;
            this.button1.Text = "Onayla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.hesapAltGrupDbBindingSource;
            this.comboBox4.DisplayMember = "AltGrupAdı";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(534, 251);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(141, 24);
            this.comboBox4.TabIndex = 38;
            this.comboBox4.ValueMember = "AltGrupId";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // hesapAltGrupDbBindingSource
            // 
            this.hesapAltGrupDbBindingSource.DataMember = "HesapAltGrupDb";
            this.hesapAltGrupDbBindingSource.DataSource = this.cardDBDataSet;
            // 
            // cardDBDataSet
            // 
            this.cardDBDataSet.DataSetName = "CardDBDataSet";
            this.cardDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hesapKartıDBBindingSource
            // 
            this.hesapKartıDBBindingSource.DataMember = "HesapKartıDB";
            this.hesapKartıDBBindingSource.DataSource = this.cardDBDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.hesapKartTuruBindingSource;
            this.comboBox2.DisplayMember = "TurAdı";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(534, 145);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(141, 24);
            this.comboBox2.TabIndex = 36;
            this.comboBox2.ValueMember = "TurID";
            // 
            // hesapKartTuruBindingSource
            // 
            this.hesapKartTuruBindingSource.DataMember = "HesapKartTuru";
            this.hesapKartTuruBindingSource.DataSource = this.cardDBDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.hesapKartTipiBindingSource;
            this.comboBox1.DisplayMember = "TipAdı";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(534, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 24);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.ValueMember = "TipId";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // hesapKartTipiBindingSource
            // 
            this.hesapKartTipiBindingSource.DataMember = "HesapKartTipi";
            this.hesapKartTipiBindingSource.DataSource = this.cardDBDataSet;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesapKartıDBBindingSource, "Adres", true));
            this.textBox5.Location = new System.Drawing.Point(174, 370);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(159, 65);
            this.textBox5.TabIndex = 34;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesapKartıDBBindingSource, "TC", true));
            this.textBox4.Location = new System.Drawing.Point(200, 233);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(133, 28);
            this.textBox4.TabIndex = 33;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesapKartıDBBindingSource, "VergiDaireNo", true));
            this.textBox3.Location = new System.Drawing.Point(200, 177);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 28);
            this.textBox3.TabIndex = 32;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesapKartıDBBindingSource, "VergiDairesi", true));
            this.textBox2.Location = new System.Drawing.Point(200, 121);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 23);
            this.textBox2.TabIndex = 31;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesapKartıDBBindingSource, "Unvan", true));
            this.textBox1.Location = new System.Drawing.Point(200, 84);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 26);
            this.textBox1.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(418, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Alt Grup Adı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(443, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Grup Adı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(455, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Tur Adı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Tip Adı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Adres :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "TC No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Vergi No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Vergi Dairesi : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ünvan : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(75, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(638, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "Hesap Kartı Eklemek için tüm alanları doldurun!";
            // 
            // hesapKartıDBTableAdapter
            // 
            this.hesapKartıDBTableAdapter.ClearBeforeFill = true;
            // 
            // hesapKartTipiTableAdapter
            // 
            this.hesapKartTipiTableAdapter.ClearBeforeFill = true;
            // 
            // hesapKartTuruTableAdapter
            // 
            this.hesapKartTuruTableAdapter.ClearBeforeFill = true;
            // 
            // hesapGrupDBTableAdapter
            // 
            this.hesapGrupDBTableAdapter.ClearBeforeFill = true;
            // 
            // hesapAltGrupDbTableAdapter
            // 
            this.hesapAltGrupDbTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.hesapGrupDBBindingSource;
            this.comboBox3.DisplayMember = "GrupAdı";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(534, 198);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(141, 24);
            this.comboBox3.TabIndex = 37;
            this.comboBox3.ValueMember = "GrupID";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // hesapGrupDBBindingSource
            // 
            this.hesapGrupDBBindingSource.DataMember = "HesapGrupDB";
            this.hesapGrupDBBindingSource.DataSource = this.cardDBDataSet;
            // 
            // hesapKartTuruBindingSource1
            // 
            this.hesapKartTuruBindingSource1.DataMember = "HesapKartTuru";
            this.hesapKartTuruBindingSource1.DataSource = this.cardDBDataSet;
            // 
            // sehir_cmb
            // 
            this.sehir_cmb.AutoSize = true;
            this.sehir_cmb.Location = new System.Drawing.Point(116, 289);
            this.sehir_cmb.Name = "sehir_cmb";
            this.sehir_cmb.Size = new System.Drawing.Size(67, 16);
            this.sehir_cmb.TabIndex = 40;
            this.sehir_cmb.Text = "Şehir Adı :";
            // 
            // ilce_cmb
            // 
            this.ilce_cmb.AutoSize = true;
            this.ilce_cmb.Location = new System.Drawing.Point(127, 327);
            this.ilce_cmb.Name = "ilce_cmb";
            this.ilce_cmb.Size = new System.Drawing.Size(61, 16);
            this.ilce_cmb.TabIndex = 41;
            this.ilce_cmb.Text = "İlçe Seç :";
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.sehirlerBindingSource;
            this.comboBox5.DisplayMember = "SehirAd";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(200, 281);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(133, 24);
            this.comboBox5.TabIndex = 42;
            this.comboBox5.ValueMember = "SehirId";
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // sehirlerBindingSource
            // 
            this.sehirlerBindingSource.DataMember = "Sehirler";
            this.sehirlerBindingSource.DataSource = this.cardDBDataSet;
            // 
            // comboBox6
            // 
            this.comboBox6.DataSource = this.ıLCEDBBindingSource;
            this.comboBox6.DisplayMember = "IlceAdı";
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(200, 327);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(133, 24);
            this.comboBox6.TabIndex = 43;
            this.comboBox6.ValueMember = "IlceID";
            // 
            // ıLCEDBBindingSource
            // 
            this.ıLCEDBBindingSource.DataMember = "ILCEDB";
            this.ıLCEDBBindingSource.DataSource = this.cardDBDataSet;
            // 
            // sehirlerTableAdapter
            // 
            this.sehirlerTableAdapter.ClearBeforeFill = true;
            // 
            // iLCEDBTableAdapter
            // 
            this.iLCEDBTableAdapter.ClearBeforeFill = true;
            // 
            // CardAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 466);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.ilce_cmb);
            this.Controls.Add(this.sehir_cmb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CardAddUpdate";
            this.Text = "CardAddUpdate";
            this.Load += new System.EventHandler(this.CardAddUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hesapAltGrupDbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartıDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartTuruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartTipiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapGrupDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartTuruBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıLCEDBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CardDBDataSet cardDBDataSet;
        private System.Windows.Forms.BindingSource hesapKartıDBBindingSource;
        private CardDBDataSetTableAdapters.HesapKartıDBTableAdapter hesapKartıDBTableAdapter;
        private System.Windows.Forms.BindingSource hesapKartTipiBindingSource;
        private CardDBDataSetTableAdapters.HesapKartTipiTableAdapter hesapKartTipiTableAdapter;
        private System.Windows.Forms.BindingSource hesapKartTuruBindingSource;
        private CardDBDataSetTableAdapters.HesapKartTuruTableAdapter hesapKartTuruTableAdapter;
        private System.Windows.Forms.BindingSource hesapGrupDBBindingSource;
        private CardDBDataSetTableAdapters.HesapGrupDBTableAdapter hesapGrupDBTableAdapter;
        private System.Windows.Forms.BindingSource hesapAltGrupDbBindingSource;
        private CardDBDataSetTableAdapters.HesapAltGrupDbTableAdapter hesapAltGrupDbTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource hesapKartTuruBindingSource1;
        private System.Windows.Forms.Label sehir_cmb;
        private System.Windows.Forms.Label ilce_cmb;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.BindingSource sehirlerBindingSource;
        private CardDBDataSetTableAdapters.SehirlerTableAdapter sehirlerTableAdapter;
        private System.Windows.Forms.BindingSource ıLCEDBBindingSource;
        private CardDBDataSetTableAdapters.ILCEDBTableAdapter iLCEDBTableAdapter;
    }
}