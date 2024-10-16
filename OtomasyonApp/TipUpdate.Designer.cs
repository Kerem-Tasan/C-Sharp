namespace OtomasyonApp
{
    partial class TipUpdate
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
            this.Tip_guncellem_lbl = new System.Windows.Forms.Label();
            this.Tip_guncelle_btn = new System.Windows.Forms.Button();
            this.Tip_guncelle_txt = new System.Windows.Forms.TextBox();
            this.hesapKartTipiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardDBDataSet = new OtomasyonApp.CardDBDataSet();
            this.hesapKartTipiTableAdapter = new OtomasyonApp.CardDBDataSetTableAdapters.HesapKartTipiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartTipiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Tip_guncellem_lbl
            // 
            this.Tip_guncellem_lbl.AutoSize = true;
            this.Tip_guncellem_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tip_guncellem_lbl.Location = new System.Drawing.Point(222, 181);
            this.Tip_guncellem_lbl.Name = "Tip_guncellem_lbl";
            this.Tip_guncellem_lbl.Size = new System.Drawing.Size(90, 29);
            this.Tip_guncellem_lbl.TabIndex = 0;
            this.Tip_guncellem_lbl.Text = "Tip Adı";
            // 
            // Tip_guncelle_btn
            // 
            this.Tip_guncelle_btn.Location = new System.Drawing.Point(293, 249);
            this.Tip_guncelle_btn.Name = "Tip_guncelle_btn";
            this.Tip_guncelle_btn.Size = new System.Drawing.Size(89, 41);
            this.Tip_guncelle_btn.TabIndex = 1;
            this.Tip_guncelle_btn.Text = "Güncelle";
            this.Tip_guncelle_btn.UseVisualStyleBackColor = true;
            this.Tip_guncelle_btn.Click += new System.EventHandler(this.Tip_guncelle_btn_Click);
            // 
            // Tip_guncelle_txt
            // 
            this.Tip_guncelle_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesapKartTipiBindingSource, "TipAdı", true));
            this.Tip_guncelle_txt.Location = new System.Drawing.Point(337, 181);
            this.Tip_guncelle_txt.Multiline = true;
            this.Tip_guncelle_txt.Name = "Tip_guncelle_txt";
            this.Tip_guncelle_txt.Size = new System.Drawing.Size(129, 31);
            this.Tip_guncelle_txt.TabIndex = 2;
            // 
            // hesapKartTipiBindingSource
            // 
            this.hesapKartTipiBindingSource.DataMember = "HesapKartTipi";
            this.hesapKartTipiBindingSource.DataSource = this.cardDBDataSet;
            // 
            // cardDBDataSet
            // 
            this.cardDBDataSet.DataSetName = "CardDBDataSet";
            this.cardDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hesapKartTipiTableAdapter
            // 
            this.hesapKartTipiTableAdapter.ClearBeforeFill = true;
            // 
            // TipUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tip_guncelle_txt);
            this.Controls.Add(this.Tip_guncelle_btn);
            this.Controls.Add(this.Tip_guncellem_lbl);
            this.Name = "TipUpdate";
            this.Text = "TipUpdate";
            this.Load += new System.EventHandler(this.TipUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartTipiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tip_guncellem_lbl;
        private System.Windows.Forms.Button Tip_guncelle_btn;
        private System.Windows.Forms.TextBox Tip_guncelle_txt;
        private CardDBDataSet cardDBDataSet;
        private System.Windows.Forms.BindingSource hesapKartTipiBindingSource;
        private CardDBDataSetTableAdapters.HesapKartTipiTableAdapter hesapKartTipiTableAdapter;
    }
}