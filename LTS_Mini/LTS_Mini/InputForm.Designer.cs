namespace LTS_Mini
{
    partial class InputForm
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
            this.Input_lbl = new System.Windows.Forms.Label();
            this.Input_txt = new System.Windows.Forms.TextBox();
            this.InpuT_btn = new System.Windows.Forms.Button();
            this._LTS_MiniDataSet = new LTS_Mini._LTS_MiniDataSet();
            this.kullaniciTableAdapter = new LTS_Mini._LTS_MiniDataSetTableAdapters.KullaniciTableAdapter();
            this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.istekKategoriTableAdapter = new LTS_Mini._LTS_MiniDataSetTableAdapters.IstekKategoriTableAdapter();
            this.istekTbl1TableAdapter = new LTS_Mini._LTS_MiniDataSetTableAdapters.IstekTbl1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._LTS_MiniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Input_lbl
            // 
            this.Input_lbl.AutoSize = true;
            this.Input_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Input_lbl.Location = new System.Drawing.Point(76, 183);
            this.Input_lbl.Name = "Input_lbl";
            this.Input_lbl.Size = new System.Drawing.Size(132, 29);
            this.Input_lbl.TabIndex = 0;
            this.Input_lbl.Text = "Açıklama :";
            // 
            // Input_txt
            // 
            this.Input_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Input_txt.Location = new System.Drawing.Point(305, 183);
            this.Input_txt.Multiline = true;
            this.Input_txt.Name = "Input_txt";
            this.Input_txt.Size = new System.Drawing.Size(248, 32);
            this.Input_txt.TabIndex = 1;
            // 
            // InpuT_btn
            // 
            this.InpuT_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InpuT_btn.Location = new System.Drawing.Point(318, 264);
            this.InpuT_btn.Name = "InpuT_btn";
            this.InpuT_btn.Size = new System.Drawing.Size(123, 42);
            this.InpuT_btn.TabIndex = 2;
            this.InpuT_btn.Text = "Ekle";
            this.InpuT_btn.UseVisualStyleBackColor = true;
            this.InpuT_btn.Click += new System.EventHandler(this.InpuT_btn_Click);
            // 
            // _LTS_MiniDataSet
            // 
            this._LTS_MiniDataSet.DataSetName = "_LTS_MiniDataSet";
            this._LTS_MiniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullaniciTableAdapter
            // 
            this.kullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // kullaniciBindingSource
            // 
            this.kullaniciBindingSource.DataMember = "Kullanici";
            this.kullaniciBindingSource.DataSource = this._LTS_MiniDataSet;
            // 
            // istekKategoriTableAdapter
            // 
            this.istekKategoriTableAdapter.ClearBeforeFill = true;
            // 
            // istekTbl1TableAdapter
            // 
            this.istekTbl1TableAdapter.ClearBeforeFill = true;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.InpuT_btn);
            this.Controls.Add(this.Input_txt);
            this.Controls.Add(this.Input_lbl);
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputForm";
            this.Load += new System.EventHandler(this.InputForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._LTS_MiniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Input_lbl;
        private System.Windows.Forms.TextBox Input_txt;
        private System.Windows.Forms.Button InpuT_btn;
        private System.Windows.Forms.BindingSource kullaniciBindingSource;
        private _LTS_MiniDataSet _LTS_MiniDataSet;
        private _LTS_MiniDataSetTableAdapters.KullaniciTableAdapter kullaniciTableAdapter;
        private _LTS_MiniDataSetTableAdapters.IstekKategoriTableAdapter istekKategoriTableAdapter;
        private _LTS_MiniDataSetTableAdapters.IstekTbl1TableAdapter istekTbl1TableAdapter;
    }
}