using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominio
{
    public class Articulo
        {public int IdArticulo { get; set; }
         public String Nombre { get; set; }
         public int Precio { get; set; }
         public int Stock { get; set; }
         public int CantVendida { get; set; }

         public Articulo() { CantVendida = 0; }

        public static bool validarPrecio(string p)
            {int x;
            if (!int.TryParse(p, out x))
            {
                MessageBox.Show("Precio incorrecto");
                return false;
            }
            if (x < 0)
            {
                MessageBox.Show("El precio debe ser mayor a 0");
                return false;
            }
            return true;}

        public static bool validarStock(string s)
        {
            int x;
            if (!int.TryParse(s, out x))
            {
                MessageBox.Show("Stock incorrecto");
                return false;
            }
            if (x < 0)
            {
                MessageBox.Show("El stock debe ser mayor a 0");
                return false;
            }
            return true;
        }

        private bool validarCantVendida()
            { if (CantVendida < 0) return false;
            return true;
        }

        private bool validarNombre()
            {if (Nombre == null)
            {
                MessageBox.Show("Nombre incorrecto");
                return false;
            }
            return true;}

         public bool validarArticulo()
            {if (!validarNombre()) return false;
            return true;}

        public override string ToString()
        {
            return Nombre + " $" + Precio.ToString() + " - Stock: " + Stock.ToString();
        }
    }
}
