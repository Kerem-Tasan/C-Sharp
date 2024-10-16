namespace TheModul
{
    partial class Resimler
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbl_resim = new TheModul.ModulDBDataSetTableAdapters.ResimTblTableAdapter();
            this.ds_modul = new TheModul.ModulDBDataSet();
            this.bs_model = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ds_modul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_model)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(105, 75);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(954, 369);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(36, 36);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tbl_resim
            // 
            this.tbl_resim.ClearBeforeFill = true;
            // 
            // ds_modul
            // 
            this.ds_modul.DataSetName = "ModulDBDataSet";
            this.ds_modul.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Resimler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 664);
            this.Controls.Add(this.listView1);
            this.Name = "Resimler";
            this.Text = "Resimler";
            this.Load += new System.EventHandler(this.Resimler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_modul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_model)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList ımageList1;
        private ModulDBDataSetTableAdapters.ResimTblTableAdapter tbl_resim;
        private ModulDBDataSet ds_modul;
        private System.Windows.Forms.BindingSource bs_model;
    }
}