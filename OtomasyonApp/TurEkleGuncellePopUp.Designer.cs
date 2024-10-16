namespace OtomasyonApp
{
    partial class TurEkleGuncellePopUp
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
            this.TurPopUpEkleguncelle_btn = new System.Windows.Forms.Button();
            this.tipadekle_txt = new System.Windows.Forms.TextBox();
            this.hesapKartTuruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardDBDataSet = new OtomasyonApp.CardDBDataSet();
            this.TurdıekleGuncelle_lbl = new System.Windows.Forms.Label();
            this.hesapKartTuruTableAdapter = new OtomasyonApp.CardDBDataSetTableAdapters.HesapKartTuruTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartTuruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TurPopUpEkleguncelle_btn
            // 
            this.TurPopUpEkleguncelle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TurPopUpEkleguncelle_btn.Location = new System.Drawing.Point(292, 221);
            this.TurPopUpEkleguncelle_btn.Name = "TurPopUpEkleguncelle_btn";
            this.TurPopUpEkleguncelle_btn.Size = new System.Drawing.Size(99, 32);
            this.TurPopUpEkleguncelle_btn.TabIndex = 7;
            this.TurPopUpEkleguncelle_btn.Text = "Ekle";
            this.TurPopUpEkleguncelle_btn.UseVisualStyleBackColor = true;
            this.TurPopUpEkleguncelle_btn.Click += new System.EventHandler(this.TurPopUpEkleguncelle_btn_Click);
            // 
            // tipadekle_txt
            // 
            this.tipadekle_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesapKartTuruBindingSource, "TurAdı", true));
            this.tipadekle_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tipadekle_txt.Location = new System.Drawing.Point(319, 151);
            this.tipadekle_txt.Multiline = true;
            this.tipadekle_txt.Name = "tipadekle_txt";
            this.tipadekle_txt.Size = new System.Drawing.Size(147, 25);
            this.tipadekle_txt.TabIndex = 6;
            // 
            // hesapKartTuruBindingSource
            // 
            this.hesapKartTuruBindingSource.DataMember = "HesapKartTuru";
            this.hesapKartTuruBindingSource.DataSource = this.cardDBDataSet;
            // 
            // cardDBDataSet
            // 
            this.cardDBDataSet.DataSetName = "CardDBDataSet";
            this.cardDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TurdıekleGuncelle_lbl
            // 
            this.TurdıekleGuncelle_lbl.AutoSize = true;
            this.TurdıekleGuncelle_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TurdıekleGuncelle_lbl.Location = new System.Drawing.Point(228, 151);
            this.TurdıekleGuncelle_lbl.Name = "TurdıekleGuncelle_lbl";
            this.TurdıekleGuncelle_lbl.Size = new System.Drawing.Size(87, 25);
            this.TurdıekleGuncelle_lbl.TabIndex = 5;
            this.TurdıekleGuncelle_lbl.Text = "Tür Adı :";
            // 
            // hesapKartTuruTableAdapter
            // 
            this.hesapKartTuruTableAdapter.ClearBeforeFill = true;
            // 
            // TurEkleGuncellePopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TurPopUpEkleguncelle_btn);
            this.Controls.Add(this.tipadekle_txt);
            this.Controls.Add(this.TurdıekleGuncelle_lbl);
            this.Name = "TurEkleGuncellePopUp";
            this.Text = "TurEkleGuncellePopUp";
            this.Load += new System.EventHandler(this.TurEkleGuncellePopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartTuruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TurPopUpEkleguncelle_btn;
        private System.Windows.Forms.TextBox tipadekle_txt;
        private System.Windows.Forms.Label TurdıekleGuncelle_lbl;
        private CardDBDataSet cardDBDataSet;
        private System.Windows.Forms.BindingSource hesapKartTuruBindingSource;
        private CardDBDataSetTableAdapters.HesapKartTuruTableAdapter hesapKartTuruTableAdapter;
    }
}