using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Equipo
        {
        public int id { get; set; }
        public String Nombre { get; set; }
        //public Administrador Admin { get; set; }
       
        private bool validarNombre()
            {if (Nombre == null) return false;
            if (Nombre.Trim() == "") return false;
            return true;}

        public bool validarEquipo()
            { if (!validarNombre()) return false;
            //if (!Admin.validarAdministrador()) return false;
            return true;}

        public override string ToString()
        {
            return Nombre;
        }
    }
}
