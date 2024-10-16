namespace OtomasyonApp
{
    partial class GrupTanimGuncellePopUp
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
            this.GrupAdiGuncelle_txt = new System.Windows.Forms.TextBox();
            this.hesapGrupDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardDBDataSet = new OtomasyonApp.CardDBDataSet();
            this.GrupAdiGuncelle_lbl = new System.Windows.Forms.Label();
            this.Güncelle = new System.Windows.Forms.Button();
            this.hesapGrupDBTableAdapter = new OtomasyonApp.CardDBDataSetTableAdapters.HesapGrupDBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hesapGrupDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // GrupAdiGuncelle_txt
            // 
            this.GrupAdiGuncelle_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesapGrupDBBindingSource, "GrupAdı", true));
            this.GrupAdiGuncelle_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrupAdiGuncelle_txt.Location = new System.Drawing.Point(402, 148);
            this.GrupAdiGuncelle_txt.Multiline = true;
            this.GrupAdiGuncelle_txt.Name = "GrupAdiGuncelle_txt";
            this.GrupAdiGuncelle_txt.Size = new System.Drawing.Size(106, 25);
            this.GrupAdiGuncelle_txt.TabIndex = 0;
            // 
            // hesapGrupDBBindingSource
            // 
            this.hesapGrupDBBindingSource.DataMember = "HesapGrupDB";
            this.hesapGrupDBBindingSource.DataSource = this.cardDBDataSet;
            // 
            // cardDBDataSet
            // 
            this.cardDBDataSet.DataSetName = "CardDBDataSet";
            this.cardDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GrupAdiGuncelle_lbl
            // 
            this.GrupAdiGuncelle_lbl.AutoSize = true;
            this.GrupAdiGuncelle_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrupAdiGuncelle_lbl.Location = new System.Drawing.Point(286, 148);
            this.GrupAdiGuncelle_lbl.Name = "GrupAdiGuncelle_lbl";
            this.GrupAdiGuncelle_lbl.Size = new System.Drawing.Size(100, 25);
            this.GrupAdiGuncelle_lbl.TabIndex = 1;
            this.GrupAdiGuncelle_lbl.Text = "Grup Adı :";
            // 
            // Güncelle
            // 
            this.Güncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Güncelle.Location = new System.Drawing.Point(324, 222);
            this.Güncelle.Name = "Güncelle";
            this.Güncelle.Size = new System.Drawing.Size(97, 34);
            this.Güncelle.TabIndex = 2;
            this.Güncelle.Text = "Güncelle";
            this.Güncelle.UseVisualStyleBackColor = true;
            this.Güncelle.Click += new System.EventHandler(this.Güncelle_Click);
            // 
            // hesapGrupDBTableAdapter
            // 
            this.hesapGrupDBTableAdapter.ClearBeforeFill = true;
            // 
            // GrupTanimGuncellePopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Güncelle);
            this.Controls.Add(this.GrupAdiGuncelle_lbl);
            this.Controls.Add(this.GrupAdiGuncelle_txt);
            this.Name = "GrupTanimGuncellePopUp";
            this.Text = "GrupTanimGuncellePopUp";
            this.Load += new System.EventHandler(this.GrupTanimGuncellePopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hesapGrupDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GrupAdiGuncelle_txt;
        private System.Windows.Forms.Label GrupAdiGuncelle_lbl;
        private System.Windows.Forms.Button Güncelle;
        private CardDBDataSet cardDBDataSet;
        private System.Windows.Forms.BindingSource hesapGrupDBBindingSource;
        private CardDBDataSetTableAdapters.HesapGrupDBTableAdapter hesapGrupDBTableAdapter;
    }
}