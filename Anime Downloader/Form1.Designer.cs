namespace Anime_Downloader {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.modeTab = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.lblAtit = new MaterialSkin.Controls.MaterialLabel();
            this.animePic = new System.Windows.Forms.PictureBox();
            this.CookieMonster1 = new System.Windows.Forms.WebBrowser();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.lblEpis = new MaterialSkin.Controls.MaterialLabel();
            this.lblCont = new MaterialSkin.Controls.MaterialLabel();
            this.t2 = new System.Windows.Forms.Timer(this.components);
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dwnlEmi = new MaterialSkin.Controls.MaterialFlatButton();
            this.listChap = new System.Windows.Forms.ListBox();
            this.listSour = new System.Windows.Forms.ListBox();
            this.btnCli = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.modeTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animePic)).BeginInit();
            this.SuspendLayout();
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.Color.White;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(511, 6);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(91, 36);
            this.materialFlatButton1.TabIndex = 0;
            this.materialFlatButton1.Text = "Descargar";
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(7, 11);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(494, 23);
            this.materialSingleLineTextField1.TabIndex = 1;
            this.materialSingleLineTextField1.Text = "http://Jkanime.net";
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // modeTab
            // 
            this.modeTab.Controls.Add(this.tabPage1);
            this.modeTab.Controls.Add(this.tabPage2);
            this.modeTab.Depth = 0;
            this.modeTab.Location = new System.Drawing.Point(0, 364);
            this.modeTab.MouseState = MaterialSkin.MouseState.HOVER;
            this.modeTab.Name = "modeTab";
            this.modeTab.SelectedIndex = 0;
            this.modeTab.Size = new System.Drawing.Size(614, 282);
            this.modeTab.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialCheckBox1);
            this.tabPage1.Controls.Add(this.materialFlatButton1);
            this.tabPage1.Controls.Add(this.materialSingleLineTextField1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(606, 256);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Modo Normal";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCli);
            this.tabPage2.Controls.Add(this.listSour);
            this.tabPage2.Controls.Add(this.listChap);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(606, 256);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modo Lista";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.modeTab;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(733, 21);
            this.materialTabSelector1.TabIndex = 4;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // lblAtit
            // 
            this.lblAtit.AutoSize = true;
            this.lblAtit.BackColor = System.Drawing.Color.Transparent;
            this.lblAtit.Depth = 0;
            this.lblAtit.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAtit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAtit.Location = new System.Drawing.Point(12, 9);
            this.lblAtit.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAtit.Name = "lblAtit";
            this.lblAtit.Size = new System.Drawing.Size(131, 19);
            this.lblAtit.TabIndex = 5;
            this.lblAtit.Text = "Anime en Emision";
            // 
            // animePic
            // 
            this.animePic.Location = new System.Drawing.Point(0, 85);
            this.animePic.Name = "animePic";
            this.animePic.Size = new System.Drawing.Size(614, 279);
            this.animePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.animePic.TabIndex = 6;
            this.animePic.TabStop = false;
            this.animePic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CookieMonster1
            // 
            this.CookieMonster1.Location = new System.Drawing.Point(521, 370);
            this.CookieMonster1.MinimumSize = new System.Drawing.Size(20, 20);
            this.CookieMonster1.Name = "CookieMonster1";
            this.CookieMonster1.Size = new System.Drawing.Size(20, 23);
            this.CookieMonster1.TabIndex = 7;
            this.CookieMonster1.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(9, 222);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(88, 19);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Sonry\'S Life";
            // 
            // lblEpis
            // 
            this.lblEpis.AutoSize = true;
            this.lblEpis.BackColor = System.Drawing.Color.Transparent;
            this.lblEpis.Depth = 0;
            this.lblEpis.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEpis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEpis.Location = new System.Drawing.Point(9, 242);
            this.lblEpis.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEpis.Name = "lblEpis";
            this.lblEpis.Size = new System.Drawing.Size(88, 19);
            this.lblEpis.TabIndex = 9;
            this.lblEpis.Text = "Episodio 39";
            // 
            // lblCont
            // 
            this.lblCont.AutoSize = true;
            this.lblCont.BackColor = System.Drawing.Color.Transparent;
            this.lblCont.Depth = 0;
            this.lblCont.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCont.Location = new System.Drawing.Point(565, 9);
            this.lblCont.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(39, 19);
            this.lblCont.TabIndex = 10;
            this.lblCont.Text = "1/10";
            // 
            // t2
            // 
            this.t2.Interval = 4000;
            this.t2.Tick += new System.EventHandler(this.t2_Tick);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(522, 55);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(89, 27);
            this.materialRaisedButton1.TabIndex = 11;
            this.materialRaisedButton1.Text = "En Emision";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // dwnlEmi
            // 
            this.dwnlEmi.AutoSize = true;
            this.dwnlEmi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dwnlEmi.Depth = 0;
            this.dwnlEmi.Location = new System.Drawing.Point(441, 225);
            this.dwnlEmi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dwnlEmi.MouseState = MaterialSkin.MouseState.HOVER;
            this.dwnlEmi.Name = "dwnlEmi";
            this.dwnlEmi.Primary = false;
            this.dwnlEmi.Size = new System.Drawing.Size(160, 36);
            this.dwnlEmi.TabIndex = 12;
            this.dwnlEmi.Text = "Comenzar Descarga";
            this.dwnlEmi.UseVisualStyleBackColor = true;
            // 
            // listChap
            // 
            this.listChap.FormattingEnabled = true;
            this.listChap.Location = new System.Drawing.Point(6, 47);
            this.listChap.Name = "listChap";
            this.listChap.Size = new System.Drawing.Size(320, 160);
            this.listChap.TabIndex = 0;
            // 
            // listSour
            // 
            this.listSour.FormattingEnabled = true;
            this.listSour.Location = new System.Drawing.Point(332, 47);
            this.listSour.Name = "listSour";
            this.listSour.Size = new System.Drawing.Size(90, 160);
            this.listSour.TabIndex = 1;
            // 
            // btnCli
            // 
            this.btnCli.AutoSize = true;
            this.btnCli.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCli.Depth = 0;
            this.btnCli.Location = new System.Drawing.Point(7, 213);
            this.btnCli.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCli.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCli.Name = "btnCli";
            this.btnCli.Primary = false;
            this.btnCli.Size = new System.Drawing.Size(106, 36);
            this.btnCli.TabIndex = 2;
            this.btnCli.Text = "Limpiar Lista";
            this.btnCli.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(445, 45);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(155, 30);
            this.materialCheckBox1.TabIndex = 2;
            this.materialCheckBox1.Text = "Link al Portapapeles";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 652);
            this.Controls.Add(this.dwnlEmi);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.lblCont);
            this.Controls.Add(this.lblEpis);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.CookieMonster1);
            this.Controls.Add(this.lblAtit);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.modeTab);
            this.Controls.Add(this.animePic);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AnimeDownloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.modeTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialTabControl modeTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialLabel lblAtit;
        private System.Windows.Forms.PictureBox animePic;
        private System.Windows.Forms.WebBrowser CookieMonster1;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialLabel lblEpis;
        private MaterialSkin.Controls.MaterialLabel lblCont;
        private System.Windows.Forms.Timer t2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialFlatButton dwnlEmi;
        private MaterialSkin.Controls.MaterialFlatButton btnCli;
        private System.Windows.Forms.ListBox listSour;
        private System.Windows.Forms.ListBox listChap;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

