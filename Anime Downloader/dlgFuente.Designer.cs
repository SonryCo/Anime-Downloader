namespace Anime_Downloader {
    partial class dlgFuente {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.fuenteLista1 = new System.Windows.Forms.ComboBox();
            this.selectBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.chkNOP = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // fuenteLista1
            // 
            this.fuenteLista1.FormattingEnabled = true;
            this.fuenteLista1.Location = new System.Drawing.Point(12, 65);
            this.fuenteLista1.Name = "fuenteLista1";
            this.fuenteLista1.Size = new System.Drawing.Size(467, 21);
            this.fuenteLista1.TabIndex = 0;
            // 
            // selectBtn
            // 
            this.selectBtn.AutoSize = true;
            this.selectBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.selectBtn.Depth = 0;
            this.selectBtn.Location = new System.Drawing.Point(377, 95);
            this.selectBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.selectBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Primary = false;
            this.selectBtn.Size = new System.Drawing.Size(102, 36);
            this.selectBtn.TabIndex = 1;
            this.selectBtn.Text = "Seleccionar";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // chkNOP
            // 
            this.chkNOP.AutoSize = true;
            this.chkNOP.Depth = 0;
            this.chkNOP.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkNOP.Location = new System.Drawing.Point(314, 137);
            this.chkNOP.Margin = new System.Windows.Forms.Padding(0);
            this.chkNOP.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkNOP.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkNOP.Name = "chkNOP";
            this.chkNOP.Ripple = true;
            this.chkNOP.Size = new System.Drawing.Size(165, 30);
            this.chkNOP.TabIndex = 2;
            this.chkNOP.Text = "No Volver a Preguntar";
            this.chkNOP.UseVisualStyleBackColor = true;
            this.chkNOP.CheckedChanged += new System.EventHandler(this.chkNOP_CheckedChanged);
            // 
            // dlgFuente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(491, 181);
            this.Controls.Add(this.chkNOP);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.fuenteLista1);
            this.Name = "dlgFuente";
            this.Text = "Seleccionar Fuente";
            this.Load += new System.EventHandler(this.dlgFuente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fuenteLista1;
        private MaterialSkin.Controls.MaterialFlatButton selectBtn;
        private MaterialSkin.Controls.MaterialCheckBox chkNOP;
    }
}