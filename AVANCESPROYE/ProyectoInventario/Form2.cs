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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       
        Form4 VerInventario = new Form4();  

        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo...");
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void btnAcciones_Click(object sender, EventArgs e)
        {
            VerInventario.Show();
        }

       
    }
}
