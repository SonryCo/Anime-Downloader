namespace Anime_Downloader {
    partial class Start {
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
            this.btnDwnl1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.aniLink1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.modeTab = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.clpbChk = new MaterialSkin.Controls.MaterialCheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numCap = new System.Windows.Forms.NumericUpDown();
            this.hastaCap = new MaterialSkin.Controls.MaterialRadioButton();
            this.lastChap = new MaterialSkin.Controls.MaterialRadioButton();
            this.unCap = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnDwnl2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.aniLink2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnCli = new MaterialSkin.Controls.MaterialFlatButton();
            this.listSour = new System.Windows.Forms.ListBox();
            this.listChap = new System.Windows.Forms.ListBox();
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblDani = new System.Windows.Forms.Label();
            this.lblDsp = new System.Windows.Forms.Label();
            this.btnAdw = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnDels = new MaterialSkin.Controls.MaterialFlatButton();
            this.folderBD1 = new System.Windows.Forms.FolderBrowserDialog();
            this.autoDownloader = new System.Windows.Forms.Timer(this.components);
            this.listDwl = new System.Windows.Forms.ListBox();
            this.tmrCtrl = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.modeTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animePic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDwnl1
            // 
            this.btnDwnl1.AutoSize = true;
            this.btnDwnl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDwnl1.BackColor = System.Drawing.Color.White;
            this.btnDwnl1.Depth = 0;
            this.btnDwnl1.Location = new System.Drawing.Point(511, 6);
            this.btnDwnl1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDwnl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDwnl1.Name = "btnDwnl1";
            this.btnDwnl1.Primary = false;
            this.btnDwnl1.Size = new System.Drawing.Size(91, 36);
            this.btnDwnl1.TabIndex = 0;
            this.btnDwnl1.Text = "Descargar";
            this.btnDwnl1.UseVisualStyleBackColor = false;
            this.btnDwnl1.Click += new System.EventHandler(this.btnDwnl1_Click);
            // 
            // aniLink1
            // 
            this.aniLink1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.aniLink1.Depth = 0;
            this.aniLink1.Hint = "";
            this.aniLink1.Location = new System.Drawing.Point(7, 11);
            this.aniLink1.MouseState = MaterialSkin.MouseState.HOVER;
            this.aniLink1.Name = "aniLink1";
            this.aniLink1.PasswordChar = '\0';
            this.aniLink1.SelectedText = "";
            this.aniLink1.SelectionLength = 0;
            this.aniLink1.SelectionStart = 0;
            this.aniLink1.Size = new System.Drawing.Size(494, 23);
            this.aniLink1.TabIndex = 1;
            this.aniLink1.Text = "http://jkanime.net/rezero-kara-hajimeru-isekai-seikatsu/1/";
            this.aniLink1.UseSystemPasswordChar = false;
            this.aniLink1.Click += new System.EventHandler(this.aniLink1_Click);
            this.aniLink1.TextChanged += new System.EventHandler(this.aniLink1_TextChanged);
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
            this.modeTab.Size = new System.Drawing.Size(614, 292);
            this.modeTab.TabIndex = 3;
            this.modeTab.SelectedIndexChanged += new System.EventHandler(this.modeTab_SelectedIndexChanged);
            this.modeTab.TabIndexChanged += new System.EventHandler(this.modeTab_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.clpbChk);
            this.tabPage1.Controls.Add(this.btnDwnl1);
            this.tabPage1.Controls.Add(this.aniLink1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(606, 90);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Modo Normal";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // clpbChk
            // 
            this.clpbChk.AutoSize = true;
            this.clpbChk.Depth = 0;
            this.clpbChk.Font = new System.Drawing.Font("Roboto", 10F);
            this.clpbChk.Location = new System.Drawing.Point(445, 45);
            this.clpbChk.Margin = new System.Windows.Forms.Padding(0);
            this.clpbChk.MouseLocation = new System.Drawing.Point(-1, -1);
            this.clpbChk.MouseState = MaterialSkin.MouseState.HOVER;
            this.clpbChk.Name = "clpbChk";
            this.clpbChk.Ripple = true;
            this.clpbChk.Size = new System.Drawing.Size(155, 30);
            this.clpbChk.TabIndex = 2;
            this.clpbChk.Text = "Link al Portapapeles";
            this.clpbChk.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.listDwl);
            this.tabPage2.Controls.Add(this.btnDels);
            this.tabPage2.Controls.Add(this.btnAdw);
            this.tabPage2.Controls.Add(this.numCap);
            this.tabPage2.Controls.Add(this.hastaCap);
            this.tabPage2.Controls.Add(this.lastChap);
            this.tabPage2.Controls.Add(this.unCap);
            this.tabPage2.Controls.Add(this.btnDwnl2);
            this.tabPage2.Controls.Add(this.aniLink2);
            this.tabPage2.Controls.Add(this.btnCli);
            this.tabPage2.Controls.Add(this.listSour);
            this.tabPage2.Controls.Add(this.listChap);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(606, 266);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modo Lista";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // numCap
            // 
            this.numCap.Location = new System.Drawing.Point(556, 112);
            this.numCap.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numCap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCap.Name = "numCap";
            this.numCap.Size = new System.Drawing.Size(41, 20);
            this.numCap.TabIndex = 21;
            this.numCap.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // hastaCap
            // 
            this.hastaCap.AutoSize = true;
            this.hastaCap.Depth = 0;
            this.hastaCap.Font = new System.Drawing.Font("Roboto", 10F);
            this.hastaCap.Location = new System.Drawing.Point(479, 105);
            this.hastaCap.Margin = new System.Windows.Forms.Padding(0);
            this.hastaCap.MouseLocation = new System.Drawing.Point(-1, -1);
            this.hastaCap.MouseState = MaterialSkin.MouseState.HOVER;
            this.hastaCap.Name = "hastaCap";
            this.hastaCap.Ripple = true;
            this.hastaCap.Size = new System.Drawing.Size(69, 30);
            this.hastaCap.TabIndex = 20;
            this.hastaCap.Text = "Hasta: ";
            this.hastaCap.UseVisualStyleBackColor = true;
            this.hastaCap.CheckedChanged += new System.EventHandler(this.hastaCap_CheckedChanged);
            // 
            // lastChap
            // 
            this.lastChap.AutoSize = true;
            this.lastChap.Depth = 0;
            this.lastChap.Font = new System.Drawing.Font("Roboto", 10F);
            this.lastChap.Location = new System.Drawing.Point(479, 75);
            this.lastChap.Margin = new System.Windows.Forms.Padding(0);
            this.lastChap.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lastChap.MouseState = MaterialSkin.MouseState.HOVER;
            this.lastChap.Name = "lastChap";
            this.lastChap.Ripple = true;
            this.lastChap.Size = new System.Drawing.Size(113, 30);
            this.lastChap.TabIndex = 19;
            this.lastChap.TabStop = true;
            this.lastChap.Text = "Hasta el Final";
            this.lastChap.UseVisualStyleBackColor = true;
            // 
            // unCap
            // 
            this.unCap.AutoSize = true;
            this.unCap.Checked = true;
            this.unCap.Depth = 0;
            this.unCap.Font = new System.Drawing.Font("Roboto", 10F);
            this.unCap.Location = new System.Drawing.Point(479, 45);
            this.unCap.Margin = new System.Windows.Forms.Padding(0);
            this.unCap.MouseLocation = new System.Drawing.Point(-1, -1);
            this.unCap.MouseState = MaterialSkin.MouseState.HOVER;
            this.unCap.Name = "unCap";
            this.unCap.Ripple = true;
            this.unCap.Size = new System.Drawing.Size(91, 30);
            this.unCap.TabIndex = 18;
            this.unCap.TabStop = true;
            this.unCap.Text = "1 Capitulo";
            this.unCap.UseVisualStyleBackColor = true;
            // 
            // btnDwnl2
            // 
            this.btnDwnl2.AutoSize = true;
            this.btnDwnl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDwnl2.Depth = 0;
            this.btnDwnl2.Location = new System.Drawing.Point(483, 9);
            this.btnDwnl2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDwnl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDwnl2.Name = "btnDwnl2";
            this.btnDwnl2.Primary = true;
            this.btnDwnl2.Size = new System.Drawing.Size(114, 36);
            this.btnDwnl2.TabIndex = 17;
            this.btnDwnl2.Text = "Añadir a Lista";
            this.btnDwnl2.UseVisualStyleBackColor = true;
            this.btnDwnl2.Click += new System.EventHandler(this.btnDwnl2_Click);
            // 
            // aniLink2
            // 
            this.aniLink2.BackColor = System.Drawing.Color.White;
            this.aniLink2.Depth = 0;
            this.aniLink2.Hint = "";
            this.aniLink2.Location = new System.Drawing.Point(7, 11);
            this.aniLink2.MouseState = MaterialSkin.MouseState.HOVER;
            this.aniLink2.Name = "aniLink2";
            this.aniLink2.PasswordChar = '\0';
            this.aniLink2.SelectedText = "";
            this.aniLink2.SelectionLength = 0;
            this.aniLink2.SelectionStart = 0;
            this.aniLink2.Size = new System.Drawing.Size(457, 23);
            this.aniLink2.TabIndex = 16;
            this.aniLink2.Text = "http://jkanime.net/rezero-kara-hajimeru-isekai-seikatsu/1/";
            this.aniLink2.UseSystemPasswordChar = false;
            this.aniLink2.Click += new System.EventHandler(this.aniLink2_Click);
            this.aniLink2.TextChanged += new System.EventHandler(this.aniLink2_TextChanged);
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
            // listSour
            // 
            this.listSour.FormattingEnabled = true;
            this.listSour.Location = new System.Drawing.Point(374, 47);
            this.listSour.Name = "listSour";
            this.listSour.Size = new System.Drawing.Size(90, 160);
            this.listSour.TabIndex = 1;
            this.listSour.SelectedIndexChanged += new System.EventHandler(this.listSour_SelectedIndexChanged);
            // 
            // listChap
            // 
            this.listChap.FormattingEnabled = true;
            this.listChap.Location = new System.Drawing.Point(6, 47);
            this.listChap.Name = "listChap";
            this.listChap.Size = new System.Drawing.Size(362, 160);
            this.listChap.TabIndex = 0;
            this.listChap.SelectedIndexChanged += new System.EventHandler(this.listChap_SelectedIndexChanged);
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
            this.lblTitulo.Size = new System.Drawing.Size(87, 19);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Sonry\'s Life";
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
            this.dwnlEmi.Click += new System.EventHandler(this.dwnlEmi_Click);
            // 
            // t1
            // 
            this.t1.Tick += new System.EventHandler(this.t1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar1.Location = new System.Drawing.Point(3, 689);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(609, 11);
            this.progressBar1.TabIndex = 13;
            // 
            // lblDani
            // 
            this.lblDani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDani.AutoSize = true;
            this.lblDani.Location = new System.Drawing.Point(1, 673);
            this.lblDani.Name = "lblDani";
            this.lblDani.Size = new System.Drawing.Size(157, 13);
            this.lblDani.TabIndex = 14;
            this.lblDani.Text = "No se esta Descargando Nada:";
            // 
            // lblDsp
            // 
            this.lblDsp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDsp.AutoSize = true;
            this.lblDsp.Location = new System.Drawing.Point(519, 673);
            this.lblDsp.Name = "lblDsp";
            this.lblDsp.Size = new System.Drawing.Size(0, 13);
            this.lblDsp.TabIndex = 15;
            // 
            // btnAdw
            // 
            this.btnAdw.AutoSize = true;
            this.btnAdw.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdw.Depth = 0;
            this.btnAdw.Location = new System.Drawing.Point(418, 212);
            this.btnAdw.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdw.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdw.Name = "btnAdw";
            this.btnAdw.Primary = false;
            this.btnAdw.Size = new System.Drawing.Size(181, 36);
            this.btnAdw.TabIndex = 22;
            this.btnAdw.Text = "Comenzar a Descargar";
            this.btnAdw.UseVisualStyleBackColor = true;
            this.btnAdw.Click += new System.EventHandler(this.btnAdw_Click);
            // 
            // btnDels
            // 
            this.btnDels.AutoSize = true;
            this.btnDels.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDels.Depth = 0;
            this.btnDels.Location = new System.Drawing.Point(135, 213);
            this.btnDels.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDels.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDels.Name = "btnDels";
            this.btnDels.Primary = false;
            this.btnDels.Size = new System.Drawing.Size(150, 36);
            this.btnDels.TabIndex = 23;
            this.btnDels.Text = "Eliminar Seleccion";
            this.btnDels.UseVisualStyleBackColor = true;
            this.btnDels.Visible = false;
            // 
            // autoDownloader
            // 
            this.autoDownloader.Interval = 500;
            this.autoDownloader.Tick += new System.EventHandler(this.autoDownloader_Tick);
            // 
            // listDwl
            // 
            this.listDwl.FormattingEnabled = true;
            this.listDwl.Location = new System.Drawing.Point(434, 161);
            this.listDwl.Name = "listDwl";
            this.listDwl.Size = new System.Drawing.Size(158, 43);
            this.listDwl.TabIndex = 24;
            this.listDwl.Visible = false;
            // 
            // tmrCtrl
            // 
            this.tmrCtrl.Tick += new System.EventHandler(this.tmrCtrl_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(568, 657);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "©Sonry";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 702);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDsp);
            this.Controls.Add(this.lblDani);
            this.Controls.Add(this.progressBar1);
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
            this.Text = "Anime Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.modeTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnDwnl1;
        private MaterialSkin.Controls.MaterialSingleLineTextField aniLink1;
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
        private MaterialSkin.Controls.MaterialCheckBox clpbChk;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer t1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblDani;
        private System.Windows.Forms.Label lblDsp;
        private MaterialSkin.Controls.MaterialFlatButton btnDwnl2;
        private MaterialSkin.Controls.MaterialSingleLineTextField aniLink2;
        private MaterialSkin.Controls.MaterialRadioButton unCap;
        private System.Windows.Forms.NumericUpDown numCap;
        private MaterialSkin.Controls.MaterialRadioButton hastaCap;
        private MaterialSkin.Controls.MaterialRadioButton lastChap;
        private MaterialSkin.Controls.MaterialFlatButton btnAdw;
        private MaterialSkin.Controls.MaterialFlatButton btnDels;
        private System.Windows.Forms.FolderBrowserDialog folderBD1;
        private System.Windows.Forms.Timer autoDownloader;
        private System.Windows.Forms.ListBox listDwl;
        private System.Windows.Forms.Timer tmrCtrl;
        private System.Windows.Forms.Label label1;
    }
}

