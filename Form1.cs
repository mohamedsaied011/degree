using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Convert;

namespace degree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblen_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            decimal en = ToDecimal(txten.Text);

            if (en >= 0 && en < 50)
            {
                MessageBox.Show(" انت راسب");
            }
            else if (en >= 50 && en < 60)
            {
                MessageBox.Show("تقديرك مقبول");
            }
            else if (en >= 60 && en < 70)
            {
                MessageBox.Show("تقديرك جيد ");
            }
            else if (en >= 70 && en < 85)
            {
                MessageBox.Show("تقديرك جيد جدا");
            }
            else if (en >= 85 && en == 100)
            {
                MessageBox.Show("تقديرك امتياز");
            }
            else
            {
                MessageBox.Show("انت كداب");
            }

        }
    }
}
