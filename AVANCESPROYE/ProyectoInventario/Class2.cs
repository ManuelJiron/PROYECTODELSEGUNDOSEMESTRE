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
                    // Escribir los datos en el archivo
                    escritor.Write(c.id);

                    // Escribir el tamaño del producto y luego sus caracteres
                    escritor.Write(c.producto.Length);
                    escritor.Write(c.producto.ToCharArray());

                    escritor.Write(c.precio);
                    escritor.Write(c.cantidad);

                    // Escribir el tamaño del usuario y luego sus caracteres
                    escritor.Write(c.usuario.Length);
                    escritor.Write(c.usuario.ToCharArray());
                }
            }
        }
    }

    // Método para cargar el inventario desde un archivo binario
    public List<inventario> CargarInventario(string rutaArchivo)
    {
        List<inventario> inventarios = new List<inventario>();

        // Verificar si el archivo existe
        if (!File.Exists(rutaArchivo))
        {
            return inventarios;
        }

        using (FileStream archivo = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read))
        {
            using (BinaryReader lector = new BinaryReader(archivo))
            {
                while (archivo.Position < archivo.Length)
                {
                    
                    int ID = lector.ReadInt32();

                    int tamañoProducto = lector.ReadInt32();
                    char[] nombreArray = lector.ReadChars(tamañoProducto);
                    string Producto = new string(nombreArray);

                    decimal Precio = lector.ReadDecimal();
                    int Cantidad = lector.ReadInt32();

                    int tamañoUsuario = lector.ReadInt32();
                    char[] usuarioArray = lector.ReadChars(tamañoUsuario);
                    string Usuario = new string(usuarioArray);

                    // Crear el objeto y lo agrega a la lista
                    inventario Inventario = new inventario
                    {
                        id = ID,
                        producto = Producto,
                        precio = Precio,
                        cantidad = Cantidad,
                        usuario = Usuario
                    };

                    inventarios.Add(Inventario);
                }
            }
        }

        return inventarios;
    }
    }
}
