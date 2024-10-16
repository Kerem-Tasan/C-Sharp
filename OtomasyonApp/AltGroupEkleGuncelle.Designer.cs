namespace OtomasyonApp
{
    partial class AltGroupEkleGuncelle
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
            this.hesapAltGrupDbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardDBDataSet = new OtomasyonApp.CardDBDataSet();
            this.AltgrupGrud_btn = new System.Windows.Forms.Button();
            this.hesapAltGrupDbTableAdapter = new OtomasyonApp.CardDBDataSetTableAdapters.HesapAltGrupDbTableAdapter();
            this.altgrup_ekleguncelle_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hesapGrupDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hesapGrupDBTableAdapter = new OtomasyonApp.CardDBDataSetTableAdapters.HesapGrupDBTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.hesapGrupDBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hesapAltGrupDbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapGrupDBBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hesapGrupDBBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // AltgrupGrud_btn
            // 
            this.AltgrupGrud_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AltgrupGrud_btn.Location = new System.Drawing.Point(317, 269);
            this.AltgrupGrud_btn.Name = "AltgrupGrud_btn";
            this.AltgrupGrud_btn.Size = new System.Drawing.Size(94, 35);
            this.AltgrupGrud_btn.TabIndex = 2;
            this.AltgrupGrud_btn.Text = "Ekle";
            this.AltgrupGrud_btn.UseVisualStyleBackColor = true;
            this.AltgrupGrud_btn.Click += new System.EventHandler(this.AltgrupGrud_btn_Click);
            // 
            // hesapAltGrupDbTableAdapter
            // 
            this.hesapAltGrupDbTableAdapter.ClearBeforeFill = true;
            // 
            // altgrup_ekleguncelle_txt
            // 
            this.altgrup_ekleguncelle_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesapAltGrupDbBindingSource, "AltGrupAdı", true));
            this.altgrup_ekleguncelle_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.altgrup_ekleguncelle_txt.Location = new System.Drawing.Point(353, 187);
            this.altgrup_ekleguncelle_txt.Multiline = true;
            this.altgrup_ekleguncelle_txt.Name = "altgrup_ekleguncelle_txt";
            this.altgrup_ekleguncelle_txt.Size = new System.Drawing.Size(155, 25);
            this.altgrup_ekleguncelle_txt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(183, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alt Grup Adı :  ";
            // 
            // hesapGrupDBBindingSource
            // 
            this.hesapGrupDBBindingSource.DataMember = "HesapGrupDB";
            this.hesapGrupDBBindingSource.DataSource = this.cardDBDataSet;
            // 
            // hesapGrupDBTableAdapter
            // 
            this.hesapGrupDBTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(188, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 63);
            this.panel1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.hesapGrupDBBindingSource1;
            this.comboBox2.DisplayMember = "GrupAdı";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(168, 22);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(152, 24);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.ValueMember = "GrupID";
            // 
            // hesapGrupDBBindingSource1
            // 
            this.hesapGrupDBBindingSource1.DataMember = "HesapGrupDB";
            this.hesapGrupDBBindingSource1.DataSource = this.cardDBDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Grup Adı :  ";
            // 
            // AltGroupEkleGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 386);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.altgrup_ekleguncelle_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AltgrupGrud_btn);
            this.Name = "AltGroupEkleGuncelle";
            this.Text = "AltGroupEkleGuncelle";
            this.Load += new System.EventHandler(this.AltGroupEkleGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hesapAltGrupDbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapGrupDBBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hesapGrupDBBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AltgrupGrud_btn;
        private CardDBDataSet cardDBDataSet;
        private System.Windows.Forms.BindingSource hesapAltGrupDbBindingSource;
        private CardDBDataSetTableAdapters.HesapAltGrupDbTableAdapter hesapAltGrupDbTableAdapter;
        private System.Windows.Forms.TextBox altgrup_ekleguncelle_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource hesapGrupDBBindingSource;
        private CardDBDataSetTableAdapters.HesapGrupDBTableAdapter hesapGrupDBTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource hesapGrupDBBindingSource1;
        private System.Windows.Forms.Label label2;
    }
}