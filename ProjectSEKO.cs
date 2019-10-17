using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSEKO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        byte basamak;
        string metin;
        List<char> metinler;
        int sayac;

        public void metineAta()
        {
            metin = "";
            foreach (char key in metinler)
            {
                metin += key;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            metinler = new List<char>();
            sayac = 0;
            basamak = 15;
            for (int i = 0; i < basamak; i++)
            {
                metinler.Add('S');
            }
            metineAta();


            do
            {

           
                bool kontrol = uyduMu(metin);
                if (kontrol) { sayac++; }
                    
                
                if (metin[0] == 'B' && metin[1] == 'B' && metin[2] == 'B' && metin[3] == 'B' && metin[4] == 'B' && metin[5] == 'B' && metin[6] == 'B' && metin[7] == 'B' && metin[8] == 'B' && metin[9] == 'B' && metin[10] == 'B' && metin[11] == 'B' && metin[12] == 'B' && metin[13] == 'B' && metin[14] == 'B')
                {
                    break;
                }
                DonguluDegistirme();

            } while (true);
            MessageBox.Show(sayac+"");

        }
        public bool uyduMu(string sami)
        {
            
            bool kontrol = true;
            for (int i = 0; i < sami.Length-1; i++)
            {
                if (sami[i]=='S' && sami[i+1]=='S')
                {
                    kontrol = false;
                    break;
                }
                else if(sami[0] == 'S')
                {
                    kontrol = false;
                    break;
                }
            }
            return kontrol;
        }
        private string DonguluDegistirme()
        {
            string temp = "";
            int artim = 1;
            for (int i = basamak-1; i >=0; i++)
            {
                //ELEMAN KONROLÜ
                etiket:
                if (artim<0)
                {
                    break;
                }
                if (metin[metin.Length - artim] == 'S')
                {
                    metinler[metin.Length - artim] = 'B';
                    metineAta();
                }
                else
                {
                    metinler[metin.Length - artim] = 'S';
                    artim++;
                    goto etiket;
                }
            }

           
            



            return temp;
        }
    }
}
