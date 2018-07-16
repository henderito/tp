using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominio

{
    public class GrupoIncidente
        {public int Id { get; set; }     
        public String Descripcion { get; set; }
        public int IdTipo { get; set; }

        private bool validarDesc()
        {
            if (Descripcion == null)
            {
                MessageBox.Show("Descripcion incorrecta!!");
                return false;
            }
            if (Descripcion.Trim() == "")
            {
                MessageBox.Show("Descripcion incorrecta!!");
                return false;
            }
            return true;
        }

        public bool validarGrupo()
        {
            if (!validarDesc()) return false;
            return true;
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
