using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace innovation
{
    public partial class menu_filtro_prep : Form
    {
        public event Action Onselect_prep5;
        public event Action Onselect_prep4;
        public event Action Onselect_prep3;
        public event Action Onselect_prep2;
        public event Action Onselect_prep1;
        public menu_filtro_prep()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Onselect_prep5();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Onselect_prep4();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Onselect_prep3();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Onselect_prep2();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Onselect_prep1();
        }
    }
}
