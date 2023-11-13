using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MetotOgren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = metot2(textBox1.Text,textBox2.Text,textBox3.Text);
        }
        public string metot2(string metin,string metin1,string metin2)
        {
            string bilestir=metin + metin1 + metin2;
            string Bbilestir=bilestir.ToUpper();

            return Bbilestir;
 
        }
        //public string metot1(string metin1, string metin2)
        //{
        //    return metin1 + metin2;
 
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string sonuc = metot1(textBox1.Text, textBox2.Text);
        //    textBox3.Text = sonuc;
        //}



        

       
    
}
    

}

 