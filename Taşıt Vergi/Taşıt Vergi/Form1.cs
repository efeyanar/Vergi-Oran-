using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taşıt_Vergi
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double otv = 0;
            double kdv = 0;
            double kdvli = 0;
            double otvli = 0;
            double toplamvergi = 0;
            double anahtarteslim = 0;
            Boolean kontrol = true;
            
            try
            {
                tepe:
                
                double fiyatGir = Convert.ToDouble(textBox1.Text);
                if (fiyatGir < 100000)
                {
                    MessageBox.Show("Araç Fiyatı Uygun Değildir.");
                    
                    textBox1.Clear();
                    
                }
                else {
                    if (comboBox1.Text == "")
                    {
                        textBox1.Clear();
                        MessageBox.Show("Lütfen Bir Araç Türü Seçiniz.");
                        kontrol = false;
                        goto tepe;
                    }
                    else if (comboBox1.Text == "OTOMOBİL")
                    {
                        otv = 0.45;
                        kdv = 0.20;
                        kdvoran.Text = "%20";
                        otvoran.Text = "%45";
                        kontrol = true;
                    }
                    else if (comboBox1.Text == "MOTOSİKLET")
                    {
                        otv = 0.08;
                        kdv = 0.20;
                        kdvoran.Text = "%20";
                        otvoran.Text = "%8";
                        kontrol = true;
                    }
                    else if (comboBox1.Text == "OTOBÜS")
                    {
                        otv = 0.01;
                        kdv = 0.20;
                        kdvoran.Text = "%20";
                        otvoran.Text = "%1";
                        kontrol = true;
                    }
                    else if (comboBox1.Text == "MİDİBÜS")
                    {
                        otv = 0.04;
                        kdv = 0.20;
                        kdvoran.Text = "%20";
                        otvoran.Text = "%4";
                        kontrol = true;
                    }
                    else if (comboBox1.Text == "MİNİBÜS")
                    {
                        otv = 0.09;
                        kdv = 0.20;
                        kdvoran.Text = "%20";
                        otvoran.Text = "%9";
                        kontrol = true;
                    }
                    else if (comboBox1.Text == "HYBRID")
                    {
                        otv = 0.45;
                        kdv = 0.20;
                        kdvoran.Text = "%20";
                        otvoran.Text = "%45";
                        kontrol = true;
                    }
                    else if (comboBox1.Text == "ELEKTRİKLİ")
                    {
                        otv = 0.10;
                        kdv = 0.20;
                        kdvoran.Text = "%20";
                        otvoran.Text = "%10";
                        kontrol = true;
                    }

                    otvli = fiyatGir * otv;
                    kdvli = otvli * kdv;
                    otvfiyat.Text = otvli.ToString();
                    kdvfiyat.Text = kdvli.ToString();
                    toplamvergi = kdvli + otvli;
                    toplamvergifiyat.Text = toplamvergi.ToString();
                    anahtarteslim = toplamvergi + fiyatGir;
                    anahtarfiyat.Text = anahtarteslim.ToString();

                    
                    }

            }
            catch (Exception)
            {
                if (kontrol == true)
                {
                    MessageBox.Show("Bilgileri Doğru Girdiğinizden Emin Olunuz.");
                    textBox1.Clear();
                    
                }
                 
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.ResetText();
            textBox1.Clear();
            otvoran.Text = "___";
            kdvoran.Text="___";
            kdvfiyat.Text="___";
            otvfiyat.Text="___";
            anahtarfiyat.Text="___";
            toplamvergifiyat.Text="___";
        }
    }
}
