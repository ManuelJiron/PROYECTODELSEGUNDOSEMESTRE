using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inicio_de_sesion
{
    public partial class s : Form
    {
        public s()
        {
            InitializeComponent();
        }

        private const string Usuario = "IsaacMora";
        private const string Contraseña = "198813";
        Form2 Principal = new Form2();
        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            
            string usuarioIngresado = txtUsuario.Text;
            string contraseñaIngresada = txtContraseña.Text;

            // Verifica si el usuario y la contraseña son correctos
            if (usuarioIngresado == Usuario && contraseñaIngresada == Contraseña)
            {
                MessageBox.Show("Inicio de sesión exitoso");
                Principal.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void s_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
