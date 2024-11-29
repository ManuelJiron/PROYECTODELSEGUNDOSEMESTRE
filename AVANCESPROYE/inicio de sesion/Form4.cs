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
        private string rutaArchivo;

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

        private void GuardarCambios()
        {
            if (!string.IsNullOrEmpty(rutaArchivo))
            {
                try
                {
                    Class2 archivo = new Class2();
                    archivo.GuardarArchivo(inventarios, rutaArchivo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar los cambios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se ha cargado o especificado un archivo para guardar los cambios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                rutaArchivo = openFileDialog1.FileName;

                Class2 archivo = new Class2();
                inventarios = archivo.CargarInventario(rutaArchivo);

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
                GuardarCambios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAccionGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "Archivos DAT (*.dat)|*.dat";
                saveFileDialog1.Title = "Guardar archivo";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Class2 archivo = new Class2();

                    archivo.GuardarArchivo(inventarios, saveFileDialog1.FileName);
                    MessageBox.Show("Archivo guardado...", "Archivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnAccionEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtAccionID.Text, out int id))
                {
                    int index = inventarios.FindIndex(p => p.id == id);
                    if (index != -1)
                    {
                        // Crear una copia modificada de la estructura
                        inventario productoEditado = inventarios[index];
                        productoEditado.producto = txtAccionProducto.Text;
                        productoEditado.precio = decimal.Parse(txtAccionPrecio.Text);
                        productoEditado.cantidad = int.Parse(txtAccionCantidad.Text);
                        productoEditado.usuario = txtAccionUsuario.Text;

                        // Reemplazar el elemento en la lista
                        inventarios[index] = productoEditado;

                        MessageBox.Show("Producto actualizado correctamente.", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El producto con el ID ingresado no existe en el inventario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    MostrarDatos();
                    LimpiarPantalla();
                    GuardarCambios();
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
