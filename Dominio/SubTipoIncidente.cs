using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominio
{
    public class SubTipoIncidente
        {public int Id { get; set; }
        public String Descripcion { get; set; }
        public int IdGrupo { get; set; }

        private bool validarDesc(String n)
            { if (n == null)
            {
                MessageBox.Show("Nombre incorrecto!!");
                return false;
            }
            if (n.Trim() == "")
            {
                MessageBox.Show("Nombre incorrecto!!");
                return false;
            }
            return true;}

        public bool validarSubTipo()
            { if (!validarDesc(Descripcion)) return false;
            return true;
        }

        public override string ToString()
        {
            return Descripcion;
        }

    }
}
