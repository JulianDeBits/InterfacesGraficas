using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesGraficas
{
    public partial class Login: Form
    {

        PantallaPrincipal pantalla = new PantallaPrincipal();
        private string dbUsuario = "admin";
        private string dbPassword = "admin";
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text == dbUsuario && txtPassword.Text == dbPassword)
            {
                
                pantalla.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
            
            
        }
    }
}
