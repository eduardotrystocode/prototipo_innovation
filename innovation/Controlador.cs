using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
APLICACION DE WINDOWS FORM, PROTOTIPO PARA DEMOSTRAR PRINCIPALES FUNCIONALIDADES
PATRON DE DISENO MVC
POR SIMPLICIDAD NO SE HA PASADO A UN COMPILADO PERO SI FUERA A USARSE EN TESTEOS REALES
SE SALTARIA ESTA PANTALLA
*/
namespace innovation
{
    class Controlador
    {
        private Form1 f1;
        private Form2 f2;
        private Form3 f3;
        private menu_filtro1 mf1;
        private menu_filtro_edad mfe;
        private menu_filtro_categ mfc;
        private menu_filtro_prep mfp;
        private modelo m;


        private string nombreimagenform3;

        public Controlador(Form2 f2,Form1 f1,modelo m)
        {
            this.f2 = f2;
            this.f1 = f1;
            this.m = m;

            f2.Onload += Load;
            f2.onclossing += clossing;
            f2.Onfiltrar += filtrar1;
            f2.Onimage1 += Imagen1;
            f2.Onimage2 += Imagen2;
            f2.Onimage3 += Imagen3;
            f2.Onimage4 += Imagen4;
            
        }




        public void filtrar1()
        {
            f2.Hide();
            mf1 = new menu_filtro1();
            mf1.Onfiltrar_edad += filtrar_edad;
            mf1.Onfiltrar_categ += filtrar_categ;
            mf1.Onfiltrar_crap69 += filtrar_prep;
            mf1.Onaplicarfiltros += aplicarfiltros;
           

            /*
            cosas
            */

            mf1.ShowDialog();    
        }

        public void aplicarfiltros()
        {
            mf1.Hide();
            f2.Show();

            List<actividad> newselected = m.filtrarprro();
            if (newselected.Count == 0)
            {
                MessageBox.Show("no se han encontrado resultados, prueba con menos filtros");   
            }
            else if (newselected.Count == 1)
            {
                string path = newselected[0].Path_image + "\\" + newselected[0].Nombre + ".png";
                f2.pictureBox2.Image = Image.FromFile(path);
                f2.pictureBox3.Image = null;
                f2.pictureBox4.Image = null;
                f2.pictureBox5.Image = null;
            }
            else if (newselected.Count == 2)
            {
                string path = newselected[0].Path_image + "\\" + newselected[0].Nombre + ".png";
                f2.pictureBox2.Image = Image.FromFile(path);
                path = newselected[1].Path_image + "\\" + newselected[1].Nombre + ".png";
                f2.pictureBox3.Image = Image.FromFile(path);
                f2.pictureBox4.Image = null;
                f2.pictureBox5.Image = null;
            }
            else if (newselected.Count == 3)
            {
                string path = newselected[0].Path_image + "\\" + newselected[0].Nombre + ".png";
                f2.pictureBox2.Image = Image.FromFile(path);
                path = newselected[1].Path_image + "\\" + newselected[1].Nombre + ".png";
                f2.pictureBox3.Image = Image.FromFile(path);
                path = newselected[2].Path_image + "\\" + newselected[2].Nombre + ".png";
                f2.pictureBox4.Image = Image.FromFile(path);
                f2.pictureBox5.Image = null;
            }
            else
            {
                string path = newselected[0].Path_image + "\\" + newselected[0].Nombre + ".png";
                f2.pictureBox2.Image = Image.FromFile(path);
                path = newselected[1].Path_image + "\\" + newselected[1].Nombre + ".png";
                f2.pictureBox3.Image = Image.FromFile(path);
                path = newselected[2].Path_image + "\\" + newselected[2].Nombre + ".png";
                f2.pictureBox4.Image = Image.FromFile(path);
                path = newselected[3].Path_image + "\\" + newselected[3].Nombre + ".png";
                f2.pictureBox5.Image = Image.FromFile(path);
            }
        }



        public void filtrar_prep()
        {
            mf1.Hide();
            mfp = new menu_filtro_prep();
            mfp.Onselect_prep5 += select_prep5;
            mfp.Onselect_prep4 += select_prep4;
            mfp.Onselect_prep3 += select_prep3;
            mfp.Onselect_prep2 += select_prep2;
            mfp.Onselect_prep1 += select_prep1;




            mfp.ShowDialog();
        }

