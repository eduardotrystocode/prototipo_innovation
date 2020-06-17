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
    public partial class Form2 : Form
    {
        public event Action Onload;
        public event Action onclossing;
        public event Action Onfiltrar;
        public event Action Onimage1;
        public event Action Onimage2;
        public event Action Onimage3;
        public event Action Onimage4;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Closing(object sender, CancelEventArgs e)
        {
            onclossing();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Onload();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Onfiltrar();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Onimage1();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Onimage2();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Onimage3();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Onimage4();
        }
    }
}
