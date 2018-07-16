using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void validarAcceso(object sender, EventArgs ea)
            {if (validarUsuario())
            { this.Close(); }
            else
                { MessageBox.Show("Datos incorrectos...");
                return;
            }
        }

        private bool validarUsuario()
        {
            string user = txtUser.Text;
            string pw = txtPw.Text;
            if (user.Trim() == "" || pw.Trim() == "") { return false; }
            Users u = new Users();
            try { u = new UsersCon().userByNombre(user); }
            catch {return false;}
            if (u.Pw != pw) {return false;}
            FormControlGeneral.setUser(u);
            return true;
        }
    }
}
