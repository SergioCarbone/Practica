using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sergio.Carbone._2C
{
    public class Grupo
    {
        private List<Mascota> manada;
        private string nombre;
        private TipoManada tipo;

        public TipoManada Tipo
        {
            set
            {
                this.tipo = TipoManada.Unica;
            }
        }

        private Grupo()
        {
            manada = new List<Mascota>();
        }

        public Grupo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, TipoManada tipo) : this(nombre)
        {
            this.tipo = tipo;
        }
        
        public static bool operator ==(Grupo grupo, Mascota mascota)
        {
            bool retorno = false;
            foreach (Mascota aux in grupo.manada)
            {
                if(aux == mascota)
                {
                    retorno = true;
                }               
            }
            return retorno;
        }

        public static bool operator !=(Grupo grupo, Mascota mascota)
        {
            bool retorno = false;
            foreach (Mascota aux in grupo.manada)
            {
                if (aux != mascota)
                {
                    retorno = true;
                }                
            }
            return retorno;
        }

        public static Grupo operator +(Grupo grupo, Mascota mascota)
        {
            if(!(grupo == mascota))
            {
                grupo.manada.Add(mascota);
            }
            return grupo;
        }

        public static Grupo operator -(Grupo grupo, Mascota mascota)
        {
            if(grupo == mascota)
            {
                grupo.manada.Remove(mascota);
            }
            return grupo;
        }

        public static implicit operator string(Grupo grupo)
        {
            return grupo.manada.ToString();
        }


        public enum TipoManada
        {
            Unica,
            Mixta,
        }
    }
}
