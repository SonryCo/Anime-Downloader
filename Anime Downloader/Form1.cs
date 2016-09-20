using HtmlAgilityPack;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anime_Downloader {
    public partial class Form1 : MaterialForm {
        public Form1() {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme=MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme=new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.LightBlue200, TextShade.WHITE);
        }

        private WebClient WebCli = new WebClient();
        private WebClient WebDl = new WebClient();
        public ArrayList ln = new ArrayList();
        public ArrayList tc = new ArrayList();
        public ArrayList aim = new ArrayList();
        public int cont = 0;
        public int r = 0;
        //SADOLDRES
        private HtmlAgilityPack.HtmlDocument SNav(string url) {
            WebCli.Encoding=Encoding.UTF8;
            WebCli.Headers[HttpRequestHeader.UserAgent]="Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.103 Safari/537.36";
            WebCli.Headers[HttpRequestHeader.Cookie]=CookieMonster1.Document.Cookie;
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            try {
                string html = this.WebCli.DownloadString(url);
                document.LoadHtml(html);
                return document;
            }
            catch (WebException exception) {
                if (exception.Message.Contains("404")) {
                    //this.ilog=exception.Message;
                }
                else {
                    MessageBox.Show("Error De Windows:"+exception.Message+"\n En caso de ser grave, infomar a Sonry", "No te preocupes");
                }
                return document;
            }
        }

        //Descargas de Lista
        private void BajarLista(Uri url, string path) {
            int refe = 0;
        //TIMER    autoDownloader.Enabled=false;
            WebDl.Encoding=Encoding.UTF8;
            WebDl.Headers[HttpRequestHeader.UserAgent]="Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2";
            WebDl.DownloadFileAsync(url, path);
            WebDl.DownloadProgressChanged+=delegate (object s, DownloadProgressChangedEventArgs e) {
       //         label10.Text="Descargando: "+listBox1.Items[0]+":";
       //PB         progressBar1.Value=e.ProgressPercentage;
       //         autoDownloader.Enabled=false;
                if (e.ProgressPercentage>=0x5f) {
                    refe=1;
                }
                else {
                    refe=0;
                }
            };
            WebDl.DownloadFileCompleted+=delegate (object s, AsyncCompletedEventArgs e) {
            //PONER PBAR   progressBar1.Value=0;
                if ((refe==0)&&(cont>0)) {
            //Label de avisos        label10.Text="Detenido, Error x03";
           //         delLis();
                }
                else {
          //          label10.Text="Descargas Completadas:";
                    refe=0;
         //           timers=0;
         //           timer1.Enabled=true;
                }
            };
        }

        //Destacados
        private void obtenerDestacados(string fuente) {
            HtmlAgilityPack.HtmlDocument document = SNav(fuente);
            HtmlNodeCollection EtA = document.DocumentNode.SelectNodes("//a");
            HtmlNodeCollection Img = document.DocumentNode.SelectNodes("//img");
            HtmlNodeCollection EpS = document.DocumentNode.SelectNodes("//strong");

            if (EtA!=null) {
                foreach (HtmlNode Et in (IEnumerable<HtmlNode>)EtA) {
                    HtmlAttribute attribute = Et.Attributes["href"];
                    if (Et.InnerHtml.Contains("#htmlcaption-")) {
                        ln.Add(attribute.Value);
                    }
                }
            }
            if (Img!=null) {
                foreach (HtmlNode Im in (IEnumerable<HtmlNode>)Img) {
                    HtmlAttribute attribute = Im.Attributes["src"];

                   if (attribute.Value.Contains("jkvideo")) {
                    //MessageBox.Show(attribute.Value);
                    aim.Add(attribute.Value);

                    }
                }
            }
            if (EpS!=null) {
                foreach (HtmlNode Ep in (IEnumerable<HtmlNode>)EpS) {
                    if (Ep.InnerHtml.Contains("Episodio")) {
                        string str = Ep.InnerHtml.Replace("\n", "").Replace(" ", "").Replace("Episodio", "Episodio ").Replace("\t", "");
                        tc.Add(str);
                    }
                    else {
                        tc.Add(Ep.InnerHtml.Replace("\n", ""));
                    }
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e) {
            CookieMonster1.Navigate("http://jkanime.net");
            CookieMonster1.Stop();
            label1.Parent=animePic;
            //lblCont.Parent=animePic;
            //lblEpis.Parent=animePic;
            lblTitulo.Parent=animePic;
            obtenerDestacados("http://jkanime.net");
            t2.Enabled=true;
            lblTitulo.Text=tc[r+r].ToString();
            lblEpis.Text=tc[(r+r)+1].ToString();
            animePic.ImageLocation = aim[r].ToString();
            //            this.linkDest = this.ln[this.r].ToString();
            lblCont.Text=(r+1)+"/"+ln.Count;
            r++;
        }

        private void tabPage1_Click(object sender, EventArgs e) {

        }

        private void t2_Tick(object sender, EventArgs e) {
            lblTitulo.Text=tc[r+r].ToString();
            lblEpis.Text=tc[(r+r)+1].ToString();
            animePic.ImageLocation=aim[r].ToString();
            lblCont.Text=(r+1)+"/"+ln.Count;
            //linkDest=this.ln[this.r].ToString();
            if (((r+r)+1)<(tc.Count-1)) {
                r++;
            }
            else {
                r=0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }
    }
}
