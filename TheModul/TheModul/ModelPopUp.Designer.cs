namespace TheModul
{
    partial class ModelPopUp
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
            this.txt_mpp = new System.Windows.Forms.TextBox();
            this.bs_modul = new System.Windows.Forms.BindingSource(this.components);
            this.ds_modul = new TheModul.ModulDBDataSet();
            this.lbl_mpp = new System.Windows.Forms.Label();
            this.btn_mpp = new System.Windows.Forms.Button();
            this.tbl_modul = new TheModul.ModulDBDataSetTableAdapters.ModulTblTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.modulTblTableAdapter1 = new TheModul.ModulDBDataSetTableAdapters.ModulTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bs_modul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_modul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_mpp
            // 
            this.txt_mpp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_modul, "Adi", true));
            this.txt_mpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_mpp.Location = new System.Drawing.Point(345, 143);
            this.txt_mpp.Name = "txt_mpp";
            this.txt_mpp.Size = new System.Drawing.Size(155, 28);
            this.txt_mpp.TabIndex = 0;
            // 
            // bs_modul
            // 
            this.bs_modul.DataMember = "ModulTbl";
            this.bs_modul.DataSource = this.ds_modul;
            // 
            // ds_modul
            // 
            this.ds_modul.DataSetName = "ModulDBDataSet";
            this.ds_modul.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_mpp
            // 
            this.lbl_mpp.AutoSize = true;
            this.lbl_mpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_mpp.Location = new System.Drawing.Point(201, 143);
            this.lbl_mpp.Name = "lbl_mpp";
            this.lbl_mpp.Size = new System.Drawing.Size(106, 24);
            this.lbl_mpp.TabIndex = 1;
            this.lbl_mpp.Text = "Model Adı :";
            // 
            // btn_mpp
            // 
            this.btn_mpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mpp.Location = new System.Drawing.Point(278, 214);
            this.btn_mpp.Name = "btn_mpp";
            this.btn_mpp.Size = new System.Drawing.Size(112, 36);
            this.btn_mpp.TabIndex = 2;
            this.btn_mpp.Text = "Kaydet";
            this.btn_mpp.UseVisualStyleBackColor = true;
            this.btn_mpp.Click += new System.EventHandler(this.btn_mpp_Click);
            // 
            // tbl_modul
            // 
            this.tbl_modul.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // modulTblTableAdapter1
            // 
            this.modulTblTableAdapter1.ClearBeforeFill = true;
            // 
            // ModelPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 390);
            this.Controls.Add(this.btn_mpp);
            this.Controls.Add(this.lbl_mpp);
            this.Controls.Add(this.txt_mpp);
            this.Name = "ModelPopUp";
            this.Text = "ModelPopUp";
            this.Load += new System.EventHandler(this.ModelPopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_modul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_modul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_mpp;
        private System.Windows.Forms.Label lbl_mpp;
        private System.Windows.Forms.Button btn_mpp;
        private ModulDBDataSet ds_modul;
        private System.Windows.Forms.BindingSource bs_modul;
        private ModulDBDataSetTableAdapters.ModulTblTableAdapter tbl_modul;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private ModulDBDataSetTableAdapters.ModulTblTableAdapter modulTblTableAdapter1;
    }
}