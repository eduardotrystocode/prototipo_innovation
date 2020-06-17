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
    public partial class Form1 : Form
    {
        private Form2 pag_ini;
        public Form1(Form2 pag_ini)
        {
            this.pag_ini = pag_ini;
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            pag_ini.ShowDialog();
        }
    }
}
