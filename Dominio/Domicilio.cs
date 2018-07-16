using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominio
{
    public class Domicilio
    {
        public String Calle { get; set; }
        public String Departamento { get; set; }
        public String Altura { get; set; }
        public String Piso { get; set; }

        public Domicilio() { }

        public override string ToString()
            {return Calle + " " + Altura + " " + Departamento + " " + Piso;}

        private bool validarCalle()
            {if (Calle == null)
            {
                MessageBox.Show("Calle incorrecta!!");
                return false;
            }
            if (Calle.Trim() == "")
            {
                MessageBox.Show("Calle incorrecta!!");
                return false;
            }
            return true;}

        private bool validarDepartamento()
            {if (Departamento == null) return false;
             return true;}

        private bool validarAltura()
            {if (Altura == null)
            {
                MessageBox.Show("Altura incorrecta!!");
                return false;
            }
            int x = 0;
             if (!int.TryParse(Altura, out x))
            {
                MessageBox.Show("Altura incorrecta!!");
                return false;
            }
            if (x < 0)
            {
                MessageBox.Show("Altura incorrecta!!");
                return false;
            }
            return true;}

        private bool validarPiso()
            {if (Piso == null) return false;
             int x = 0;
             if (!int.TryParse(Piso, out x)) return false;
             if (x < 0) return false;
             return true;}

        public bool validarDomicilio()
            {if(!validarCalle()) return false;
             if (!validarDepartamento()) Departamento="0";
             if (!validarAltura()) return false;
             if (!validarPiso()) Piso="0";
             return true;}
    }
}
