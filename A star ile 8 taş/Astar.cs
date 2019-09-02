using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace A_star_ile_8_taş
{
    class Astar
    {
        public static int[] bitismatris ={ 1, 2, 3, 8, 0, 4, 7, 6, 5 };
            
       
        public int[] matrisDegerler;
        public int g; // Başlangıca olan uzaklığımız
        public int h; // Sonuca olan sezgisel uzaklığımız 
        public int f;
        
        public Astar parent;

        public Astar()
        {
            matrisDegerler = new int[9];
            parent = null;
        }

        public void Fdeger()
        {
            f = g + h;
        }

       
        public void Hdeger()
        {
            h = 0;
            for (int i = 0; i < 9; i++)
            {
                int sonucIndex = Array.IndexOf(bitismatris, matrisDegerler[i]);
                int sutun = Math.Abs((i % 3) - (sonucIndex % 3));
                int satir = Math.Abs((i / 3) - (sonucIndex / 3));
                h += sutun + satir;
            }
        }
        public void degeroku(Label labelyaz)
        {
            string[] deger1 = labelyaz.Text.Replace("\n", " ").Replace("\r", "").Split();
            string[] deger2 = { deger1[0], deger1[1], deger1[2] };
            char[] c = deger2[0].ToArray();
            char[] c2 = deger2[1].ToArray();
            char[] c3 = deger2[2].ToArray();

            for (int i = 0; i < 3; i++)
            {
                matrisDegerler[i] = Int32.Parse(c[i].ToString());
                matrisDegerler[i + 3] = Int32.Parse(c2[i].ToString());
                matrisDegerler[i + 6] = Int32.Parse(c3[i].ToString());
            }
        }

        public void txtsonucumuz(TextBox txt)
        {
            txt.Text += " ********** \r\n";
            for (int i = 0; i < 9; i++)
            {
                if (matrisDegerler[i] == 0)
                {
                    txt.Text += "   ";
                }
                else
                    txt.Text += matrisDegerler[i].ToString() + "";

                if (i % 3 == 2)
                {
                    txt.Text += "\r\n";
                }
            }
        }

    }
    
}

