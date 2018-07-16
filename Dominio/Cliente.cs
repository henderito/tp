using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominio
{
    public class Cliente : Persona
        {public List<Venta> Compras { get; set; }
         public List<Incidencia> Incidentes { get; set; }

        public Cliente() { }

        public override bool validarFechaNac()
            {if ((FechaNac.Year + 10) > DateTime.Today.Year)
            {
                MessageBox.Show("El cliente no puede ser menor de 10 años");
                return false;
            }
            if (((FechaNac.Year + 10) == DateTime.Today.Year) && (FechaNac.Month > DateTime.Today.Month))
            {
                MessageBox.Show("El cliente no puede ser menor de 10 años");
                return false;
            }
            if (((FechaNac.Year + 10) == DateTime.Today.Year) && (FechaNac.Month == DateTime.Today.Month) && (FechaNac.Date > DateTime.Today.Date))
            {
                MessageBox.Show("El cliente no puede ser menor de 10 años");
                return false;
            }
            return true;}

        private bool validarCompras()
            {if (Compras == null) return false;
             foreach (Venta v in Compras)
                { if (!v.validarVenta()) return false; }
             return true;}

        private bool validarIncidentes()
            {if (Incidentes == null) return false;
             foreach (Incidencia aux in Incidentes)
                { if (!aux.validarIncidencia()) return false; }
             return true;}

        public bool validarCliente()
            {if (!validarPersona()) return false;
             if (!validarFechaNac()) return false;
            // if (!validarCompras()) return false;
            // if (!validarIncidentes()) return false;
             return true;}

        public override string ToString()
        {
            return Nombre + " " + Apellido + " - DNI: " + DNI;
        }
    }
}
