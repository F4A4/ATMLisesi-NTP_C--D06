using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Odev_3
{
    public partial class Ortalama_Tablosu : Form
    {
        public Ortalama_Tablosu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Hesaplama_Bır_Click(object sender, EventArgs e)
        {
            try
            {
                int yazılı1 = Int32.Parse(textBox1.Text);
                int yazılı2 = Int32.Parse(textBox6.Text);
                int yazılı3 = Int32.Parse(textBox11.Text);
                int sozlu1 = Int32.Parse(textBox16.Text);
                int sozlu2 = Int32.Parse(textBox21.Text);

                textBox27.Text = ((yazılı1 + yazılı2 + yazılı3 + sozlu1 + sozlu2) / 5).ToString();
            }
            catch (Exception hata1)
            {
                MessageBox.Show("HATALI  İŞLEM ");
                MessageBox.Show(hata1.Message);
                
            }
 
            //finally
            //{
            //    MessageBox.Show("YANLIŞ BİR DEĞER GİRDİNİZ =(");   
            //}
                   
        }

        private void Hesaplama_Ikı_Click(object sender, EventArgs e)
        {
            try
            { 
               int yazılı1 = Int32.Parse(textBox2.Text);
               int yazılı2 = Int32.Parse(textBox7.Text);
               int yazılı3 = Int32.Parse(textBox12.Text);
               int sozlu1 = Int32.Parse(textBox17.Text);
               int sozlu2 = Int32.Parse(textBox22.Text);

               textBox28.Text = ((yazılı1 + yazılı2 + yazılı3 + sozlu1 + sozlu2) / 5).ToString();
            }
            catch (Exception hata1)
            {
                MessageBox.Show("HATALI İŞLEM ");
                MessageBox.Show(hata1.Message);
               
            }

            //finally
            //{
            //    MessageBox.Show("YANLIŞ BİR DEĞER GİRDİNİZ =(");
            //}
                     
        }

        private void Hesaplama_uc_Click(object sender, EventArgs e)
        {
            try
            { 
            int yazılı1 = Int32.Parse(textBox3.Text);
            int yazılı2 = Int32.Parse(textBox8.Text);
            int yazılı3 = Int32.Parse(textBox13.Text);
            int sozlu1 = Int32.Parse(textBox18.Text);
            int sozlu2 = Int32.Parse(textBox23.Text);

            textBox29.Text = ((yazılı1 + yazılı2 + yazılı3 + sozlu1 + sozlu2) / 5).ToString();
            }
            catch (Exception hata1)
            {
                MessageBox.Show("HATALI İŞLEM ");
                MessageBox.Show(hata1.Message);
               
            }
            //finally
            //{
            //    MessageBox.Show("YANLIŞ BİR DEĞER GİRDİNİZ =(");
            //}
               
        }

        private void Hesaplama_Dort_Click(object sender, EventArgs e)
        {
            try
            {
            int yazılı1 = Int32.Parse(textBox4.Text);
            int yazılı2 = Int32.Parse(textBox9.Text);
            int yazılı3 = Int32.Parse(textBox14.Text);
            int sozlu1 = Int32.Parse(textBox19.Text);
            int sozlu2 = Int32.Parse(textBox24.Text);

            textBox30.Text = ((yazılı1 + yazılı2 + yazılı3 + sozlu1 + sozlu2) / 5).ToString();
       
            }
            catch (Exception hata1)
            {
                MessageBox.Show("HATALI İŞLEM ");
                MessageBox.Show(hata1.Message);
                
            }
            //finally
            //{
            //    MessageBox.Show("YANLIŞ BİR DEĞER GİRDİNİZ =(");
            //}
        }

        private void Hesaplama_Bes_Click(object sender, EventArgs e)
        {
            try
            { 
            int yazılı1 = Int32.Parse(textBox5.Text);
            int yazılı2 = Int32.Parse(textBox10.Text);
            int yazılı3 = Int32.Parse(textBox15.Text);
            int sozlu1 = Int32.Parse(textBox20.Text);
            int sozlu2 = Int32.Parse(textBox25.Text);

            textBox31.Text = ((yazılı1 + yazılı2 + yazılı3 + sozlu1 + sozlu2) / 5).ToString(); 
            }
            catch (Exception hata1)
            {
                MessageBox.Show("HATALI İŞLEM ");
                MessageBox.Show(hata1.Message);
                
            }
        //    finally
        //    {
        //        MessageBox.Show("GÜLE GÜLE=)");
        //    }
        }

        private void Ortalama_Hesaplama_Click(object sender, EventArgs e)
        {

            try
            { 
            int ort1 = Int32.Parse(textBox27.Text);
            int ort2 = Int32.Parse(textBox28.Text);
            int ort3 = Int32.Parse(textBox29.Text);
            int ort4 = Int32.Parse(textBox30.Text);
            int ort5 = Int32.Parse(textBox31.Text);         
           
            int ortsonuc;
            textBox26.Text=((ort1 + ort2 + ort3 + ort4 + ort5) / 5).ToString();
            ortsonuc = Int32.Parse(textBox26.Text);
          
            if ((ortsonuc >= 0) && (ortsonuc <=24))
            {
                textBox26.Text =ortsonuc + "(0)";
            }
            else if ((ortsonuc >= 25) && (ortsonuc <=44))
            {
                textBox26.Text = ortsonuc + "(1)";
            }
            else if ((ortsonuc >= 45) && (ortsonuc <=54))
            {
                textBox26.Text = ortsonuc + "(2)";
            }
            else if ((ortsonuc >= 55) && (ortsonuc <=69))
            {
                textBox26.Text = ortsonuc + "(3)";
            }
            else if ((ortsonuc >= 70) && (ortsonuc <=84))
            {
                textBox26.Text = ortsonuc + "(4)";
            }
            else if ((ortsonuc >= 85) && (ortsonuc <=100))
            {
                textBox26.Text = ortsonuc + "(5)";
            }

            }
            catch (Exception hata1)
            {
                MessageBox.Show("HATALI İŞLEM ");
                MessageBox.Show(hata1.Message);
                
            }
            finally
            {
                MessageBox.Show(" İYİ  DERSLER  =)");
            }
            
	         
	         
	         
	         
		 
	         
            
            
         


        }

        

        
    }
}
