/*
 * 
 * 
 * 
	 Film Botu programının tasarımı ve kodlaması "Osman Yavuz" tarafından yapılmıştır.
	 https://twitter.com/omnyvz
     https://www.facebook.com/omnyvz
     http://hatosbilisim.com/
     http://blog.hatosbilisim.com
 * 
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Eklenenler
using HtmlAgilityPack;
using CookComputing.XmlRpc;
using JoeBlogs;

namespace Film_Botu_Source
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        // Değişkenler
        string kSiteURL = "http://filmakinesi.net/page/1";
        string kSiteHTML = null;
        string tirnak = null;

        #region Veri Ayıklama Fonksiyon
        public string ayiklananVeri;
        void veriAyiklama(string kaynakKod, string ilkVeri, int ilkVeriKS, string sonVeri)
        {
            try
            {
                string gelen = kaynakKod;
                int titleIndexBaslangici = gelen.IndexOf(ilkVeri) + ilkVeriKS;
                int titleIndexBitisi = gelen.Substring(titleIndexBaslangici).IndexOf(sonVeri);
                ayiklananVeri = gelen.Substring(titleIndexBaslangici, titleIndexBitisi);
            }
            catch //(Exception ex)
            {
                //MessageBox.Show("Hata: " + ex.Message, "Hata;", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Film Listesi Çekme Fonksiyonu
        void filmListesi()
        {
            //Film Listesi Temizle
            listView_FilmListesi.Items.Clear();

            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            kSiteHTML = client.DownloadString(kSiteURL);
            for (int i = 1; i < 26; i++)
            {
                try
                {
                    HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                    dokuman.LoadHtml(kSiteHTML);
                    HtmlNodeCollection XPath = dokuman.DocumentNode.SelectNodes("//section[@id='film_posts']/div[" + i.ToString() + "]");
                    foreach (var veri in XPath)
                    {
                        //Film Post Çıktısı
                        string filmHTML = veri.InnerHtml.Trim();

                        //Film Adı
                        veriAyiklama(filmHTML, "title=" + tirnak, 7, tirnak);
                        string filmAdi = ayiklananVeri.Replace("#038;", "");

                        //Film Url
                        veriAyiklama(filmHTML, "href=" + tirnak, 6, tirnak);
                        string filmUrl = ayiklananVeri;

                        //Film Listesine Ekleme
                        string[] ciktilar = { filmAdi, filmUrl };
                        ListViewItem veriler = new ListViewItem(ciktilar);
                        listView_FilmListesi.Items.Add(veriler);

                        //Son Güncelleme Rapor
                        label1.Text = "Son Güncelleme: " + DateTime.Now.ToString();
                    }
                    //Sonuçlar
                    label_durum.ForeColor = Color.Green;
                    label_durum.Text = "Toplam: " + listView_FilmListesi.Items.Count.ToString() + " film çekildi.";
                }
                catch
                {
                    //Sonuçlar
                    label_durum.ForeColor = Color.Red;
                    label_durum.Text = "Bir hata meydana geldi.";
                }
            }
        }
        #endregion

        #region Seçili Film Çekmek Fonksiyonu
        void seciliFilm(string filmUrl)
        {
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            kSiteHTML = client.DownloadString(filmUrl);

            //Film Adı
            try
            {
                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(kSiteHTML);
                HtmlNodeCollection XPath = dokuman.DocumentNode.SelectNodes("//h1[@id='single_h1']/a");
                foreach (var veri in XPath)
                {
                    textBox_FilmAdi.Text = veri.InnerText.Replace("#038;","");
                }
            } catch { }

            //Film Afiş
            try
            {
                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(kSiteHTML);
                HtmlNodeCollection XPath = dokuman.DocumentNode.SelectNodes("//div[@id='film_pic']/div[2]");
                foreach (var veri in XPath)
                {
                    veriAyiklama(veri.InnerHtml, "src=" + tirnak, 5, tirnak);
                    textBox_FilmAfis.Text = ayiklananVeri;
                    pictureBox1.ImageLocation = ayiklananVeri;
                }
            }
            catch { }

            //Film Kategoriler
            try
            {
                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(kSiteHTML);
                HtmlNodeCollection XPath = dokuman.DocumentNode.SelectNodes("//dl[@id='f_info']/dd[1]/a");
                foreach (var veri in XPath)
                {
                    textBox_FilmKategoriler.Text += veri.InnerText + ",";
                }
            }
            catch { }


            //Film Yapım
            try
            {
                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(kSiteHTML);
                HtmlNodeCollection XPath = dokuman.DocumentNode.SelectNodes("//dl[@id='f_info']/dd[2]");
                foreach (var veri in XPath)
                {
                    textBox_FilmYapim.Text = veri.InnerText;
                }
            }
            catch { }

            //Film IMDB
            try
            {
                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(kSiteHTML);
                HtmlNodeCollection XPath = dokuman.DocumentNode.SelectNodes("//dl[@id='f_info']/dd[3]");
                foreach (var veri in XPath)
                {
                    textBox_FilmIMDB.Text = veri.InnerText;
                }
            }
            catch { }

            //Film Yönetmen
            try
            {
                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(kSiteHTML);
                HtmlNodeCollection XPath = dokuman.DocumentNode.SelectNodes("//dl[@id='f_info']/dd[4]");
                foreach (var veri in XPath)
                {
                    textBox_FilmYonetmen.Text = veri.InnerText;
                }
            }
            catch { }

            //Film Oyuncular
            try
            {
                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(kSiteHTML);
                HtmlNodeCollection XPath = dokuman.DocumentNode.SelectNodes("//dl[@id='f_info']/dd[5]");
                foreach (var veri in XPath)
                {
                    textBox_FilmOyuncular.Text = veri.InnerText.Trim();
                }
            }
            catch { }

            //Film Etiketler
            try
            {
                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(kSiteHTML);
                HtmlNodeCollection XPath = dokuman.DocumentNode.SelectNodes("//dl[@id='f_info']/dd[6]/a");
                foreach (var veri in XPath)
                {
                   textBox_FilmEtiketler.Text += veri.InnerText + ",";
                }
            }
            catch { }

            //Film Açıklama
            try
            {
                string filmAciklama = null;

                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(kSiteHTML);
                HtmlNodeCollection XPath = dokuman.DocumentNode.SelectNodes("//article[@class='film_ozet']/p[1]");
                foreach (var veri in XPath)
                {
                    filmAciklama = veri.InnerText + Environment.NewLine;
                }
                HtmlNodeCollection XPath2 = dokuman.DocumentNode.SelectNodes("//article[@class='film_ozet']/p[2]");
                foreach (var veri2 in XPath2)
                {
                    filmAciklama += veri2.InnerText;
                }

                filmAciklama = filmAciklama.Replace("&#8217;", "'");
                filmAciklama = filmAciklama.Replace("&#8230;", "...");


                textBox_FilmAciklama.Text = filmAciklama;
            }
            catch { }

            //Film Partları
            try
            {
                //Film Part Sayısı
                int partSayisi = 2;
                try
                {
                    HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                    dokuman.LoadHtml(kSiteHTML);
                    HtmlNodeCollection XPath = dokuman.DocumentNode.SelectNodes("//div[@class='film_part']/a");
                    foreach (var veri in XPath)
                    {
                        partSayisi = partSayisi + 1;
                    }
                }
                catch { }

                for (int i = 0; i < partSayisi; i++)
                {
                    string sPart1 = null;
                    WebClient client2 = new WebClient();
                    client2.Encoding = Encoding.UTF8;
                    kSiteHTML = client2.DownloadString(filmUrl + "/" + i.ToString());

                    HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                    dokuman.LoadHtml(kSiteHTML);
                    HtmlNodeCollection XPath = dokuman.DocumentNode.SelectNodes("//div[@id='film']/p");
                    foreach (var veri in XPath)
                    {

                        sPart1 = "<p>" + veri.InnerHtml + "</p>";
                    }

                    if (sPart1.IndexOf("http://filmakinesi.net/player/") != -1) { }
                    else
                    {

                        //Sekme Başlığı
                        veriAyiklama(sPart1, "baslik:", 7, "-->");

                        //Sekme Oluşturma
                        TabPage part1 = new TabPage(ayiklananVeri);
                        tabControl_Partlar.TabPages.Add(part1);

                        //Text Oluşturma
                        RichTextBox part1text = new RichTextBox();
                        part1text.Dock = DockStyle.Fill;
                        part1text.Font = new Font(part1text.Font, FontStyle.Regular);
                        part1text.Text = sPart1;
                        part1.Controls.Add(part1text);

                        richTextBox_FilmAciklama.Text += Environment.NewLine + Environment.NewLine + sPart1;

                    }
                }
            }
            catch { }

            //Sonuçlar
            label_durum.ForeColor = Color.Blue;
            label_durum.Text = "Seçili filmin verileri çekildi.";

        }
        #endregion

        #region FORM_LOAD
        private void Form1_Load(object sender, EventArgs e)
        {
            //Düzeltmeler
            tirnak = textBox_Tirnak.Text;
        }
        #endregion

        #region Filmleri Çek Butonu
        private void button1_Click(object sender, EventArgs e)
        {
            //Textleri Temizle
            textBox_FilmAdi.Clear();
            textBox_FilmAfis.Clear();
            textBox_FilmKategoriler.Clear();
            textBox_FilmOyuncular.Clear();
            textBox_FilmYapim.Clear();
            textBox_FilmYonetmen.Clear();
            textBox_FilmAciklama.Clear();
            tabControl_Partlar.TabPages.Clear();
            richTextBox_FilmAciklama.Clear();

            //Filmleri Çek
            filmListesi();
        }
        #endregion

        #region Film Listesi Seçili Film
        private void listView_FilmListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Textleri Temizle
            textBox_FilmAdi.Clear();
            textBox_FilmAfis.Clear();
            textBox_FilmKategoriler.Clear();
            textBox_FilmOyuncular.Clear();
            textBox_FilmYapim.Clear();
            textBox_FilmYonetmen.Clear();
            textBox_FilmAciklama.Clear();
            tabControl_Partlar.TabPages.Clear();
            richTextBox_FilmAciklama.Clear();

            if (listView_FilmListesi.SelectedItems.Count == 0)
            { return; }
            ListViewItem item = listView_FilmListesi.SelectedItems[0];
            seciliFilm(item.SubItems[1].Text);
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            WordPressWrapper wrapper =
                new WordPressWrapper("http://localhost/xmlrpc.php", "sinemapub", "gerigeldim123");

            Post yazi = new Post
            {
                Title = textBox_FilmAdi.Text,
                Body = richTextBox_FilmAciklama.Text,
                Categories = textBox_FilmKategoriler.Text.Split(','),
                Tags = textBox_FilmEtiketler.Text.Split(',')
            };

            var cfs = new CustomField[] 
                { 
                    new CustomField() 
                    { 
                        Key = "dbt_film_hakkinda", 
                        Value = textBox_FilmAciklama.Text 
                    },
                    new CustomField() 
                    { 
                        Key = "new-tag-imdb", 
                        Value = textBox_FilmIMDB.Text
                    },
                    new CustomField() 
                    { 
                        Key = "new-tag-oyuncu", 
                        Value = textBox_FilmOyuncular.Text
                    },
                    new CustomField() 
                    { 
                        Key = "new-tag-yapim", 
                        Value = textBox_FilmYapim.Text
                    },
                    new CustomField() 
                    { 
                        Key = "new-tag-yonetmen", 
                        Value = textBox_FilmYonetmen.Text
                    },
                    new CustomField(){
                        Key = "_yoast_wpseo_title",
                        Value = textBox_FilmAdi.Text
                    },
                    new CustomField(){
                        Key = "_yoast_wpseo_metadesc",
                        Value = textBox_FilmAciklama.Text
                    },
                    new CustomField(){
                        Key = "_yoast_wpseo_metakeywords",
                        Value = textBox_FilmEtiketler.Text
                    }
                };
            yazi.CustomFields = cfs;

            int id = wrapper.NewPost(yazi, false);

            MessageBox.Show("Konu kimliği: " + id);
        }
    }
}
