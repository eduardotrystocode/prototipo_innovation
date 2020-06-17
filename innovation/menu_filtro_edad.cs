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
    public partial class menu_filtro_edad : Form
    {
        public event Action Onelegiredad1;
        public event Action Onelegiredad2;
        public event Action Onelegiredad3;
        public event Action Onelegiredad4;
        public event Action Onelegiredad5;

        public menu_filtro_edad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Onelegiredad1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Onelegiredad2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Onelegiredad3();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Onelegiredad4();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Onelegiredad5();
        }
    }
}
