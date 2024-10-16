namespace OtomasyonApp
{
    partial class UpdatePopUp
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
            this.hesapAltGrupDbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cardDBDataSet = new OtomasyonApp.CardDBDataSet();
            this.hesapAltGrupDbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.hesapGrupDBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hesapGrupDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.hesapKartTuruBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.hesapKartTuruBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hesapKartTuruBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hesapKartTuruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.hesapKartTipiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hesapKartTipiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hesapKartTipiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cardDBDataSet1 = new OtomasyonApp.CardDBDataSet();
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
            this.label11 = new System.Windows.Forms.Label();
            this.hesapKartTipiTableAdapter = new OtomasyonApp.CardDBDataSetTableAdapters.HesapKartTipiTableAdapter();
            this.hesapKartTuruTableAdapter = new OtomasyonApp.CardDBDataSetTableAdapters.HesapKartTuruTableAdapter();
            this.hesapGrupDBTableAdapter = new OtomasyonApp.CardDBDataSetTableAdapters.HesapGrupDBTableAdapter();
            this.hesapAltGrupDbTableAdapter = new OtomasyonApp.CardDBDataSetTableAdapters.HesapAltGrupDbTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.hesapAltGrupDbBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapAltGrupDbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapGrupDBBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapGrupDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartTuruBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartTuruBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartTuruBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartTuruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartTipiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartTipiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartTipiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDBDataSet1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 41);
            this.button1.TabIndex = 39;
            this.button1.Text = "Onayla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.hesapAltGrupDbBindingSource1, "AltGrupAdı", true));
            this.comboBox4.DataSource = this.hesapAltGrupDbBindingSource;
            this.comboBox4.DisplayMember = "AltGrupAdı";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(577, 304);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(141, 24);
            this.comboBox4.TabIndex = 38;
            this.comboBox4.ValueMember = "AltGrupId";
            // 
            // hesapAltGrupDbBindingSource1
            // 
            this.hesapAltGrupDbBindingSource1.DataMember = "HesapAltGrupDb";
            this.hesapAltGrupDbBindingSource1.DataSource = this.cardDBDataSet;
            // 
            // cardDBDataSet
            // 
            this.cardDBDataSet.DataSetName = "CardDBDataSet";
            this.cardDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hesapAltGrupDbBindingSource
            // 
            this.hesapAltGrupDbBindingSource.DataMember = "HesapAltGrupDb";
            this.hesapAltGrupDbBindingSource.DataSource = this.cardDBDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.hesapGrupDBBindingSource1, "GrupAdı", true));
            this.comboBox3.DataSource = this.hesapGrupDBBindingSource;
            this.comboBox3.DisplayMember = "GrupAdı";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(577, 248);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(141, 24);
            this.comboBox3.TabIndex = 37;
            this.comboBox3.ValueMember = "GrupID";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // hesapGrupDBBindingSource1
            // 
            this.hesapGrupDBBindingSource1.DataMember = "HesapGrupDB";
            this.hesapGrupDBBindingSource1.DataSource = this.cardDBDataSet;
            // 
            // hesapGrupDBBindingSource
            // 
            this.hesapGrupDBBindingSource.DataMember = "HesapGrupDB";
            this.hesapGrupDBBindingSource.DataSource = this.cardDBDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.hesapKartTuruBindingSource3, "TurAdı", true));
            this.comboBox2.DataSource = this.hesapKartTuruBindingSource1;
            this.comboBox2.DisplayMember = "TurAdı";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(577, 195);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(141, 24);
            this.comboBox2.TabIndex = 36;
            this.comboBox2.ValueMember = "TurID";
            // 
            // hesapKartTuruBindingSource3
            // 
            this.hesapKartTuruBindingSource3.DataMember = "HesapKartTuru";
            this.hesapKartTuruBindingSource3.DataSource = this.cardDBDataSet;
            // 
            // hesapKartTuruBindingSource1
            // 
            this.hesapKartTuruBindingSource1.DataMember = "HesapKartTuru";
            this.hesapKartTuruBindingSource1.DataSource = this.cardDBDataSet;
            // 
            // hesapKartTuruBindingSource2
            // 
            this.hesapKartTuruBindingSource2.DataMember = "HesapKartTuru";
            this.hesapKartTuruBindingSource2.DataSource = this.cardDBDataSet;
            // 
            // hesapKartTuruBindingSource
            // 
            this.hesapKartTuruBindingSource.DataMember = "HesapKartTuru";
            this.hesapKartTuruBindingSource.DataSource = this.cardDBDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.hesapKartTipiBindingSource, "TipAdı", true));
            this.comboBox1.DataSource = this.hesapKartTipiBindingSource2;
            this.comboBox1.DisplayMember = "TipAdı";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(577, 141);
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
            // hesapKartTipiBindingSource2
            // 
            this.hesapKartTipiBindingSource2.DataMember = "HesapKartTipi";
            this.hesapKartTipiBindingSource2.DataSource = this.cardDBDataSet;
            // 
            // hesapKartTipiBindingSource1
            // 
            this.hesapKartTipiBindingSource1.DataMember = "HesapKartTipi";
            this.hesapKartTipiBindingSource1.DataSource = this.cardDBDataSet1;
            // 
            // cardDBDataSet1
            // 
            this.cardDBDataSet1.DataSetName = "CardDBDataSet";
            this.cardDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(282, 368);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(159, 65);
            this.textBox5.TabIndex = 34;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(282, 304);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(133, 28);
            this.textBox4.TabIndex = 33;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(282, 248);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 28);
            this.textBox3.TabIndex = 32;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(282, 192);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 23);
            this.textBox2.TabIndex = 31;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 138);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 26);
            this.textBox1.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(461, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Alt Grup Adı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(486, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Grup Adı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(498, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Tur Adı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(500, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Tip Adı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Adres :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "TC No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Vergi No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Vergi Dairesi : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ünvan : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(158, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(638, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "Hesap Kartı Eklemek için tüm alanları doldurun!";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(943, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 39);
            this.label11.TabIndex = 40;
            this.label11.Text = "<<";
            this.label11.Click += new System.EventHandler(this.label11_Click);
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
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1027, 27);
            this.fillByToolStrip.TabIndex = 42;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 24);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // UpdatePopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 527);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.label11);
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
            this.Name = "UpdatePopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdatePopUp";
            this.Load += new System.EventHandler(this.UpdatePopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hesapAltGrupDbBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapAltGrupDbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapGrupDBBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapGrupDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartTuruBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartTuruBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartTuruBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartTuruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartTipiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartTipiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartTipiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDBDataSet1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
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
        private System.Windows.Forms.Label label11;
        private CardDBDataSet cardDBDataSet;
        private System.Windows.Forms.BindingSource hesapKartTipiBindingSource;
        private CardDBDataSetTableAdapters.HesapKartTipiTableAdapter hesapKartTipiTableAdapter;
        private System.Windows.Forms.BindingSource hesapKartTuruBindingSource;
        private CardDBDataSetTableAdapters.HesapKartTuruTableAdapter hesapKartTuruTableAdapter;
        private System.Windows.Forms.BindingSource hesapKartTuruBindingSource1;
        private System.Windows.Forms.BindingSource hesapGrupDBBindingSource;
        private CardDBDataSetTableAdapters.HesapGrupDBTableAdapter hesapGrupDBTableAdapter;
        private System.Windows.Forms.BindingSource hesapGrupDBBindingSource1;
        private System.Windows.Forms.BindingSource hesapAltGrupDbBindingSource;
        private CardDBDataSetTableAdapters.HesapAltGrupDbTableAdapter hesapAltGrupDbTableAdapter;
        private System.Windows.Forms.BindingSource hesapAltGrupDbBindingSource1;
        private CardDBDataSet cardDBDataSet1;
        private System.Windows.Forms.BindingSource hesapKartTipiBindingSource1;
        private System.Windows.Forms.BindingSource hesapKartTuruBindingSource3;
        private System.Windows.Forms.BindingSource hesapKartTuruBindingSource2;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.BindingSource hesapKartTipiBindingSource2;
    }
}