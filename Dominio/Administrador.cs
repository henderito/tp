using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Administrador : Empleado
        {public List<Empleado> Equipo { get; set; }
        
         public Administrador() { }

        private bool validarEquipo()
            {if (Equipo == null) return false;
             foreach (Empleado aux in Equipo)
                { if (!aux.validarEmpleado()) return false; }
             return true;}

         public bool validarAdministrador()
            {if (!validarEquipo()) return false;
            if (!validarPersona()) return false;
             return true;}
    }
}
