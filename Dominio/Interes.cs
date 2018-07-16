using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominio
{
    public class Interes
         {public int Porcentaje { get; set; }
          public int Id { get; set; }
          public String Nombre { get; set; }

         public Interes() { }

        private bool validarPorcentaje()
            {if (Porcentaje < 0)
            {
                MessageBox.Show("El porcentaje debe ser mayor a 0");
                return false;
            }
            return true;}

        private bool validarNombre()
            {if (Nombre == null)
            {
                MessageBox.Show("Nombre incorrecto!!");
                return false;
            }
            if (Nombre.Trim() == "")
            {
                MessageBox.Show("Nombre incorrecto!!");
                return false;
            }
            return true;}

         public bool validarInteres()
            {if (!validarPorcentaje()) return false;
             if (!validarNombre()) return false;
             return true;}

        public override string ToString()
        {
            return Nombre + " - " + Porcentaje.ToString() + " %";
        }

    }


}
