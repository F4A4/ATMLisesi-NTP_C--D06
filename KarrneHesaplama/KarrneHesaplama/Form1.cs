using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KarrneHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
        
            //NESNE TABANI DERSİNİN ORTALAMA HESAPLAMASI


            try
            {
                int a = Int32.Parse(textBox1.Text);
                int b = Int32.Parse(textBox2.Text);
                int c = Int32.Parse(textBox3.Text);
                textBox4.Text = ((a + b + c) / 3).ToString();
 
            }
            catch (Exception)
            {

                MessageBox.Show("yanlış giriş tekrar giriş yapınız..");
            }
            
            //VERİ TABANI DERSİNİN ORTALAMA HESAPLAMASI
               
             try
            {
               int d = Int32.Parse(textBox5.Text);
               int x = Int32.Parse(textBox6.Text);
               int f = Int32.Parse(textBox7.Text);
               textBox8.Text = ((d + x + f) / 3).ToString();
                
            }
            catch (Exception)
            {

                MessageBox.Show("yanlış giriş tekrar giriş yapınız..");
            }
            
            //MATEMATİK DERSİNİN ORTALAMA HESAPLAMASI

           
            try
            { 
                int g = Int32.Parse(textBox9.Text);
                int ğ = Int32.Parse(textBox10.Text);
                int h = Int32.Parse(textBox11.Text);
                textBox12.Text = ((g + ğ + h) / 3).ToString();
               
            }
            catch (Exception)
            {

                MessageBox.Show("yanlış giriş tekrar giriş yapınız..");
            }
            //GEOMETRİ DERSİNİN ORTALAMA HESAPLAMASI

            
            try
            {
                int ı = Int32.Parse(textBox13.Text);
                int i = Int32.Parse(textBox14.Text);
                int j = Int32.Parse(textBox15.Text);
                textBox16.Text = ((ı + i + j) / 3).ToString();
                
            }
            catch (Exception)
            {

                MessageBox.Show("yanlış giriş tekrar giriş yapınız..");
            }
            //KİMYA DERSİNİN ORTALAMA HESAPLAMASI

            
            try
            {
                int k = Int32.Parse(textBox17.Text);
                int l = Int32.Parse(textBox18.Text);
                int m = Int32.Parse(textBox19.Text);
                textBox20.Text = ((k + l + m) / 3).ToString();
                
            }
            catch (Exception)
            {

                MessageBox.Show("yanlış giriş tekrar giriş yapınız..");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int m = Int32.Parse(textBox4.Text);
                int n = Int32.Parse(textBox8.Text);
                int o = Int32.Parse(textBox12.Text);
                int ö = Int32.Parse(textBox16.Text);
                int p = Int32.Parse(textBox20.Text);
                textBox21.Text = ((m + n + o + ö + p) / 5).ToString();
                int sayi = Int32.Parse(textBox21.Text);

                if (sayi > 0 && sayi < 25)
                {
                    textBox21.Text = sayi + "(0)";
                }
                if (sayi > 25 && sayi < 45)
                {
                    textBox21.Text = sayi + "(1)";
                }
                if (sayi > 45 && sayi < 55)
                {
                    textBox21.Text = sayi + "(2)";
                }
                if (sayi > 55 && sayi < 70)
                {
                    textBox21.Text = sayi + "(3)";
                }
                if (sayi > 70 && sayi < 85)
                {
                    textBox21.Text = sayi + "(4)";
                }
                if (sayi > 85 && sayi < 100)
                {
                    textBox21.Text = sayi + "(5)";
                }

            }
            catch (Exception)
            {

                MessageBox.Show("BEN ORTALAMAYA BAĞLIYIM ONU TAMAMLA ÖYLE");
            }
            finally
            {
                MessageBox.Show("----GÜLE GÜLE----");
            }
           
          
           
        }

        

    }
}
