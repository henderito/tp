using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Incidencia
        {public int IdIncidencia { get; set; }
         public String Estado { get; set; }  //Abierto, En Analisis, Cerrado
         public Cliente Cli { get; set; }
         public Empleado Ven { get; set; }
         public bool PrioridadAlta { get; set; }   //Alta y Baja
         public TipoIncidencia Tipo { get; set; }
         public GrupoIncidente Grupo { get; set; }
         public SubTipoIncidente SubTipo { get; set; }
         public Venta ventaRelacionada { get; set; }
         public string Descripcion { get; set; }
         public DateTime Fecha { get; set; }

        public Incidencia() { }

        //private void determinarTipo(Articulo art)
          //  { }

        private bool validarEstado()
            {if (Estado == null) return false;
            if (Estado.Trim() == "") return false;
            return true;}

        public bool validarIncidencia()
            { //if (!validarEstado()) return false;
            if (!Cli.validarCliente()) return false;
            if (!Ven.validarEmpleado()) return false;
            if (!Tipo.validarTipoIncidencia()) return false;
            if (!Grupo.validarGrupo()) return false;
            if (!SubTipo.validarSubTipo()) return false;
            if (!(ventaRelacionada is null))
                { if (!ventaRelacionada.validarVenta()) return false; }
            return true;}

        public override string ToString()
        {
            return "Cliente: " + Cli.Nombre + " " + Cli.Apellido + " Empleado: " + Ven.Nombre + " " + Ven.Apellido;
        }
    }
}
