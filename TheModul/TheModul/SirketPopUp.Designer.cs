namespace TheModul
{
    partial class SirketPopUp
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
            this.txt_SirketAd = new System.Windows.Forms.TextBox();
            this.lbl_SirketAd = new System.Windows.Forms.Label();
            this.btn_Sirket = new System.Windows.Forms.Button();
            this.ds_Modul = new TheModul.ModulDBDataSet();
            this.bs_Sirket = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Sirket = new TheModul.ModulDBDataSetTableAdapters.SirketTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Modul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Sirket)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_SirketAd
            // 
            this.txt_SirketAd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_Sirket, "Ad", true));
            this.txt_SirketAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_SirketAd.Location = new System.Drawing.Point(345, 155);
            this.txt_SirketAd.Name = "txt_SirketAd";
            this.txt_SirketAd.Size = new System.Drawing.Size(181, 28);
            this.txt_SirketAd.TabIndex = 0;
            // 
            // lbl_SirketAd
            // 
            this.lbl_SirketAd.AutoSize = true;
            this.lbl_SirketAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_SirketAd.Location = new System.Drawing.Point(240, 159);
            this.lbl_SirketAd.Name = "lbl_SirketAd";
            this.lbl_SirketAd.Size = new System.Drawing.Size(99, 24);
            this.lbl_SirketAd.TabIndex = 1;
            this.lbl_SirketAd.Text = "Şirket Adı :";
            // 
            // btn_Sirket
            // 
            this.btn_Sirket.Location = new System.Drawing.Point(317, 224);
            this.btn_Sirket.Name = "btn_Sirket";
            this.btn_Sirket.Size = new System.Drawing.Size(100, 30);
            this.btn_Sirket.TabIndex = 2;
            this.btn_Sirket.Text = "Kaydet";
            this.btn_Sirket.UseVisualStyleBackColor = true;
            this.btn_Sirket.Click += new System.EventHandler(this.btn_Sirket_Click);
            // 
            // ds_Modul
            // 
            this.ds_Modul.DataSetName = "ModulDBDataSet";
            this.ds_Modul.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bs_Sirket
            // 
            this.bs_Sirket.DataMember = "SirketTbl";
            this.bs_Sirket.DataSource = this.ds_Modul;
            // 
            // tbl_Sirket
            // 
            this.tbl_Sirket.ClearBeforeFill = true;
            // 
            // SirketPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Sirket);
            this.Controls.Add(this.lbl_SirketAd);
            this.Controls.Add(this.txt_SirketAd);
            this.Name = "SirketPopUp";
            this.Text = "SirketPopUp";
            this.Load += new System.EventHandler(this.SirketPopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_Modul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Sirket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_SirketAd;
        private System.Windows.Forms.Label lbl_SirketAd;
        private System.Windows.Forms.Button btn_Sirket;
        private ModulDBDataSet ds_Modul;
        private System.Windows.Forms.BindingSource bs_Sirket;
        private ModulDBDataSetTableAdapters.SirketTblTableAdapter tbl_Sirket;
    }
}