namespace TaskApplication
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
            this.lbl_Input = new System.Windows.Forms.Label();
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.btn_Input = new System.Windows.Forms.Button();
            this.gorevDS1 = new TaskApplication.GorevDS();
            this.gorevLogTblTableAdapter1 = new TaskApplication.GorevDSTableAdapters.GorevLogTblTableAdapter();
            this.gorev_bs = new System.Windows.Forms.BindingSource(this.components);
            this.gorevTblTableAdapter1 = new TaskApplication.GorevDSTableAdapters.GorevTblTableAdapter();
            this.kullaniciTblTableAdapter1 = new TaskApplication.GorevDSTableAdapters.KullaniciTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gorevDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorev_bs)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Input
            // 
            this.lbl_Input.AutoSize = true;
            this.lbl_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Input.Location = new System.Drawing.Point(183, 143);
            this.lbl_Input.Name = "lbl_Input";
            this.lbl_Input.Size = new System.Drawing.Size(120, 26);
            this.lbl_Input.TabIndex = 0;
            this.lbl_Input.Text = "Açıklama : ";
            // 
            // txt_Input
            // 
            this.txt_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Input.Location = new System.Drawing.Point(309, 143);
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(207, 32);
            this.txt_Input.TabIndex = 1;
            // 
            // btn_Input
            // 
            this.btn_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Input.Location = new System.Drawing.Point(256, 222);
            this.btn_Input.Name = "btn_Input";
            this.btn_Input.Size = new System.Drawing.Size(116, 41);
            this.btn_Input.TabIndex = 2;
            this.btn_Input.Text = "Kaydet";
            this.btn_Input.UseVisualStyleBackColor = true;
            this.btn_Input.Click += new System.EventHandler(this.btn_Input_Click);
            // 
            // gorevDS1
            // 
            this.gorevDS1.DataSetName = "GorevDS";
            this.gorevDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gorevLogTblTableAdapter1
            // 
            this.gorevLogTblTableAdapter1.ClearBeforeFill = true;
            // 
            // gorev_bs
            // 
            this.gorev_bs.DataSource = this.gorevDS1;
            this.gorev_bs.Position = 0;
            // 
            // gorevTblTableAdapter1
            // 
            this.gorevTblTableAdapter1.ClearBeforeFill = true;
            // 
            // kullaniciTblTableAdapter1
            // 
            this.kullaniciTblTableAdapter1.ClearBeforeFill = true;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 394);
            this.Controls.Add(this.btn_Input);
            this.Controls.Add(this.txt_Input);
            this.Controls.Add(this.lbl_Input);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.Load += new System.EventHandler(this.InputForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gorevDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorev_bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Input;
        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.Button btn_Input;
        private GorevDS gorevDS1;
        private GorevDSTableAdapters.GorevLogTblTableAdapter gorevLogTblTableAdapter1;
        private System.Windows.Forms.BindingSource gorev_bs;
        private GorevDSTableAdapters.GorevTblTableAdapter gorevTblTableAdapter1;
        private GorevDSTableAdapters.KullaniciTblTableAdapter kullaniciTblTableAdapter1;
    }
}