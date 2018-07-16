using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Venta
        {public int IdVenta { get; set; }
         public List<Articulo> ArticulosVendidos { get; set; }
         public Cliente Cli { get; set; }
         public Empleado Ven { get; set; }
         public Interes Int { get; set; }
         public DateTime Fecha { get; set; }
         
         public Venta() { }

         public static Factura generarFactura()
            { return new Factura() { }; }

         private bool validarArticulosVendidos()
            {if (ArticulosVendidos == null) return false;
            foreach (Articulo a in ArticulosVendidos)
                {if (a is null) return false;
                if (!a.validarArticulo()) return false;
            }
             return true;}

        private bool validarFecha()
            {if ((Fecha.Year) > DateTime.Today.Year) return false;
             if (((Fecha.Year) == DateTime.Today.Year) && (Fecha.Month > DateTime.Today.Month)) return false;
             if (((Fecha.Year) == DateTime.Today.Year) && (Fecha.Month == DateTime.Today.Month) && (Fecha.Date > DateTime.Today.Date)) return false;
             return true;}

        public bool validarVenta()
        {
            if (!validarFecha()) { return false; }
          //  if (!validarArticulosVendidos()) { return false; }
            if (!Cli.validarCliente()) { return false; }
            if (!Ven.validarEmpleado()) { return false; }
            if (!Int.validarInteres()) { return false; }
            return true;
        }

        public override string ToString()
        {
            return "Cliente: " + Cli.ToString() + "Vendedor: " + Ven.ToString() + "Fecha de venta: " + Fecha.ToShortDateString();
        }
    }
}
