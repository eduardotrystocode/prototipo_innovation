using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innovation
{
    class modelo
    {

        public Dictionary<int, actividad> db;
        private static string assets_path = "C:\\Users\\jesal\\Documents\\codigos\\innovation\\assets";
        int imagesondisplay = 4;
        Random random = new Random();
        public List<actividad> selected = new List<actividad>(); //actividades mostradas en el form2
        
        public int edad { get; set; }
        public int prep { get; set; }

        public bool supervisado { get; set; }
        public bool mot_fina { get; set; }
        public bool mot_gruesa { get; set; }
        public bool creativo { get; set; }
        public bool manualidad { get; set; }
        public bool memoria { get; set; }

        public bool filtrado = false;
        public List<actividad> newselected;
        private enum nombres
        {
            aviones_confort = 0,
            carrera_diferente = 1,
            club_secreto = 2,
            cuenta_cuentos=3,
            cuncuna=4,
            emboque_casero=5,
            laberinto_lana=6,
            plasticina_casera=7,
            sensory_box=8,
            tiro_al_blanco=9
        }
        
        public modelo()
        /** el constructor del modelo se encarga de la conexion con la base de datos */
        // notar que al ser un mero prototipo por motivos de simplisidad se creo rapidamente un diccionario con 10 ejemplos internamente.
        {
            edad = 5;
            prep = 5;
            supervisado = false;
            mot_fina = false;
            mot_gruesa = false;
            creativo = false;
            manualidad = false;
            memoria = false;

            actividad aviones_confort = new actividad(2,assets_path, "aviones_confort", 2, true, true, false, true, true, false);
            actividad carrera_diferente = new actividad(4,assets_path, "carrera_diferente", 3, false, false, true);
            actividad club_secreto = new actividad(2,assets_path, "club_secreto", 3, false, false, true, true);

            actividad cuenta_cuentos = new actividad(1,assets_path, "cuenta_cuentos", 2, true, false, false, true, false, true);
            actividad cuncuna = new actividad(2,assets_path, "cuncuna", 2, true, true, false, true, true);
            actividad emboque_casero = new actividad(1,assets_path, "emboque_casero", 1, true, true, false, true, true, false);

            actividad laberinto_lana = new actividad(2,assets_path, "laberinto_lana", 2, false, false, true);
            actividad plasticina_casera = new actividad(2,assets_path, "plasticina_casera", 1, true, true, false, true, true);
            actividad sensory_box = new actividad(3,assets_path, "sensory_box", 2, true, false, false, true, false, true);

            actividad tiro_al_blanco = new actividad(3,assets_path, "tiro_al_blanco", 2, false, true);

            db = new Dictionary<int, actividad>();
            db.Add(0,aviones_confort);db.Add(1,carrera_diferente);db.Add(2,club_secreto);
            db.Add(3,cuenta_cuentos);db.Add(4,cuncuna);db.Add(5,emboque_casero);
            db.Add(6,laberinto_lana);db.Add(7,plasticina_casera);db.Add(8, sensory_box);
            db.Add(9,tiro_al_blanco);

        }

        public void like(string i)
        {
            foreach(actividad a in selected)
            {
                if(a.Nombre==i)
                {
                    a.Like = !(a.Like);
                    break;
                }
            }
        }

        public List<actividad> Load()
        {           
            List<int> usado = new List<int>();
            int act = -1;
            for (int i = 0; i < imagesondisplay; i++)
            {
                act = random.Next(db.Count());
                if(!(usado.Contains(act)))
                {
                    selected.Add(db[act]);
                    usado.Add(act);
                }
                else
                {
                    --i;
                }
            }

            return selected;
        }

        public List<actividad> filtrarprro()
        {
            newselected = new List<actividad>(selected);
            selected.Clear();
            foreach (actividad a in db.Values)
            {
                bool participa = true;

                #region condiciones filtrado
                if (!supervisado)
                {
                    if (a.Get_supervisado)
                    {
                        participa = false;
                    }
                }
                if (mot_fina)
                {
                    if (!a.Get_mot_fina)
                    {
                        participa = false;
                    }
                }
                if (mot_gruesa)
                {
                    if (!a.Mot_gruesa)
                    {
                        participa = false;
                    }
                }
                if (creativo)
                {
                    if (!a.Creativo)
                    {
                        participa = false;
                    }
                }
                if (manualidad)
                {
                    if (!a.Manualidad)
                    {
                        participa = false;
                    }
                }
                if (memoria)
                {
                    if (!a.Memoria)
                    {
                        participa = false;
                    }
                }
                if (edad < a.Get_edad_min)
                {
                    participa = false;
                }
                if (prep < a.Preparacion)
                {
                    participa = false;
                }
                #endregion


                if (participa)
                {
                    selected.Add(a);
                }
                if (selected.Count > 0) { filtrado = true; }
                else{ selected = newselected.ToList(); }
            }
            return selected;
        }
    }
}
