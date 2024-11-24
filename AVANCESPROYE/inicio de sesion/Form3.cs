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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        
        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo del programa...");
            Application.Exit();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
