using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_star_ile_8_taş
{
    
    public partial class Form1 : Form
    {
        Astar Astar;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void chc_baslangic_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_baslangic.Checked==true)
            {
                textBox1.Enabled = true;
                chc_bitis.Checked = false;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

        private void chc_bitis_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_bitis.Checked == true)
            {
                textBox2.Enabled = true;
                chc_baslangic.Checked = false;
            }
            else
            {
                textBox2.Enabled = false;
            }
        }
        public void butonsayıları(KeyPressEventArgs e,string yazi,string buton)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            List<int> randomListe = new List<int>();
            for (int i = 0; i < yazi.Length; i++)
            {
                if (e.KeyChar == yazi[i] || e.KeyChar == '9')
                {
                   
                    e.Handled = true;
                    break;
                }
            }
            if (e.KeyChar == 13)
            {
                if (yazi.Length <= 8)
                {
                    MessageBox.Show("Lütfen sayıları giriniz.");
                }
                else
                { 
                    for (int j = 0; j <yazi.Length; j++)
                    {
                        Button btn = (Button)Panel1.Controls[buton + (j+1) ];
                        btn.Text = yazi[j].ToString();
                        randomListe.Add(yazi[j]);
                    }
                }
            }
            
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string yazi = textBox1.Text;
            string buton = "btn_";
            butonsayıları(e,yazi,buton);
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string yazi = textBox2.Text;
            string buton = "btn_cikis";
            butonsayıları(e, yazi, buton);

            if (e.KeyChar == 13)
            {
                Sondurumdegerleri();
            }

        }

        private void btn_Astar_Click(object sender, EventArgs e)
        {
            try
            {
                baslangıclabel.Text = "";
                textBox_Adimlar.Text = "";
                İlkdurumdegerleri();
                Sondurumdegerleri();
                AstarSezgisel();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }
        private void AstarSezgisel()
        {
          
            Astar = new Astar();
            Astar.degeroku(baslangıclabel);
            List<Astar> Listeacik = new List<Astar>();
            List<int[]> Listekapalı = new List<int[]>();

            if (!TersSıraKontrol(Astar.matrisDegerler, Astar.bitismatris))
            {
                lbl_durum.Text = "Ters sıralı eleman sayısı çift olmalı";
                return;
            }
            else
                lbl_durum.Text = "Liste hazır...";

            Astar.Hdeger();
            Astar.Fdeger();

            Listeacik.Add(Astar);
            Astar minimumYol;

            do
            {
                minimumYol = MinYol(Listeacik);
                Listekapalı.Add(minimumYol.matrisDegerler);
                ListeKuyruğu(minimumYol, Listeacik, Listekapalı);
            } while (minimumYol.h != 0 && Listeacik.Count > 0);

            // sonuç duruma ulaşana kadar
            // veya liste boş olana akdar sürdür
            SonucYaz(minimumYol, textBox_Adimlar, 0);
        }
        private bool SonucYaz(Astar minYol, TextBox txt_problemVarmı, int v)
        {
            if (minYol == null)
            {
                return true;
            }

            SonucYaz(minYol.parent, txt_problemVarmı, v);
            minYol.txtsonucumuz(txt_problemVarmı);
            return false;
        }
        private void ListeKuyruğu(Astar minYol, List<Astar> Listeacik, List<int[]> Listekapalı)
        {
            // boşluk 0 olarak aldık
            int bosluk = Array.IndexOf(minYol.matrisDegerler, 0);
            if ((bosluk % 3) != 2)
            {
                // boşluğun sağda komşusu var mı? varsa;
                Astar cocuk = CocukOlustur(minYol, bosluk, bosluk + 1);
                if (!Yön(cocuk.matrisDegerler, Listekapalı))
                {
                    Listeacik.Add(cocuk);
                }
            }

            if ((bosluk % 3) != 0)
            {
                // boşluğun sol komşusu varsa
                Astar cocuk = CocukOlustur(minYol, bosluk, bosluk - 1);
                if (!Yön(cocuk.matrisDegerler, Listekapalı))
                {
                    Listeacik.Add(cocuk);
                }
            }
            if ((bosluk - 3) >= 0)
            {
                //boşluğun üst kısımda komşusu varsa
                Astar cocuk = CocukOlustur(minYol, bosluk, bosluk - 3);
                if (!Yön(cocuk.matrisDegerler, Listekapalı))
                {
                    Listeacik.Add(cocuk);
                }
            }

            if ((bosluk + 3) < 9)
            {
                //boşluğun alt kısmında komşusu varsa
                Astar cocuk = CocukOlustur(minYol, bosluk, bosluk + 3);
                if (!Yön(cocuk.matrisDegerler, Listekapalı))
                {
                    Listeacik.Add(cocuk);
                }
            }
            Listeacik.Remove(minYol);
        }
        private bool Yön(int[] matrisDegerler, List<int[]> Listekapalı)
        {
            foreach (int[] item in Listekapalı)
            {
                bool Esitlik = true;
                for (int i = 0; i < 9; i++)
                {
                    if (item[i] != matrisDegerler[i])
                    {
                        Esitlik = false;
                    }
                }
                if (Esitlik == true)
                    return true;
            }
            return false;
        }
        private Astar CocukOlustur(Astar minYol, int bosluk, int deger)
        {
            // yeni düğüm ekle/oluştur
            Astar cocuk = new Astar();
            Array.Copy(minYol.matrisDegerler, cocuk.matrisDegerler, minYol.matrisDegerler.Length);

            // başlangıçtan gelinen mesafeyi bul
            cocuk.g = minYol.g + 1;

            DegisimDegerleri(cocuk.matrisDegerler, bosluk, deger);

            cocuk.Hdeger();
            cocuk.Fdeger();
            cocuk.parent = minYol;
            return cocuk;
        }
        private void DegisimDegerleri(int[] dizi, int a, int b)
        {
            int temp = dizi[a];
            dizi[a] = dizi[b];
            dizi[b] = temp;
        }
        private Astar MinYol(List<Astar> Listeacik)
        {
            int min = 0;
            for (int i = 0; i < Listeacik.Count; i++)
            {
                if (Listeacik[i].f < Listeacik[min].f)
                {
                    min = i;
                }
            }
            return Listeacik[min];
        }
        private bool TersSıraKontrol(int[] matrisDegerler, int[] bitismatris)
        {
            int cevrim_kontrol = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 9; j++)
                {
                    for (int k = 0; k < Array.IndexOf(bitismatris, matrisDegerler[i]); k++)
                    {
                        if (bitismatris[k] == matrisDegerler[j] && matrisDegerler[i] != 0 && matrisDegerler[j] != 0)
                            cevrim_kontrol++;
                    }
                }
            }
            if (cevrim_kontrol % 2 == 0)
                return true;

            return false;
        }

        List<int> Listebaslangıc = new List<int>();
        private void İlkdurumdegerleri()
        {
            Listebaslangıc.Clear();
            int a = 0;
            for (int j = 0; j <=8; j++)
            {
                Button btn = (Button)Panel1.Controls["btn_" + (j + 1)];
                a = Convert.ToInt32(btn.Text);
                Listebaslangıc.Add(a);
            }
            baslangıclabel.Text = "";
            int listCount = Listebaslangıc.Count;
            foreach (var item in Listebaslangıc)
            {
                listCount--;
               baslangıclabel.Text += item;
                if (listCount % 3 == 0)
                {
                    baslangıclabel.Text += "\r\n";
                }
            }
        }
        private void Sondurumdegerleri()
        {
            bitislabel.Text = "";
            int a = 0;
            for (int j = 1; j <= 9; j++)
            {
                Button btn = (Button)Panel1.Controls["btn_cikis" + (j)];
                a = Convert.ToInt32(btn.Text);
                bitislabel.Text += a.ToString();
                Astar.bitismatris[(j-1)] = a;
                if (j % 3 == 0)
                {
                    bitislabel.Text += "\n";
                }
            }
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
    }
}
