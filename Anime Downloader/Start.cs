using HtmlAgilityPack;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anime_Downloader {
    public partial class Start : MaterialForm {
        public Start() {
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
        public ArrayList sources = new ArrayList();
        public ArrayList links = new ArrayList();
        public ArrayList linkcaps = new ArrayList();
        public ArrayList capitulos = new ArrayList();
        public dlgFuente dlgF1 = new dlgFuente();
        public string flder = "";
        private bool endcap = false;
        private bool selFuente = false;
        private bool completado = false;
        private int timers = 0;
        public string titulo = "";
        private Stopwatch sw = new Stopwatch();
        //public ArrayList aim = new ArrayList();
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
            autoDownloader.Enabled=false;
            WebDl.Encoding=Encoding.UTF8;
            WebDl.Headers[HttpRequestHeader.UserAgent]="Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2";
            WebDl.DownloadFileAsync(url, path);
            sw.Start();
            WebDl.DownloadProgressChanged+=delegate (object s, DownloadProgressChangedEventArgs e) {
            lblDani.Text="Descargando: "+listChap.Items[0]+":";
                lblDsp.Text=$"{((((double)e.BytesReceived)/1024.0)/sw.Elapsed.TotalSeconds).ToString("0.00")} kb/s";
                progressBar1.Value=e.ProgressPercentage;
            autoDownloader.Enabled=false;
                if (e.ProgressPercentage>=0x5f) {
                    refe=1;
                }
                else {
                    refe=0;
                }
            };
            WebDl.DownloadFileCompleted+=delegate (object s, AsyncCompletedEventArgs e) {
            progressBar1.Value=0;
                if ((refe==0)&&(cont>0)) {
            lblDani.Text="Detenido, Error x03";
                    lblDsp.Text="";
                    sw.Reset();
                    delLis();
                }
                else {
            lblDani.Text="Descargas Completadas:";
                    lblDsp.Text="";
                    sw.Reset();
                    refe=0;
                    timers=0;
                   tmrCtrl.Enabled=true;
                }
            };
        }

        //Descargador Normal

        private void dwnAni(Uri url, string path) {
            WebDl.Encoding=Encoding.UTF8;
            WebDl.Headers[HttpRequestHeader.UserAgent]="Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.103 Safari/537.36";
            WebDl.Headers[HttpRequestHeader.Cookie]=CookieMonster1.Document.Cookie;
            if (url.ToString().Contains("animeflv.net")) {
                Uri address = new Uri(specDownload(url.ToString()));
                WebDl.DownloadFileAsync(address, path);
                sw.Start();
                WebDl.DownloadProgressChanged+=delegate (object s, DownloadProgressChangedEventArgs e) {
                    lblDani.Text="Descargando: "+titulo+":";
                    lblDsp.Text=$"{((((double)e.BytesReceived)/1024.0)/sw.Elapsed.TotalSeconds).ToString("0.00")} kb/s";
                    progressBar1.Value=e.ProgressPercentage;
                };
                WebDl.DownloadFileCompleted+=delegate (object s, AsyncCompletedEventArgs e) {
                    progressBar1.Value=0;
                    lblDani.Text="Descarga Completa:";
                    lblDsp.Text="";
                    sw.Reset();
                    lblDsp.Text="";
                    MessageBox.Show("Descarga Completa!");
                };
            }
            else {
                WebDl.DownloadFileAsync(url, path);
                sw.Start();
                WebDl.DownloadProgressChanged+=delegate (object s, DownloadProgressChangedEventArgs e) {
                    lblDani.Text="Descargando: "+titulo+":";
                    progressBar1.Value=e.ProgressPercentage;
                    lblDsp.Text=$"{((((double)e.BytesReceived)/1024.0)/sw.Elapsed.TotalSeconds).ToString("0.00")} kb/s";
                };
                WebDl.DownloadFileCompleted+=delegate (object s, AsyncCompletedEventArgs e) {
                    progressBar1.Value=0;
                    lblDani.Text="Descarga Completa:";
                    sw.Reset();
                    lblDsp.Text="";
                    MessageBox.Show("Descarga Completa!");
                };
            }
        }

        //Descargas especiales
        private string specDownload(string url) {
            string attributeValue = "";
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            string html = WebDl.DownloadString(url);
            document.LoadHtml(html);
            HtmlNodeCollection nodes = document.DocumentNode.SelectNodes("//meta[@http-equiv='refresh']");
            foreach (HtmlNode node in (IEnumerable<HtmlNode>)nodes) {
                attributeValue=node.GetAttributeValue("content", "");
            }
            return attributeValue.Replace("0; URL=", "");
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
        //jkanime
        private void jkanime(string CUrl, string src) {
            HtmlAgilityPack.HtmlDocument AniDoc = SNav(CUrl);
            HtmlNodeCollection Sources = AniDoc.DocumentNode.SelectNodes("//a");
            HtmlNodeCollection Urls = AniDoc.DocumentNode.SelectNodes("//iframe");
            HtmlNodeCollection Titles = AniDoc.DocumentNode.SelectNodes("//div[@class='vervideo']");
            int num = 0;
            if (Sources!=null) {
                foreach (HtmlNode Source in (IEnumerable<HtmlNode>)Sources) {
                    if (Source.Id.Contains("btn-show-")) {
                        sources.Add(Source.InnerText);
                    }
                }
            }
            if (Urls!=null) {
                foreach (HtmlNode Url in (IEnumerable<HtmlNode>)Urls) {
                    if (Url.GetAttributeValue("src", "falso").Contains("jkmedia")) {
                        links.Add(Url.GetAttributeValue("src", "falso").Replace("jk.php?u=", ""));
                        num++;
                    }
                }
            }
            if (Titles!=null) {
                //Text=Text+": "+Titles[0].InnerText;
                titulo=Titles[0].InnerText;
            }
            //numC1.Text=num.ToString();
            if (src.Equals("boton")) {
                if (!selFuente) {
                    dlgF1.sources=sources;
                    dlgF1.cant=num;
                    dlgF1.ShowDialog();
                    selFuente=true;
                }
            }
            else if (Titles!=null) {
                if (!selFuente) {
                    dlgF1.sources=sources;
                    dlgF1.cant=num;
                    dlgF1.ShowDialog();
                    selFuente=true;
                }
                if (((links.Count-1)<dlgF1.selectd)||(links.Count>(dlgF1.selectd+1))) {
                    if (sources.IndexOf(dlgF1.fname)!=-1) {
                        listChap.Items.Add(Titles[0].InnerText);
                        linkcaps.Add(links[sources.IndexOf(dlgF1.fname)]);
                        listSour.Items.Add(sources[sources.IndexOf(dlgF1.fname)]);
                    }
                    else {
                        listChap.Items.Add(Titles[0].InnerText);
                        linkcaps.Add(links[0]);
                        listSour.Items.Add(sources[0]);
                    }
                }
                else {
                    listChap.Items.Add(Titles[0].InnerText);
                    linkcaps.Add(links[dlgF1.selectd]);
                    listSour.Items.Add(sources[dlgF1.selectd]);
                }
            }
            else {
                //infLis1.Hide();
                //MessageBox.Show("Terminado, Capitulos a\x00f1adidos a la Lista");
                endcap=true;
            }
        }

        //AnimeFLV
        private void animeflv(string CUrl, string src) {
            HtmlAgilityPack.HtmlDocument document = SNav(CUrl);
            HtmlNodeCollection Sources = document.DocumentNode.SelectNodes("//b");
            HtmlNodeCollection Urls = document.DocumentNode.SelectNodes("//a");
            HtmlNodeCollection Titles = document.DocumentNode.SelectNodes("//h1");
            int num = 0;
            if (Sources!=null) {
                foreach (HtmlNode Source in (IEnumerable<HtmlNode>)Sources) {
                    if (Source.InnerText.Contains("Opci\x00f3n D")) {
                        sources.Add(Source.InnerText);
                    }
                }
            }
            else {
                //textBox3.Text = textBox3.Text + "ecap!x203";
                endcap=true;
            }
            if (Urls!=null) {
                foreach (HtmlNode Url in (IEnumerable<HtmlNode>)Urls) {
                    if (Url.GetAttributeValue("href", "falso").Contains("d.php")) {
                        links.Add(Url.GetAttributeValue("href", "falso"));
                        num++;
                    }
                }
            }
            else {
                //textBox3.Text = textBox3.Text + "ecap!x203";
                endcap=true;
            }
            if (Titles!=null) {
                //Text=Text+": "+Titles[0].InnerText;
                titulo=Titles[0].InnerText;
            }
            else {
                //textBox3.Text = textBox3.Text + "ecap!x203";
                endcap=true;
            }
            //numC1.Text=num.ToString();
            if (!src.Equals("boton")) {
                if (Titles!=null) {
                    listChap.Items.Add(Titles[0].InnerText);
                    linkcaps.Add(links[0]);
                    listSour.Items.Add(sources[0]);
                }
                else {
                    //infLis1.Hide();
                    MessageBox.Show("Terminado, Capitulos a\x00f1adidos a la Lista");
                    endcap=true;
                }
            }
        }

        //AnimeYT
        private void animeYT(string CUrl, string src) {
            HtmlAgilityPack.HtmlDocument document = SNav(CUrl);
            HtmlNodeCollection Scripts = document.DocumentNode.SelectNodes("//script");
            HtmlNodeCollection Descs = document.DocumentNode.SelectNodes("//a");
            HtmlNodeCollection Urls = document.DocumentNode.SelectNodes("//link[@rel='image_src']");
            HtmlNodeCollection Titles = document.DocumentNode.SelectNodes("//h1");
            if (Descs!=null) {
                foreach (HtmlNode Desc in (IEnumerable<HtmlNode>)Descs) {
                    if (Desc.GetAttributeValue("href", "falso").Contains("descargar")) {
                        string oldValue = "http://www.animeyt.tv/descargar/";
                        string str2 = Desc.GetAttributeValue("href", "falso").Replace(oldValue, "");
                        //textBox3.Text = textBox3.Text + str2;
                        links.Add("http://api.animeyt.tv/api/mirror1/"+str2);
                        links.Add("http://api.animeyt.tv/api/mirror6/"+str2);
                        sources.Add("720p 1");
                        sources.Add("720p 2 (Recomendado)");
                        //numC1.Text="2";
                        cont=2;
                    }
                }
            }
            else {
                //textBox3.Text = textBox3.Text + "ecap!x203";
                endcap=true;
            }
            if (Urls!=null) {
                foreach (HtmlNode Url in (IEnumerable<HtmlNode>)Urls) {
                    if (Url.GetAttributeValue("href", "falso").Contains("banner")) {
                        string str3 = "http://www.animeyt.tv/files/img/series/";
                        char[] separator = new char[] { '_' };
                        string[] strArray = Url.GetAttributeValue("href", "falso").Replace(str3, "").Split(separator);
                        links.Add(string.Concat(new object[] { "http://s2.animeyt.tv/lola.php?cd=", strArray[1], "&file=", numeroLink() }));
                        links.Add(string.Concat(new object[] { "http://s2.animeyt.tv/naruto.php?id=", strArray[1], "&file=", numeroLink(), ".mp4" }));
                        links.Add(string.Concat(new object[] { "http://s4.animeyt.tv/chumi.php?cd=", strArray[1], "&file=", numeroLink() }));
                        sources.Add("Lola");
                        sources.Add("Naruto");
                        sources.Add("Chumi");
                        //numC1.Text = "5";
                        cont=5;
                    }
                }
            }
            else {
                //infLis1.Hide();
                endcap=true;
            }
            if (Titles!=null) {
                string str5 = Titles[0].InnerText.Replace("sub espa\x00f1ol", "").Replace("\n", "");
                //Text = Text + ": " + str5;
                titulo=str5;
            }
            else {
                //infLis1.Hide();
                endcap=true;
            }
            if (src.Equals("boton")) {
                if (!selFuente) {
                    dlgF1.sources=sources;
                    dlgF1.cant=cont;
                    dlgF1.ShowDialog();
                    selFuente=true;
                }
            }
            else if (Titles!=null) {
                string item = Titles[0].InnerText.Replace("sub espa\x00f1ol", "").Replace("\n", "");
                if (!selFuente) {
                    dlgF1.sources=sources;
                    dlgF1.cant=cont;
                    dlgF1.ShowDialog();
                    selFuente=true;
                }
                if (((links.Count-1)<dlgF1.selectd)||(links.Count>(dlgF1.selectd+1))) {
                    if (sources.IndexOf(dlgF1.fname)!=-1) {
                        listChap.Items.Add(item);
                        linkcaps.Add(links[sources.IndexOf(dlgF1.fname)]);
                        listSour.Items.Add(sources[sources.IndexOf(dlgF1.fname)]);
                    }
                    else {
                        listChap.Items.Add(item);
                        linkcaps.Add(links[0]);
                        listSour.Items.Add(sources[0]);
                    }
                }
                else {
                    listChap.Items.Add(item);
                    linkcaps.Add(links[dlgF1.selectd]);
                    listSour.Items.Add(sources[dlgF1.selectd]);
                }
            }
            else {
                //infLis1.Hide();
                MessageBox.Show("Terminado, Capitulos a\x00f1adidos a la Lista");
                endcap=true;
            }
        }

        //Obtiene numero de capitulo desde el link
        private int numeroLink() {
            if (aniLink2.Text.Contains("jkanime.net")) {
                char ch = '/';
                char[] separator = new char[] { ch };
                string[] strArray = aniLink2.Text.Split(separator);
                if (strArray.Length>=6) {
                    return int.Parse(strArray[strArray.Length-2]);
                }
                return int.Parse(strArray[strArray.Length-1]);
            }
            if (aniLink2.Text.Contains("animeflv.net")) {
                char ch2 = '/';
                char[] chArray2 = new char[] { ch2 };
                string str3 = aniLink2.Text.Split(chArray2)[4].Replace(".html", "");
                char ch3 = '-';
                char[] chArray3 = new char[] { ch3 };
                string[] strArray3 = str3.Split(chArray3);
                string s = strArray3[strArray3.Length-1];
                return int.Parse(s);
            }
            if (aniLink2.Text.Contains("animeyt.tv")) {
                char ch4 = '/';
                char[] chArray4 = new char[] { ch4 };
                string str6 = aniLink2.Text.Split(chArray4)[4].Replace("-sub-espanol", "");
                char ch5 = '-';
                char[] chArray5 = new char[] { ch5 };
                string[] strArray5 = str6.Split(chArray5);
                string str7 = strArray5[strArray5.Length-1];
                return int.Parse(str7);
            }
            return 0;
        }
        //Lista animes
        private void listAnime() {
            int count = listChap.Items.Count;
            inicio();
            t1.Enabled=true;
            if (capitulos[count].ToString().Contains("jkanime")) {
                jkanime(aniLink2.Text, "lista");
            }
            if (capitulos[count].ToString().Contains("animeflv")) {
                animeflv(aniLink2.Text, "lista");
            }
            if (capitulos[count].ToString().Contains("animeyt")) {
                //animeYT(aniLink2.Text, "lista");
            }
        }
        //Lista Capitulos
        private void capsAnime(string capu) {
            int count = listChap.Items.Count;
            inicio();
            t1.Enabled=true;
            if (capitulos[count].ToString().Contains("jkanime")) {
                jkanime(capu, "lista");
            }
            if (capitulos[count].ToString().Contains("animeflv")) {
                animeflv(capu, "lista");
            }
            if (capitulos[count].ToString().Contains("animeyt")) {
                //animeYT(capu, "lista");
            }
        }
        //Limpiador de residuos
        private void delLis() {
            capitulos.Clear();
            linkcaps.Clear();
            btnAdw.Enabled=true;
            btnDels.Enabled=true;
            btnCli.Enabled=true;
            linkcaps.Clear();
            sources.Clear();
            lblDani.Text="No se est\x00e1 descargando nada:";
            lblDsp.Text="";
        }

        //Añade capitulos dependiendo de la opcion del usuario
        private void agregaCapitulos(int ini, int fin) {
            MessageBox.Show("Dependiendo de la cantidad de capitulos es la demora del programa en encontrarlos, presiona Aceptar para continuar :D");
            if (aniLink2.Text.Contains("jkanime.net")) {
                string[] strArray;
                char ch = '/';
                string str2 = "";
                endcap=false;
                if (aniLink2.Text.Contains("http://")||aniLink2.Text.Contains("https://")) {
                    char[] separator = new char[] { ch };
                    strArray=aniLink2.Text.Split(separator);
                    if (strArray.Length>=6) {
                        for (int i = 0; i<=(strArray.Length-3); i++) {
                            str2=str2+strArray[i]+"/";
                        }
                    }
                    else {
                        for (int j = 0; j<=(strArray.Length-2); j++) {
                            str2=str2+strArray[j]+"/";
                        }
                    }
                    //infLis1.Show();
                    while (!endcap) {
                        if (ini==fin) {
                            //infLis1.Hide();
                            MessageBox.Show("Terminado, Capitulos a\x00f1adidos a la Lista");
                            endcap=true;
                        }
                        //infLis1.cambioTexto(titulo);
                        //textBox3.Text=ini+textBox3.Text+"|";
                        inicio();
                        capitulos.Add(str2+ini);
                        capsAnime(str2+ini);
                        ini++;
                    }
                }
                else {
                    aniLink2.Text="http://"+aniLink2.Text;
                    char[] chArray2 = new char[] { ch };
                    strArray=aniLink2.Text.Split(chArray2);
                    if (strArray.Length>=6) {
                        for (int k = 0; k<=(strArray.Length-3); k++) {
                            str2=str2+strArray[k]+"/";
                        }
                    }
                    else {
                        for (int m = 0; m<=(strArray.Length-2); m++) {
                            str2=str2+strArray[m]+"/";
                        }
                    }
                    //infLis1.Show();
                    while (!endcap) {
                        if (ini==fin) {
                            //infLis1.Hide();
                            MessageBox.Show("Terminado, Capitulos a\x00f1adidos a la Lista");
                            endcap=true;
                        }
                        //infLis1.cambioTexto(titulo);
                        inicio();
                        capitulos.Add(str2+ini);
                        capsAnime(str2+ini);
                        ini++;
                    }
                }
            }
            else if (aniLink2.Text.Contains("animeflv.net")) {
                endcap=false;
                string str3 = "http://animeflv.net/ver/";
                string str5 = "";
                char ch2 = '/';
                char[] chArray3 = new char[] { ch2 };
                string str6 = aniLink2.Text.Split(chArray3)[4].Replace(".html", "");
                char ch3 = '-';
                char[] chArray4 = new char[] { ch3 };
                string[] strArray3 = str6.Split(chArray4);
                for (int n = 0; n<=(strArray3.Length-2); n++) {
                    str5=str5+strArray3[n]+"-";
                }
                //infLis1.Show();
                while (!endcap) {
                    if (ini==fin) {
                        //infLis1.Hide();
                        MessageBox.Show("Terminado, Capitulos a\x00f1adidos a la Lista");
                        endcap=true;
                    }
                    //infLis1.cambioTexto(titulo);
                    inicio();
                    capitulos.Add(string.Concat(new object[] { str3, str5, ini, ".html" }));
                    capsAnime(string.Concat(new object[] { str3, str5, ini, ".html" }));
                    ini++;
                }
            }
            else if (aniLink2.Text.Contains("animeyt.tv")) {
                endcap=false;
                string str7 = "http://animeyt.tv/ver/";
                string str9 = "";
                char ch4 = '/';
                char[] chArray5 = new char[] { ch4 };
                string str10 = aniLink2.Text.Split(chArray5)[4].Replace("-sub-espanol", "");
                char ch5 = '-';
                char[] chArray6 = new char[] { ch5 };
                string[] strArray5 = str10.Split(chArray6);
                for (int num6 = 0; num6<=(strArray5.Length-2); num6++) {
                    str9=str9+strArray5[num6]+"-";
                }
                //infLis1.Show();
                while (!endcap) {
                    if (ini==fin) {
                        //infLis1.Hide();
                        MessageBox.Show("Terminado, Capitulos a\x00f1adidos a la Lista");
                        endcap=true;
                    }
                    //infLis1.cambioTexto(titulo);
                    inicio();
                    capitulos.Add(string.Concat(new object[] { str7, str9, ini, "-sub-espanol" }));
                    capsAnime(string.Concat(new object[] { str7, str9, ini, "-sub-espanol" }));
                    ini++;
                }
            }
        }

        private void emiStart() {
            lblTitulo.ForeColor=Color.White;
            lblAtit.ForeColor=Color.White;
            lblCont.ForeColor=Color.White;
            lblEpis.ForeColor=Color.White;
            lblCont.Parent=animePic;
            lblEpis.Parent=animePic;
            lblTitulo.Parent=animePic;
            lblAtit.Parent=animePic;
            dwnlEmi.Parent=animePic;
            obtenerDestacados("http://jkanime.net");
            t2.Enabled=true;
            lblTitulo.Text=tc[r+r].ToString();
            lblEpis.Text=tc[(r+r)+1].ToString();
            animePic.ImageLocation=aim[r].ToString();
            //            this.linkDest = this.ln[this.r].ToString();
            lblCont.Text=(r+1)+"/"+ln.Count;
            r++;
        }

        private void inicio() {
            completado=false;
            //comboBox1.Enabled = false;
            //comboBox1.Text = "";
            links.Clear();
            sources.Clear();
            //comboBox1.Items.Clear();
            //numC1.Text = "0";
            //this.Text = "Sonry Anime Downloader Beta 4.8";
        }

        private void Form1_Load(object sender, EventArgs e) {
            inicio();
            Size=new Size(614, 520);
            modeTab.Size=new Size(614, 116);
            CookieMonster1.Navigate("http://jkanime.net");
            CookieMonster1.Stop();
            emiStart();           
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

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e) {
            animePic.Visible=false;
        }
        private void toggleEmision() {
            if (animePic.Visible==true) {
                animePic.Visible=false;
                modeTab.Location = new Point(0,85);
                if (modeTab.SelectedIndex == 0) {
                    Size=new Size(614, 241);
                }else {
                    Size=new Size(614, 403);
                }
                
            }
            else {
                animePic.Visible=true;
                modeTab.Location=new Point(0, 364);
                Size=new Size(614, 682);
                if (modeTab.SelectedIndex==0) {
                    Size=new Size(614, 520);
                }
                else {
                    Size=new Size(614, 682);
                }
            }
        }
        private void materialRaisedButton1_Click(object sender, EventArgs e) {
            toggleEmision();
            //Fuente f = new Fuente();
            
        }

        private void materialTabSelector1_Click(object sender, EventArgs e) {
            //MessageBox.Show(modeTab.SelectedIndex.ToString());
            if (modeTab.SelectedIndex==0) {
                modeTab.Size=new Size(614, 116);
                
            }
            else {
                
                modeTab.Size=new Size(614, 282);
            }
        }

        private void t1_Tick(object sender, EventArgs e) {
            if (sources.Count<0) {
                t1.Enabled=false;
                MessageBox.Show("La url no contiene ningun capitulo ni fuentes, revisa bien.");
            }
        }

        private void btnDwnl1_Click(object sender, EventArgs e) {
            selFuente=false;
            inicio();
            t1.Enabled=true;
            if (aniLink1.Text.Contains("jkanime")) {
                jkanime(aniLink1.Text, "boton");
            }
            //if (aniLink1.Text.Contains("animeflv")) {
            //    animeflv(aniLink1.Text, "boton");
           // }
           // if (textBox1.Text.Contains("animeyt")) {
           //     animeYT(textBox1.Text, "boton");
           // }
            if (clpbChk.Checked) {
                Clipboard.SetText(links[dlgF1.selectd].ToString());
                MessageBox.Show("El Link ha sido copiado al Portapapeles", "Sonry Anime Downloader");
            }
            else {
                saveFileDialog1.FileName=titulo;
                saveFileDialog1.DefaultExt="mp4";
                saveFileDialog1.Filter="Archivo de Video mp4 (*.mp4)|*.mp4";
                if (saveFileDialog1.ShowDialog()==DialogResult.OK) {
                    string fileName = saveFileDialog1.FileName;
                    Uri url = new Uri(links[dlgF1.selectd].ToString());
                    dwnAni(url, fileName);
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e) {

        }

        private void modeTab_TabIndexChanged(object sender, EventArgs e) {
           
        }

        private void modeTab_SelectedIndexChanged(object sender, EventArgs e) {
            /*if (modeTab.SelectedIndex==0) {
                modeTab.Size=new Size(614, 116);
            }
            else {

                modeTab.Size=new Size(614, 282);
            }*/
            if (animePic.Visible==false) {
                //animePic.Visible=false;
                modeTab.Location=new Point(0, 85);
                if (modeTab.SelectedIndex==0) {
                    modeTab.Size=new Size(614, 116);
                    Size=new Size(614, 241);
                }
                else {
                    modeTab.Size=new Size(614, 282);
                    Size=new Size(614, 403);
                }

            }
            else {
                //animePic.Visible=true;
                modeTab.Location=new Point(0, 364);
                Size=new Size(614, 682);
                if (modeTab.SelectedIndex==0) {
                    modeTab.Size=new Size(614, 116);
                    Size=new Size(614, 520);
                }
                else {
                    modeTab.Size=new Size(614, 282);
                    Size=new Size(614, 682);

                }
            }
        }

        private void btnDwnl2_Click(object sender, EventArgs e) {
            selFuente=false;
            if (unCap.Checked) {
                if (aniLink2.Text.Contains("http://")||aniLink2.Text.Contains("https://")) {
                    inicio();
                    dlgF1.Size=new Size(dlgF1.Size.Width, 0x83);
                    selFuente=dlgF1.noask;
                    dlgF1.selvis=true;
                    capitulos.Add(aniLink2.Text);
                    listAnime();
                }
                else {
                    aniLink2.Text="http://"+aniLink2.Text;
                    inicio();
                    dlgF1.Size=new Size(dlgF1.Size.Width, 0x83);
                    selFuente=dlgF1.noask;
                    dlgF1.selvis=true;
                    capitulos.Add(aniLink2.Text);
                    listAnime();
                }
            }
            if (lastChap.Checked) {
                agregaCapitulos(numeroLink(), 0x3e8);
                dlgF1.Size=new Size(dlgF1.Size.Width, 0x6a);
                dlgF1.selvis=false;
            }
            if (hastaCap.Checked) {
                if (int.Parse(numCap.Value.ToString())<numeroLink()) {
                    MessageBox.Show("Debes ingresar un numero de Capitulo Mayor al del Link, como por ejemplo el: "+(numeroLink()+1));
                    numCap.Value=numeroLink()+1;
                    dlgF1.selvis=false;
                }
                else {
                    agregaCapitulos(numeroLink(), int.Parse(numCap.Value.ToString()));
                    dlgF1.Size=new Size(dlgF1.Size.Width, 0x6a);
                    dlgF1.selvis=false;
                }
            }
        }

        private void aniLink1_Click(object sender, EventArgs e) {

        }

        private void aniLink1_TextChanged(object sender, EventArgs e) {
            aniLink2.Text=aniLink1.Text;
        }

        private void aniLink2_Click(object sender, EventArgs e) {

        }

        private void aniLink2_TextChanged(object sender, EventArgs e) {
            aniLink1.Text=aniLink2.Text;
        }

        private void btnAdw_Click(object sender, EventArgs e) {
            if (listChap.Items.Count>0) {
                btnAdw.Enabled=false;
                btnDels.Enabled=false;
                btnCli.Enabled=false;
                folderBD1.Description="Seleccione el Directorio en el que se van a descargar los Capitulos de la Lista";
                folderBD1.ShowDialog();
                flder=folderBD1.SelectedPath;
                cont=listChap.Items.Count;
                autoDownloader.Enabled=true;
            }
            else {
                MessageBox.Show("A\x00f1ada algun cap\x00edtulo a la lista antes de iniciar una descarga", "Error");
            }
        }

        private void autoDownloader_Tick(object sender, EventArgs e) {
            char[] separators = new char[] { '\\', '/', ':', '?', '¿', '"','<','>','|' };
            cont=listChap.Items.Count;
            if (cont>=1) {
                string caname = listChap.Items[0].ToString();
                string[] temp = caname.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                caname=String.Join(" ", temp);
                //caname = caname.Replace(separators, "\n");
                object[] objArray1 = new object[] { flder, @"\", caname , ".mp4" };
                string path = string.Concat(objArray1);
                Uri url = new Uri(linkcaps[0].ToString());
                BajarLista(url, path);
                autoDownloader.Enabled=false;
            }
            else {
                autoDownloader.Enabled=false;
                MessageBox.Show("Descarga de Lista Completada!");
                delLis();
            }
        }

        private void tmrCtrl_Tick(object sender, EventArgs e) {
            if (timers==1) {
                listDwl.Items.Add(listChap.Items[0]);
                listChap.Items.RemoveAt(0);
                listSour.Items.RemoveAt(0);
                capitulos.RemoveAt(0);
                linkcaps.RemoveAt(0);
                autoDownloader.Enabled=true;
            }
            timers++;
        }

        private void hastaCap_CheckedChanged(object sender, EventArgs e) {
            numCap.Value=numeroLink()+1;
        }

        private void dwnlEmi_Click(object sender, EventArgs e) {
            if (modeTab.SelectedIndex==0) {
                aniLink1.Text=ln[(r==0 ? 0 : r-1)].ToString();
                btnDwnl1_Click(sender,e);
                //modeTab.Size=new Size(614, 116);
            }
            else {
                aniLink2.Text=ln[(r==0?0:r-1)].ToString();
                btnDwnl2_Click(sender, e);
                //modeTab.Size=new Size(614, 282);
            }
        }

        private void listChap_SelectedIndexChanged(object sender, EventArgs e) {
            listSour.SelectedIndex=listChap.SelectedIndex;
            btnDels.Visible=true;
        }

        private void listSour_SelectedIndexChanged(object sender, EventArgs e) {
            listChap.SelectedIndex = listSour.SelectedIndex;
            btnDels.Visible=true;
        }

        private void label1_Click(object sender, EventArgs e) {
            MessageBox.Show("Sonry Anime Downloader Beta MD1 \n Descarga animes desde JkAnime, AnimeFlv y AnimeYT completamente gratis.\n\n La cantidad de fuentes dependen de cada sitio, anim\x00e9 y cap\x00edtulo.\n\n Fuentes actualmente disponibles: AnimeFlv, JkAnime y AnimeYT.\n\nBugs:\n-Se necesita Debug.\n\n Por Hacer: \n-A\x00f1adir m\x00e1s fuentes.\n-Editor de fuentes en listas.\n \n Utilizamos librer\x00edas de: \n -HtmlAgilityPack \n MaterialSkin \n -Sonry Rem 2.7 \n\nOrigenes totalmente independientes a los Servidores de Sonry \n\n \x00a92016 Sonry Corporation", "Acerca De Sonry Anime Downloader");

        }
    }
}
