using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonguFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { //1 den 10 a kadar olan sayıları sıralama
            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(i+".sayı");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { //1 den 10 kadar olan sayıların toplamını verir.
            int toplam=0;

            for (int i = 1; i <= 10; i++)
            {
                toplam = toplam + i;

            }
            label1.Text = toplam.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        { //birden 10 a kadar olan çift sayıların toplamını verir
            int toplam=0;
            for (int i = 0; i <= 10; i++)
            {
                if (i%2 ==0)
                {
                    toplam = toplam + i;
                }
            }
            label2.Text = toplam.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {//1 den 100 e kadar olan sayılardan  5 e ve 7 ye tam bölünenler 
            for (int i = 1; i < 100; i++)
            {
                if (i % 5 == 0 && i % 7 ==0) //5 e ve 7 ye tam bölünme şartı
                {
                    listBox2.Items.Add(i);
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= sayi; i++)
            {
                listBox3.Items.Add(i);
            }
        }

        private void Ta_Click(object sender, EventArgs e)
        { //klavyeden girilen sayının tam bölenlerini bulma
            int sayim = Convert.ToInt32(textBox2.Text);
            for (int i = 1; i <=sayim ; i++)
            {
                if (sayim % i ==0)
                {
                    listBox4.Items.Add(i);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        { //faktoriyel hesaplama işlemi 
            int fak=1; 
            int sayii = Convert.ToInt32(textBox3.Text);
            for (int i = sayii; i >0 ; i--)
            {
                fak  =fak * i; 
            }
            listBox5.Items.Add(fak);
        }
    }
    }
