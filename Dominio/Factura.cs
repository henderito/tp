using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Factura
        {public int Id { get; set; }
        public Cliente Cli { get; set; }
        public Empleado Ven { get; set; }
        public Interes Int { get; set; }
        public DateTime Fecha { get; set; }
        public float Monto { get; set; }

        public Factura() { }

        public void calcularMontoTotal(Interes i, List<KeyValuePair<Articulo, int>> aV)
            {for (int x = 0; x < aV.Count; x++)
                { Monto += (i.Porcentaje * (((Articulo)aV[x].Key).Precio * aV[x].Value)); }}

        private bool validarFecha()
            {if ((Fecha.Year) > DateTime.Today.Year) return false;
             if (((Fecha.Year) == DateTime.Today.Year) && (Fecha.Month > DateTime.Today.Month)) return false;
             if (((Fecha.Year) == DateTime.Today.Year) && (Fecha.Month == DateTime.Today.Month) && (Fecha.Date > DateTime.Today.Date)) return false;
             return true;}

        public bool validarFactura()
            { if (!Cli.validarCliente()) return false;
            if (!Ven.validarEmpleado()) return false;
            if (!Int.validarInteres()) return false;
            if (!validarFecha()) return false;
            return true;}
    }
}
