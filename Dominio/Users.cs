using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Users
    {public string Nombre { get; set; }
        public string Pw { get; set; }
        public string DNI { get; set; }
        //Del 1 al 3, siendo 1 el mínimo
        public int Acceso { get; set; }
    }
}
