namespace OtomasyonApp
{
    partial class SehirEkleGuncelle
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
            this.Sehir_btn = new System.Windows.Forms.Button();
            this.sehir_txt = new System.Windows.Forms.TextBox();
            this.sehirlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardDBDataSet = new OtomasyonApp.CardDBDataSet();
            this.sehir_lbl = new System.Windows.Forms.Label();
            this.sehirlerTableAdapter = new OtomasyonApp.CardDBDataSetTableAdapters.SehirlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Sehir_btn
            // 
            this.Sehir_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sehir_btn.Location = new System.Drawing.Point(299, 215);
            this.Sehir_btn.Name = "Sehir_btn";
            this.Sehir_btn.Size = new System.Drawing.Size(166, 40);
            this.Sehir_btn.TabIndex = 0;
            this.Sehir_btn.Text = "Güncelle";
            this.Sehir_btn.UseVisualStyleBackColor = true;
            this.Sehir_btn.Click += new System.EventHandler(this.Sehir_btn_Click);
            // 
            // sehir_txt
            // 
            this.sehir_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sehirlerBindingSource, "SehirAd", true));
            this.sehir_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sehir_txt.Location = new System.Drawing.Point(340, 150);
            this.sehir_txt.Multiline = true;
            this.sehir_txt.Name = "sehir_txt";
            this.sehir_txt.Size = new System.Drawing.Size(181, 30);
            this.sehir_txt.TabIndex = 1;
            // 
            // sehirlerBindingSource
            // 
            this.sehirlerBindingSource.DataMember = "Sehirler";
            this.sehirlerBindingSource.DataSource = this.cardDBDataSet;
            // 
            // cardDBDataSet
            // 
            this.cardDBDataSet.DataSetName = "CardDBDataSet";
            this.cardDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sehir_lbl
            // 
            this.sehir_lbl.AutoSize = true;
            this.sehir_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sehir_lbl.Location = new System.Drawing.Point(201, 150);
            this.sehir_lbl.Name = "sehir_lbl";
            this.sehir_lbl.Size = new System.Drawing.Size(123, 29);
            this.sehir_lbl.TabIndex = 2;
            this.sehir_lbl.Text = "Şehir Adı :";
            // 
            // sehirlerTableAdapter
            // 
            this.sehirlerTableAdapter.ClearBeforeFill = true;
            // 
            // SehirEkleGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sehir_lbl);
            this.Controls.Add(this.sehir_txt);
            this.Controls.Add(this.Sehir_btn);
            this.Name = "SehirEkleGuncelle";
            this.Text = "SehirEkleGuncelle";
            this.Load += new System.EventHandler(this.SehirEkleGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sehir_btn;
        private System.Windows.Forms.TextBox sehir_txt;
        private System.Windows.Forms.Label sehir_lbl;
        private System.Windows.Forms.BindingSource sehirlerBindingSource;
        private CardDBDataSet cardDBDataSet;
        private CardDBDataSetTableAdapters.SehirlerTableAdapter sehirlerTableAdapter;
    }
}