        #region eventos select prep
        public void select_prep5()
        {
            mfp.Hide();
            m.prep = 5;
            mf1.Show();
        }
        public void select_prep4()
        {
            mfp.Hide();
            m.prep = 4;
            mf1.Show();
        }
        public void select_prep3()
        {
            mfp.Hide();
            m.prep = 3;
            mf1.Show();
        }
        public void select_prep2()
        {
            mfp.Hide();
            m.prep = 2;
            mf1.Show();
        }
        public void select_prep1()
        {
            mfp.Hide();
            m.prep = 1;
            mf1.Show();
        }
        #endregion





        public void categelegidas()
        {
            m.supervisado = mfc.checkBox1.Checked;
            m.mot_fina = mfc.checkBox2.Checked;
            m.mot_gruesa = mfc.checkBox3.Checked;
            m.creativo = mfc.checkBox4.Checked;
            m.manualidad = mfc.checkBox5.Checked;
            m.memoria = mfc.checkBox6.Checked;

            mfc.Hide();
            mf1.Show();
        }

        public void filtrar_categ()
        {
            mf1.Hide();
            mfc = new menu_filtro_categ();
            mfc.Oncategelegidas += categelegidas;


            mfc.ShowDialog();
        }






        #region eventos filtroedad

        public void elegiredad1()
        {
            m.edad = 1;

            mfe.Hide();
            mf1.Show();
        }

        public void elegiredad2()
        {
            m.edad = 2;

            mfe.Hide();
            mf1.Show();
        }

        public void elegiredad3()
        {
            m.edad = 3;

            
            mf1.Show();
            mfe.Hide();
        }

        public void elegiredad4()
        {
            m.edad = 4;

            mfe.Hide();
            mf1.Show();
        }

        public void elegiredad5()
        {
            m.edad = 5;

            mfe.Hide();
            mf1.Show();
        }

        #endregion

        public void filtrar_edad()
        {
            mf1.Hide();
            mfe = new menu_filtro_edad();
            mfe.Onelegiredad1 += elegiredad1;
            mfe.Onelegiredad2 += elegiredad2;
            mfe.Onelegiredad3 += elegiredad3;
            mfe.Onelegiredad4 += elegiredad4;
            mfe.Onelegiredad5 += elegiredad5;
            


            mfe.ShowDialog();
        }





        public void like()
        {
            m.like(nombreimagenform3);
        }

        public void clossing()
        {
            f1.Close();
        }

        public void pictureclick()
        {
            f2.Show();
        }

        public void Imagen1()
        {
            f2.Hide();
            f3 = new Form3();
            f3.Onpictureclick += pictureclick;
            f3.Onlike += like;

            f3.checkBox1.Checked = false;

            string path = m.selected[0].Path_image + "\\" + m.selected[0].Nombre + ".png";
            f3.pictureBox1.Image = Image.FromFile(path);
            string tags = "";
            if (m.selected[0].Get_supervisado) { tags += "   con supervision"; }
            if (m.selected[0].Get_mot_fina) { tags += "   motricidad fina"; }
            if (m.selected[0].Mot_gruesa) { tags += "   motricidad gruesa"; }
            if (m.selected[0].Creativo) { tags += "   creativo"; }
            if (m.selected[0].Manualidad) { tags += "   manualidades"; }
            if (m.selected[0].Memoria) { tags += "   memoria"; }
            f3.textBox2.Text = tags;
            string prep = "";
            for (int i = 0; i < m.selected[0].Preparacion; i++)
            {
                prep += "♦";
            }
            if (m.selected[0].Like) { f3.checkBox1.Checked = true; }

            if (m.filtrado)
            {
                if (m.newselected.Count > 0)
                {
                    nombreimagenform3 = m.newselected[0].Nombre;
                }
            }
            else
            {
                nombreimagenform3 = m.selected[0].Nombre;
            }
            

            f3.textBox4.Text = prep;
            f3.ShowDialog();

        }

