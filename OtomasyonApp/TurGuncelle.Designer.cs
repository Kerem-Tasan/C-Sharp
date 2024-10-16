namespace OtomasyonApp
{
    partial class TurGuncelle
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
            this.TurguncelleFormu_lbl = new System.Windows.Forms.Label();
            this.TurGuncelleForm_txt = new System.Windows.Forms.TextBox();
            this.TurguncelleFormu_btn = new System.Windows.Forms.Button();
            this.cardDBDataSet = new OtomasyonApp.CardDBDataSet();
            this.hesapKartTuruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hesapKartTuruTableAdapter = new OtomasyonApp.CardDBDataSetTableAdapters.HesapKartTuruTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cardDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartTuruBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TurguncelleFormu_lbl
            // 
            this.TurguncelleFormu_lbl.AutoSize = true;
            this.TurguncelleFormu_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TurguncelleFormu_lbl.Location = new System.Drawing.Point(219, 131);
            this.TurguncelleFormu_lbl.Name = "TurguncelleFormu_lbl";
            this.TurguncelleFormu_lbl.Size = new System.Drawing.Size(72, 24);
            this.TurguncelleFormu_lbl.TabIndex = 0;
            this.TurguncelleFormu_lbl.Text = "Tür Adı";
            // 
            // TurGuncelleForm_txt
            // 
            this.TurGuncelleForm_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesapKartTuruBindingSource, "TurAdı", true));
            this.TurGuncelleForm_txt.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.hesapKartTuruBindingSource, "TurID", true));
            this.TurGuncelleForm_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TurGuncelleForm_txt.Location = new System.Drawing.Point(306, 131);
            this.TurGuncelleForm_txt.Multiline = true;
            this.TurGuncelleForm_txt.Name = "TurGuncelleForm_txt";
            this.TurGuncelleForm_txt.Size = new System.Drawing.Size(125, 33);
            this.TurGuncelleForm_txt.TabIndex = 1;
            // 
            // TurguncelleFormu_btn
            // 
            this.TurguncelleFormu_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TurguncelleFormu_btn.Location = new System.Drawing.Point(278, 204);
            this.TurguncelleFormu_btn.Name = "TurguncelleFormu_btn";
            this.TurguncelleFormu_btn.Size = new System.Drawing.Size(102, 38);
            this.TurguncelleFormu_btn.TabIndex = 2;
            this.TurguncelleFormu_btn.Text = "Güncelle";
            this.TurguncelleFormu_btn.UseVisualStyleBackColor = true;
            this.TurguncelleFormu_btn.Click += new System.EventHandler(this.TurguncelleFormu_btn_Click);
            // 
            // cardDBDataSet
            // 
            this.cardDBDataSet.DataSetName = "CardDBDataSet";
            this.cardDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hesapKartTuruBindingSource
            // 
            this.hesapKartTuruBindingSource.DataMember = "HesapKartTuru";
            this.hesapKartTuruBindingSource.DataSource = this.cardDBDataSet;
            // 
            // hesapKartTuruTableAdapter
            // 
            this.hesapKartTuruTableAdapter.ClearBeforeFill = true;
            // 
            // TurGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 436);
            this.Controls.Add(this.TurguncelleFormu_btn);
            this.Controls.Add(this.TurGuncelleForm_txt);
            this.Controls.Add(this.TurguncelleFormu_lbl);
            this.Name = "TurGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TurGuncelle";
            this.Load += new System.EventHandler(this.TurGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartTuruBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TurguncelleFormu_lbl;
        private System.Windows.Forms.TextBox TurGuncelleForm_txt;
        private System.Windows.Forms.Button TurguncelleFormu_btn;
        private CardDBDataSet cardDBDataSet;
        private System.Windows.Forms.BindingSource hesapKartTuruBindingSource;
        private CardDBDataSetTableAdapters.HesapKartTuruTableAdapter hesapKartTuruTableAdapter;
    }
}