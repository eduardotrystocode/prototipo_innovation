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
    public partial class menu_filtro1 : Form
    {
        public event Action Onfiltrar_edad;
        public event Action Onfiltrar_categ;
        public event Action Onfiltrar_crap69;
        public event Action Onaplicarfiltros;

        public menu_filtro1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Onfiltrar_crap69();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Onfiltrar_edad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Onfiltrar_categ();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Onaplicarfiltros();
        }
    }
}