        public void Imagen2()
        {
            f2.Hide();
            Form3 form3 = new Form3();
            form3.Onpictureclick += pictureclick;
            form3.Onlike += like;

            form3.checkBox1.Checked = false;

            string path = m.selected[1].Path_image + "\\" + m.selected[1].Nombre + ".png";
            form3.pictureBox1.Image = Image.FromFile(path);
            string tags = "";
            if (!(m.selected[1].Get_supervisado)) { tags += "   sin supervision"; }
            if (m.selected[1].Get_mot_fina) { tags += "   motricidad fina"; }
            if (m.selected[1].Mot_gruesa) { tags += "   motricidad gruesa"; }
            if (m.selected[1].Creativo) { tags += "   creativo"; }
            if (m.selected[1].Manualidad) { tags += "   manualidades"; }
            if (m.selected[1].Memoria) { tags += "   memoria"; }
            form3.textBox2.Text = tags;
            string prep = "";
            for (int i = 0; i < m.selected[1].Preparacion; i++)
            {
                prep += "♦";
            }
            if (m.selected[1].Like) { form3.checkBox1.Checked = true; }

            if (m.filtrado)
            {
                if (m.newselected.Count > 1)
                {
                    nombreimagenform3 = m.newselected[1].Nombre;
                }
            }
            else
            {
                nombreimagenform3 = m.selected[1].Nombre;
            }

            form3.textBox4.Text = prep;
            form3.ShowDialog();

        }

        public void Imagen3()
        {
            f2.Hide();
            Form3 form3 = new Form3();
            form3.Onpictureclick += pictureclick;
            form3.Onlike += like;

            form3.checkBox1.Checked = false;

            string path = m.selected[2].Path_image + "\\" + m.selected[2].Nombre + ".png";
            form3.pictureBox1.Image = Image.FromFile(path);
            string tags = "";
            if (!(m.selected[2].Get_supervisado)) { tags += "   sin supervision"; }
            if (m.selected[2].Get_mot_fina) { tags += "   motricidad fina"; }
            if (m.selected[2].Mot_gruesa) { tags += "   motricidad gruesa"; }
            if (m.selected[2].Creativo) { tags += "   creativo"; }
            if (m.selected[2].Manualidad) { tags += "   manualidades"; }
            if (m.selected[2].Memoria) { tags += "   memoria"; }
            form3.textBox2.Text = tags;
            string prep = "";
            for (int i = 0; i < m.selected[2].Preparacion; i++)
            {
                prep += "♦";
            }
            if (m.selected[2].Like) { form3.checkBox1.Checked = true; }

            if (m.filtrado)
            {
                if (m.newselected.Count > 2)
                {
                    nombreimagenform3 = m.newselected[2].Nombre;
                }
            }
            else
            {
                nombreimagenform3 = m.selected[2].Nombre;
            }

            form3.textBox4.Text = prep;
            form3.ShowDialog();

        }

        public void Imagen4()
        {
            f2.Hide();
            Form3 form3 = new Form3();
            form3.Onpictureclick += pictureclick;
            form3.Onlike += like;

            form3.checkBox1.Checked = false;

            string path = m.selected[3].Path_image + "\\" + m.selected[3].Nombre + ".png";
            form3.pictureBox1.Image = Image.FromFile(path);

            string tags="";
            if (!(m.selected[3].Get_supervisado)) { tags += "   sin supervision"; }
            if (m.selected[3].Get_mot_fina) { tags += "   motricidad fina"; }
            if (m.selected[3].Mot_gruesa) { tags += "   motricidad gruesa"; }
            if (m.selected[3].Creativo) { tags += "   creativo"; }
            if (m.selected[3].Manualidad) { tags += "   manualidades"; }
            if (m.selected[3].Memoria) { tags += "   memoria"; }
            form3.textBox2.Text = tags;
            string prep = "";
            for (int i = 0; i < m.selected[3].Preparacion; i++)
            {
                prep += "♦";
            }
            if (m.selected[3].Like) { form3.checkBox1.Checked = true; }

            if (m.filtrado)
            {
                if (m.newselected.Count > 3)
                {
                    nombreimagenform3 = m.newselected[3].Nombre;
                }
            }
            else
            {
                nombreimagenform3 = m.selected[3].Nombre;
            }

            form3.textBox4.Text = prep; 
            form3.ShowDialog();


        }



        public void Load()
        {
            List<actividad> selected = m.Load();
            string path = selected[0].Path_image + "\\" + selected[0].Nombre+".png";
            f2.pictureBox2.Image = Image.FromFile(path);
            path = selected[1].Path_image + "\\" + selected[1].Nombre + ".png";
            f2.pictureBox3.Image = Image.FromFile(path);
            path = selected[2].Path_image + "\\" + selected[2].Nombre + ".png";
            f2.pictureBox4.Image = Image.FromFile(path);
            path = selected[3].Path_image + "\\" + selected[3].Nombre + ".png";
            f2.pictureBox5.Image = Image.FromFile(path);
        }

    }
}
