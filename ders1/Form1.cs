using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string   ara (string no )
        {
            string sonuc = null;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string satir = listBox1.Items[i].ToString();
                string[] str = satir.Split(' ');
                if (no == str[0])
                {
                    sonuc = satir;
                }
                
            }
            return sonuc; 


        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(ara(textBox1.Text));
           
                


        }
    }
}
