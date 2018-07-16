using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominio
{
    public class TipoIncidencia
        {public int IdTipo { get; set; }
         public String Descripcion { get; set; }

        public TipoIncidencia() { }

        private bool validarDescripcion()
            {if (Descripcion == null)
            {
                MessageBox.Show("Nombre incorrecto!!");
                return false;
            }
            if (Descripcion.Trim() == "")
            {
                MessageBox.Show("Nombre incorrecto!!");
                return false;
            }
            return true;}

        public bool validarTipoIncidencia()
            {if (!validarDescripcion()) return false;
             return true;}

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
