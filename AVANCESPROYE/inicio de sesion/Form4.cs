using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static inicio_de_sesion.Class1;

namespace inicio_de_sesion
{
    public partial class Form4 : Form
    {

        private List<inventario> inventarios;
        private inventario productos = new inventario();


        public Form4()
        {
            InitializeComponent();
            inventarios = new List<inventario>();
        }


        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void MostrarDatos()
        {
            dgvInventario.DataSource = null;
            dgvInventario.DataSource = inventarios;

        }


        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dgvInventario.CurrentRow;
            if (currentRow != null)
            {
                productos.id = int.Parse(currentRow.Cells[0].Value.ToString());
                productos.producto = currentRow.Cells[1].Value.ToString();
                productos.precio = decimal.Parse(currentRow.Cells[2].Value.ToString());
                productos.cantidad = int.Parse(currentRow.Cells[3].Value.ToString());
                productos.usuario = currentRow.Cells[4].Value.ToString();

                txtAccionID.Text = productos.id.ToString();
                txtAccionProducto.Text = productos.producto;
                txtAccionPrecio.Text = productos.precio.ToString();
                txtAccionCantidad.Text = productos.cantidad.ToString();
                txtAccionUsuario.Text = productos.usuario.ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAccionSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo...");
            Application.Exit();
        }

        private void btnAccionCargar_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Archivos DAT (*.dat)|*.dat|Todos los archivos (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ruta = openFileDialog1.FileName;

                Class2 archivo = new Class2();
                inventarios = archivo.CargarInventario(ruta);

                MostrarDatos();
            }
            else
            {
                MessageBox.Show("No se seleccionó ningún archivo.");
            }
        }

        private void btnAccionEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                inventarios.Remove(productos);
                MessageBox.Show("Producto eliminado...", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAccionGuardar_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarPantalla()
        {
            txtAccionID.Clear();
            txtAccionProducto.Clear();
            txtAccionPrecio.Clear();
            txtAccionCantidad.Clear();
            txtAccionUsuario.Clear();

        }

        private void btnAccionAgregar_Click(object sender, EventArgs e)
        {
            inventario Inventario = new inventario();

            Inventario.id = int.Parse(txtAccionID.Text);
            Inventario.producto = txtAccionProducto.Text;
            Inventario.precio = decimal.Parse(txtAccionPrecio.Text);
            Inventario.cantidad = int.Parse(txtAccionCantidad.Text);
            Inventario.usuario = txtAccionUsuario.Text;

            int index = inventarios.FindIndex(item => item.id == Inventario.id);

            if (index != -1)
            {
                inventarios[index] = Inventario;
            }
            else
            {
                inventarios.Add(Inventario);
            }

            MostrarDatos();
            LimpiarPantalla();
        }
    }
}
