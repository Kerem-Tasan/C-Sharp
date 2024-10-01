namespace LTS_Mini
{
    partial class IstekKategorisiEkleGuncelle
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ıstekKategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._LTS_MiniDataSet = new LTS_Mini._LTS_MiniDataSet();
            this.istekKategoriTableAdapter = new LTS_Mini._LTS_MiniDataSetTableAdapters.IstekKategoriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ıstekKategoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._LTS_MiniDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(183, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(314, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ıstekKategoriBindingSource, "IstekAdı", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(355, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 30);
            this.textBox1.TabIndex = 2;
            // 
            // ıstekKategoriBindingSource
            // 
            this.ıstekKategoriBindingSource.DataMember = "IstekKategori";
            this.ıstekKategoriBindingSource.DataSource = this._LTS_MiniDataSet;
            // 
            // _LTS_MiniDataSet
            // 
            this._LTS_MiniDataSet.DataSetName = "_LTS_MiniDataSet";
            this._LTS_MiniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // istekKategoriTableAdapter
            // 
            this.istekKategoriTableAdapter.ClearBeforeFill = true;
            // 
            // IstekKategorisiEkleGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "IstekKategorisiEkleGuncelle";
            this.Text = "IstekKategorisiEkleGuncelle";
            this.Load += new System.EventHandler(this.IstekKategorisiEkleGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ıstekKategoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._LTS_MiniDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource ıstekKategoriBindingSource;
        private _LTS_MiniDataSet _LTS_MiniDataSet;
        private _LTS_MiniDataSetTableAdapters.IstekKategoriTableAdapter istekKategoriTableAdapter;
    }
}