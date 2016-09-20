using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anime_Downloader {
    public partial class dlgFuente : MaterialForm {
        public int cant = 0;
        public string fname = "";
        public bool noask = false;
        public int selectd = 0;
        public bool selvis = false;
        public ArrayList sources = new ArrayList();

        public dlgFuente() {
            InitializeComponent();
        }

        private void selectBtn_Click(object sender, EventArgs e) {
            selectd=fuenteLista1.SelectedIndex;
            fname=fuenteLista1.Text;
            Close();
        }

        private void dlgFuente_Load(object sender, EventArgs e) {
            BackColor=Form.ActiveForm.BackColor;
            chkNOP.Visible=selvis;
            fuenteLista1.Items.Clear();
            for (int i = 0; i<cant; i++) {
                fuenteLista1.Items.Add(sources[i]);
            }
            fuenteLista1.SelectedIndex=0;
        }

        private void chkNOP_CheckedChanged(object sender, EventArgs e) {
            noask=chkNOP.Checked;
        }
    }
}
