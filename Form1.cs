using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asalKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            int sayi = Convert.ToInt32(textBox1.Text);
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                sayac++;
                break;
                    //girilen sayının asallık kontrolü
                }
            }    
                
            if (sayac == 0)
        	{   
                 label2.Text = "sayi asaldır";
	        }
            else
	        {
                  label2.Text ="sayi asal degildir";
	        }
        }
    }
}

