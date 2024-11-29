using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static inicio_de_sesion.Class1;

namespace inicio_de_sesion
{
    internal class Class2
    {
        public void GuardarArchivo(List<inventario> inventarios, string rutaArchivo)
        {
            // Crear archivo binario
            using (FileStream archivo = new FileStream(rutaArchivo, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter escritor = new BinaryWriter(archivo))
                {
                    foreach (inventario c in inventarios)
                    {

                        escritor.Write(c.id);
                        escritor.Write(c.producto.ToCharArray());
                        escritor.Write(c.precio);
                        escritor.Write(c.cantidad);
                        escritor.Write(c.usuario.ToCharArray());
                    }
                }
            }
        }

        // Cargar el archivo cuando ya existe y poder leer los datos
        public List<inventario> CargarInventario(string rutaArchivo)
        {
            List<inventario> inventarios = new List<inventario>();
            if (!File.Exists(rutaArchivo))
            {
                return inventarios;
            }

            using (FileStream archivo = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader lector = new BinaryReader(archivo))
                {
                    while (archivo.Position != archivo.Length)
                    {
                        int ID = lector.ReadInt32();
                        int tamaño = lector.ReadInt32();
                        int tamaño2 = lector.ReadInt32();
                        char[] nombreArray = lector.ReadChars(tamaño);
                        string Producto = new string(nombreArray);
                        decimal Precio = lector.ReadDecimal();
                        int Cantidad = lector.ReadInt32();
                        char[] usuarioArray = lector.ReadChars(tamaño2);
                        string Usuario = new string(usuarioArray);

                        inventario Inventario = new inventario();
                        Inventario.id = ID;
                        Inventario.producto = Producto;
                        Inventario.precio = Precio;
                        Inventario.cantidad = Cantidad;
                        Inventario.usuario = Usuario;

                        inventarios.Add(Inventario);
                    }
                }
            }

            return inventarios;
        }
    }
}
