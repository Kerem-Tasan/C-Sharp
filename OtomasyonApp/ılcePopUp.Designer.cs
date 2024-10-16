namespace OtomasyonApp
{
    partial class ılcePopUp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sehir_cmb = new System.Windows.Forms.ComboBox();
            this.ıLCEDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardDBDataSet = new OtomasyonApp.CardDBDataSet();
            this.SehirAd_lbl = new System.Windows.Forms.Label();
            this.ilce_txt = new System.Windows.Forms.TextBox();
            this.ilce_lbl = new System.Windows.Forms.Label();
            this.ilceekle_btn = new System.Windows.Forms.Button();
            this.iLCEDBTableAdapter = new OtomasyonApp.CardDBDataSetTableAdapters.ILCEDBTableAdapter();
            this.sehirlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sehirlerTableAdapter = new OtomasyonApp.CardDBDataSetTableAdapters.SehirlerTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıLCEDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Sehir_cmb);
            this.panel1.Controls.Add(this.SehirAd_lbl);
            this.panel1.Location = new System.Drawing.Point(188, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 63);
            this.panel1.TabIndex = 14;
            // 
            // Sehir_cmb
            // 
            this.Sehir_cmb.DataSource = this.sehirlerBindingSource;
            this.Sehir_cmb.DisplayMember = "SehirAd";
            this.Sehir_cmb.FormattingEnabled = true;
            this.Sehir_cmb.Location = new System.Drawing.Point(168, 18);
            this.Sehir_cmb.Name = "Sehir_cmb";
            this.Sehir_cmb.Size = new System.Drawing.Size(152, 24);
            this.Sehir_cmb.TabIndex = 6;
            this.Sehir_cmb.ValueMember = "SehirId";
            // 
            // ıLCEDBBindingSource
            // 
            this.ıLCEDBBindingSource.DataMember = "ILCEDB";
            this.ıLCEDBBindingSource.DataSource = this.cardDBDataSet;
            // 
            // cardDBDataSet
            // 
            this.cardDBDataSet.DataSetName = "CardDBDataSet";
            this.cardDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SehirAd_lbl
            // 
            this.SehirAd_lbl.AutoSize = true;
            this.SehirAd_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SehirAd_lbl.Location = new System.Drawing.Point(-2, 18);
            this.SehirAd_lbl.Name = "SehirAd_lbl";
            this.SehirAd_lbl.Size = new System.Drawing.Size(113, 25);
            this.SehirAd_lbl.TabIndex = 5;
            this.SehirAd_lbl.Text = "Şehir Adı :  ";
            // 
            // ilce_txt
            // 
            this.ilce_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ıLCEDBBindingSource, "IlceAdı", true));
            this.ilce_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilce_txt.Location = new System.Drawing.Point(353, 195);
            this.ilce_txt.Multiline = true;
            this.ilce_txt.Name = "ilce_txt";
            this.ilce_txt.Size = new System.Drawing.Size(155, 25);
            this.ilce_txt.TabIndex = 13;
            // 
            // ilce_lbl
            // 
            this.ilce_lbl.AutoSize = true;
            this.ilce_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilce_lbl.Location = new System.Drawing.Point(183, 195);
            this.ilce_lbl.Name = "ilce_lbl";
            this.ilce_lbl.Size = new System.Drawing.Size(97, 25);
            this.ilce_lbl.TabIndex = 12;
            this.ilce_lbl.Text = "İlçe Adı :  ";
            // 
            // ilceekle_btn
            // 
            this.ilceekle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilceekle_btn.Location = new System.Drawing.Point(317, 277);
            this.ilceekle_btn.Name = "ilceekle_btn";
            this.ilceekle_btn.Size = new System.Drawing.Size(94, 35);
            this.ilceekle_btn.TabIndex = 11;
            this.ilceekle_btn.Text = "Ekle";
            this.ilceekle_btn.UseVisualStyleBackColor = true;
            this.ilceekle_btn.Click += new System.EventHandler(this.ilceekle_txt_Click);
            // 
            // iLCEDBTableAdapter
            // 
            this.iLCEDBTableAdapter.ClearBeforeFill = true;
            // 
            // sehirlerBindingSource
            // 
            this.sehirlerBindingSource.DataMember = "Sehirler";
            this.sehirlerBindingSource.DataSource = this.cardDBDataSet;
            // 
            // sehirlerTableAdapter
            // 
            this.sehirlerTableAdapter.ClearBeforeFill = true;
            // 
            // ılcePopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ilce_txt);
            this.Controls.Add(this.ilce_lbl);
            this.Controls.Add(this.ilceekle_btn);
            this.Name = "ılcePopUp";
            this.Text = "ılcePopUp";
            this.Load += new System.EventHandler(this.ılcePopUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıLCEDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Sehir_cmb;
        private System.Windows.Forms.Label SehirAd_lbl;
        private System.Windows.Forms.TextBox ilce_txt;
        private System.Windows.Forms.Label ilce_lbl;
        private System.Windows.Forms.Button ilceekle_btn;
        private CardDBDataSet cardDBDataSet;
        private System.Windows.Forms.BindingSource ıLCEDBBindingSource;
        private CardDBDataSetTableAdapters.ILCEDBTableAdapter iLCEDBTableAdapter;
        private System.Windows.Forms.BindingSource sehirlerBindingSource;
        private CardDBDataSetTableAdapters.SehirlerTableAdapter sehirlerTableAdapter;
    }
}