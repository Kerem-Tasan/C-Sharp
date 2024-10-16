namespace OtomasyonApp
{
    partial class GrupEkleGuncelle
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
            this.GrupEkleGuncelle_txt = new System.Windows.Forms.TextBox();
            this.hesapGrupDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardDBDataSet = new OtomasyonApp.CardDBDataSet();
            this.GrupEkleGuncelle_btn = new System.Windows.Forms.Button();
            this.GrupEkleGuncelle_lbl = new System.Windows.Forms.Label();
            this.hesapGrupDBTableAdapter = new OtomasyonApp.CardDBDataSetTableAdapters.HesapGrupDBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hesapGrupDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // GrupEkleGuncelle_txt
            // 
            this.GrupEkleGuncelle_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hesapGrupDBBindingSource, "GrupAdı", true));
            this.GrupEkleGuncelle_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrupEkleGuncelle_txt.Location = new System.Drawing.Point(315, 184);
            this.GrupEkleGuncelle_txt.Multiline = true;
            this.GrupEkleGuncelle_txt.Name = "GrupEkleGuncelle_txt";
            this.GrupEkleGuncelle_txt.Size = new System.Drawing.Size(141, 27);
            this.GrupEkleGuncelle_txt.TabIndex = 0;
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
            // GrupEkleGuncelle_btn
            // 
            this.GrupEkleGuncelle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrupEkleGuncelle_btn.Location = new System.Drawing.Point(262, 238);
            this.GrupEkleGuncelle_btn.Name = "GrupEkleGuncelle_btn";
            this.GrupEkleGuncelle_btn.Size = new System.Drawing.Size(99, 36);
            this.GrupEkleGuncelle_btn.TabIndex = 1;
            this.GrupEkleGuncelle_btn.Text = "Ekle";
            this.GrupEkleGuncelle_btn.UseVisualStyleBackColor = true;
            this.GrupEkleGuncelle_btn.Click += new System.EventHandler(this.GrupEkleGuncelle_btn_Click);
            // 
            // GrupEkleGuncelle_lbl
            // 
            this.GrupEkleGuncelle_lbl.AutoSize = true;
            this.GrupEkleGuncelle_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrupEkleGuncelle_lbl.Location = new System.Drawing.Point(182, 185);
            this.GrupEkleGuncelle_lbl.Name = "GrupEkleGuncelle_lbl";
            this.GrupEkleGuncelle_lbl.Size = new System.Drawing.Size(110, 26);
            this.GrupEkleGuncelle_lbl.TabIndex = 2;
            this.GrupEkleGuncelle_lbl.Text = "Grup Adı :";
            // 
            // hesapGrupDBTableAdapter
            // 
            this.hesapGrupDBTableAdapter.ClearBeforeFill = true;
            // 
            // GrupEkleGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrupEkleGuncelle_lbl);
            this.Controls.Add(this.GrupEkleGuncelle_btn);
            this.Controls.Add(this.GrupEkleGuncelle_txt);
            this.Name = "GrupEkleGuncelle";
            this.Text = "GrupEkleGuncelle";
            this.Load += new System.EventHandler(this.GrupEkleGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hesapGrupDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GrupEkleGuncelle_txt;
        private System.Windows.Forms.Button GrupEkleGuncelle_btn;
        private System.Windows.Forms.Label GrupEkleGuncelle_lbl;
        private CardDBDataSet cardDBDataSet;
        private System.Windows.Forms.BindingSource hesapGrupDBBindingSource;
        private CardDBDataSetTableAdapters.HesapGrupDBTableAdapter hesapGrupDBTableAdapter;
    }
}