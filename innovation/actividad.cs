using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innovation
{
    class actividad
    {
        public string Path_image { get; }
        public string Nombre { get; set; }
        public int Get_edad_min { get; }
        public bool Get_supervisado { get; }
        public bool Get_mot_fina { get; }
        public bool Mot_gruesa { get; }
        public bool Creativo { get; }
        public bool Manualidad { get; }
        public bool Memoria { get; }
        public int Preparacion { get; }
        public bool Like { get; set; }

        public actividad(int preparacion,string path, string nombre, int edad=1,bool supervisado=true,bool fina=false,bool gruesa = false,bool creativo=false,bool manualidad=false,bool memoria=false,bool like = false)
        {
            this.Preparacion = preparacion;
            this.Path_image = path;
            this.Nombre = nombre;
            this.Get_edad_min = edad;
            this.Get_supervisado = supervisado;
            this.Get_mot_fina = fina;
            this.Mot_gruesa = gruesa;
            this.Creativo = creativo;
            this.Manualidad = manualidad;
            this.Memoria = memoria;
            this.Like = like;
        }
    }
}
