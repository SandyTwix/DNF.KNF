using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DNF_KNF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string n;
            n = textBox2.Text;
            n = n.perevod(n);
        }
        public string perevod(string temp)
        {
            int temp1 = Convert.ToInt32(temp);
            string temp2 = "";
            while (temp1 > 0)
            {
                temp2 = temp2 + temp1 % 2;
                temp1 = temp1 / 2;
            } 
            return temp2;
        }
    }
}
