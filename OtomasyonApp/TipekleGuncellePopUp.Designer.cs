namespace OtomasyonApp
{
    partial class TipekleGuncellePopUp
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
            this.Tipadıekle_lbl = new System.Windows.Forms.Label();
            this.tipadekle_txt = new System.Windows.Forms.TextBox();
            this.hesapKartTipiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardDBDataSet = new OtomasyonApp.CardDBDataSet();
            this.TipPopUpEkle_btn = new System.Windows.Forms.Button();
            this.hesapKartTipiTableAdapter = new OtomasyonApp.CardDBDataSetTableAdapters.HesapKartTipiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartTipiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Tipadıekle_lbl
            // 
            this.Tipadıekle_lbl.AutoSize = true;
            this.Tipadıekle_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tipadıekle_lbl.Location = new System.Drawing.Point(135, 126);
            this.Tipadıekle_lbl.Name = "Tipadıekle_lbl";
            this.Tipadıekle_lbl.Size = new System.Drawing.Size(85, 25);
            this.Tipadıekle_lbl.TabIndex = 1;
            this.Tipadıekle_lbl.Text = "Tip Adı :";
            // 
            // tipadekle_txt
            // 
            this.tipadekle_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesapKartTipiBindingSource, "TipAdı", true));
            this.tipadekle_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tipadekle_txt.Location = new System.Drawing.Point(226, 126);
            this.tipadekle_txt.Multiline = true;
            this.tipadekle_txt.Name = "tipadekle_txt";
            this.tipadekle_txt.Size = new System.Drawing.Size(147, 25);
            this.tipadekle_txt.TabIndex = 3;
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
            // TipPopUpEkle_btn
            // 
            this.TipPopUpEkle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TipPopUpEkle_btn.Location = new System.Drawing.Point(202, 188);
            this.TipPopUpEkle_btn.Name = "TipPopUpEkle_btn";
            this.TipPopUpEkle_btn.Size = new System.Drawing.Size(99, 32);
            this.TipPopUpEkle_btn.TabIndex = 4;
            this.TipPopUpEkle_btn.Text = "Ekle";
            this.TipPopUpEkle_btn.UseVisualStyleBackColor = true;
            this.TipPopUpEkle_btn.Click += new System.EventHandler(this.TipPopUpEkle_btn_Click);
            // 
            // hesapKartTipiTableAdapter
            // 
            this.hesapKartTipiTableAdapter.ClearBeforeFill = true;
            // 
            // TipekleGuncellePopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 398);
            this.Controls.Add(this.TipPopUpEkle_btn);
            this.Controls.Add(this.tipadekle_txt);
            this.Controls.Add(this.Tipadıekle_lbl);
            this.Name = "TipekleGuncellePopUp";
            this.Text = "TipeklePopUp";
            this.Load += new System.EventHandler(this.TipeklePopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hesapKartTipiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Tipadıekle_lbl;
        private System.Windows.Forms.TextBox tipadekle_txt;
        private System.Windows.Forms.Button TipPopUpEkle_btn;
        private CardDBDataSet cardDBDataSet;
        private System.Windows.Forms.BindingSource hesapKartTipiBindingSource;
        private CardDBDataSetTableAdapters.HesapKartTipiTableAdapter hesapKartTipiTableAdapter;
    }
}