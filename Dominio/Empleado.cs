using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominio
{
    public class Empleado : Persona
        {public DateTime FechaIngreso { get; set; }
         public int Sueldo { get; set; }
         public List<Venta> Ventas { get; set; }
         public List<Incidencia> Incidentes { get; set; }
         public int Equipo { get; set; }         

         public Empleado() { }

         public override bool validarFechaNac()
            {if ((FechaNac.Year+18)>DateTime.Today.Year)
            {
                MessageBox.Show("El empleado debe ser mayor de 18 años");
                return false;
            }
            if (((FechaNac.Year + 18) == DateTime.Today.Year) && (FechaNac.Month > DateTime.Today.Month))
            {
                MessageBox.Show("El empleado debe ser mayor de 18 años");
                return false;
            }
            if (((FechaNac.Year + 18) == DateTime.Today.Year) && (FechaNac.Month == DateTime.Today.Month) && (FechaNac.Date > DateTime.Today.Date))
            {
                MessageBox.Show("El empleado debe ser mayor de 18 años");
                return false;
            }
            return true;}

        private bool validarFechaIngreso()
            {if ((FechaIngreso.Year) > DateTime.Today.Year)
            {
                MessageBox.Show("Fecha de ingreso incorrecta!!");
                return false;
            }
            if (((FechaIngreso.Year) == DateTime.Today.Year) && (FechaIngreso.Month > DateTime.Today.Month))
            {
                MessageBox.Show("Fecha de ingreso incorrecta!!");
                return false;
            }
            if (((FechaIngreso.Year) == DateTime.Today.Year) && (FechaIngreso.Month == DateTime.Today.Month) && (FechaIngreso.Date > DateTime.Today.Date))
            {
                MessageBox.Show("Fecha de ingreso incorrecta!!");
                return false;
            }
            return true;}

        private bool validarSueldo()
            {if (Sueldo < 0)
            {
                MessageBox.Show("Sueldo incorrecto");
                return false;
            }
            return true;}

        private bool validarVentas()
            {if (Ventas == null) return false;
             foreach (Venta aux in Ventas)
                {if(!aux.validarVenta()) return false; }
             return true;}

        private bool validarIncidentes()
            {if (Incidentes == null) return false;
             foreach (Incidencia aux in Incidentes)
                { if (!aux.validarIncidencia()) return false; }
             return true;}

         public bool validarEmpleado()
            { if (!validarFechaNac()) return false;
            if (!validarFechaIngreso()) return false;
            if (!validarSueldo()) return false;
            //if (!validarVentas()) return false;
            //if (!validarIncidentes()) return false;
            if (!validarPersona()) return false;
            return true;}

        public override string ToString()
        {
            return Nombre + " " + Apellido + " - DNI: " + DNI;
        }
    }
}
