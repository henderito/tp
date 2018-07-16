using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominio
{
    public abstract class Persona
        {public String Nombre { get; set; }
         public String Apellido { get; set; }
         public String DNI { get; set; }
         public String Telefono { get; set; }
         public String Mail { get; set; }
         public DateTime FechaNac { get; set; }
         public String Sexo { get; set; }
         public Domicilio Dom { get; set; }

         public abstract bool validarFechaNac();

        private bool validarTelefono()
            {int x;
             if (!int.TryParse(Telefono, out x))
            {
                MessageBox.Show("Telefono incorrecto");
                return false;
            }
            if ((Telefono.ToString().Count() == 8) && (x >= 40000000 && x < 50000000)) {return true;}
            if ((Telefono.ToString().Count() == 10) && (x >= 1500000000 && x < 1600000000)) {return true;}
            MessageBox.Show("Telefono incorrecto");
            return false;
        }

        private bool validarMail()
            {if (!(Mail.Contains("@") && ((Mail.ToLower().EndsWith(".com") || (Mail.ToLower().EndsWith(".com.ar"))))))
                {MessageBox.Show("Mail incorrecto");
                return false; }
             return true;}

        private bool validarDNI()
            {int x;
             if (!int.TryParse(DNI, out x))
            {
                MessageBox.Show("DNI incorrecto");
                return false;
            }
            if ((x < 999999) || (x > 99999999))
            {
                MessageBox.Show("DNI incorrecto");
                return false;
            }
            return true;}

        private bool validarSexo()
            { if (Sexo == null)
            {
                MessageBox.Show("Sexo incorrecto");
                return false;
            }
            if (!(Sexo.Equals("M") || Sexo.Equals("F")))
            {
                MessageBox.Show("Sexo incorrecto");
                return false;
            }
            return true; }

        private bool validarNombre()
            {if (Nombre == null)
            {
                MessageBox.Show("Nombre incorrecto");
                return false;
            }
            if (Nombre.Trim() == "")
            {
                MessageBox.Show("Nombre incorrecto");
                return false;
            }
            int x;
            if (int.TryParse(Nombre, out x))
            {
                MessageBox.Show("Nombre incorrecto");
                return false;
            }
            return true;}

        private bool validarApellido()
            {if (Apellido == null)
            {
                MessageBox.Show("Apellido incorrecto");
                return false;
            }
            if (Apellido.Trim() == "")
            {
                MessageBox.Show("Apellido incorrecto");
                return false;
            }
            int x;
            if (int.TryParse(Apellido, out x))
            {
                MessageBox.Show("Apellido incorrecto");
                return false;
            }
            return true;}

        public bool validarPersona()
            { if (!validarTelefono()) return false;
            if (!validarMail()) return false;
            if (!validarDNI()) return false;
            if (!validarNombre()) return false;
            if (!validarApellido()) return false;
            if (!Dom.validarDomicilio()) return false;
            return true;}
    }
}
