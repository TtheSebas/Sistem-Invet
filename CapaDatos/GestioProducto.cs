using DocumentFormat.OpenXml.Drawing.Charts;
using Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
namespace Datos
{
    public class GestionProducto
    {
        public void CargarProductos(string archivo, string entrada, List<Producto> productos)
        {
            try
            {
                productos.Clear();
                var verificar = new GestionDatos();
                verificar.VerificarArchivo(archivo, entrada);
                using (StreamReader archivoEntrada = new StreamReader(archivo))
                {
                    string? linea;
                    //Lee la primera linea
                    archivoEntrada.ReadLine();
                    //Lee cada linea
                    while ((linea = archivoEntrada.ReadLine()) != null)
                    {
                        string[] items = linea.Split(';'); //Leer hasta el delimitador
                        if (items.Length >= 5)
                        {
                            //bool disponible;
                            int cantidad;
                            double precio;
                            int.TryParse(items[3], out cantidad);
                            double.TryParse(items[4], out precio);
                            var producto = new Producto(items[0], items[1], items[2],
                                cantidad, precio);
                            productos.Add(producto);
                        }
                    }
                }
            }
            //solo dios y yo sabemos como se logro poner en marcha este codigo !!!SUERTE CON EL PROXIMO ENCARGADO!!!
            catch (IOException e)
            {
                throw new Exception("Error al leer el archivo" + e.Message);
            }
        }
        public void AgregarProducto(string archivo, string entrada, List<Producto> productos, string codigo, string nombre, string categoria, int cantidad, double precio)
        {
            CargarProductos(archivo, entrada, productos);
            try
            {
                using (StreamWriter datos = File.AppendText(archivo))
                {
                    Producto nuevoProducto = new Producto(codigo, nombre, categoria, cantidad, precio);
                    productos.Add(nuevoProducto);
                    // Escribir en el archivo
                    datos.WriteLine($"{codigo};{nombre};{categoria};{cantidad};{precio}");
                }
            }
            catch (IOException e)
            {
                throw new Exception("Error al leer el archivo" + e.Message);
            }
        }
        public void ActualizarProducto(string archivo, string entrada, List<Producto> productos, string codigo, string nombre, string categoria, int cantidad, double precio)
        {
            //CargarProductos(archivo, entrada, productos);
            string tempFile = Path.GetTempFileName();
            try
            {
                Console.WriteLine("Cantidad de productos: " + productos.Count);
                foreach (var p in productos)
                {
                    Console.WriteLine("Código en lista: [" + p.CodigoProducto + "]");
                }
                Console.WriteLine("Código buscado: [" + codigo + "]");

                //Buscar en la lista de productos el codigo dado
                int i = productos.FindIndex(p => p.CodigoProducto.Equals(codigo, StringComparison.OrdinalIgnoreCase));
                //Actualiza los productos de la lista con el indice encontrado
                if (i >= 0)
                {
                    productos[i].NombreProducto = nombre;
                    productos[i].CategoriaProducto = categoria;
                    productos[i].CantidadProducto = cantidad;
                    productos[i].PrecioProducto = precio;
                }
                else
                {
                    throw new Exception("Producto no encontrado");
                }
                //Metodo para generar el archivo con los cambios
                ReescribirArchivo(tempFile, archivo, entrada, productos);
            }
            catch (IOException e)
            {
                throw new Exception("Error al leer el archivo" + e.Message);
            }
        }
        public void EliminarProducto(string archivo, string entrada, List<Producto> productos, string codigo)
        {
            CargarProductos(archivo, entrada, productos);
            string tempFile = Path.GetTempFileName();
            try
            {
                int i = productos.FindIndex(p => p.CodigoProducto.Equals(codigo, StringComparison.OrdinalIgnoreCase)); //Se puede hacer un metodo para busqueda
                productos.RemoveAt(i);

                //Metodo para generar el archivo con los cambios
                ReescribirArchivo(tempFile, archivo, entrada, productos);
            }
            catch (IOException e)
            {
                throw new Exception("Error al leer el archivo" + e.Message);
            }
        }
        //Metodo para generar el archivo con los cambios
        public void ReescribirArchivo(string tempFile, string archivo, string entrada, List<Producto> productos)
        {
            using (StreamWriter fstemp = new StreamWriter(tempFile))
            {
                // Escribir encabezado
                fstemp.WriteLine(entrada);
                // Escribir todos los productos
                foreach (var producto in productos)
                {
                    fstemp.WriteLine($"{producto.CodigoProducto};{producto.NombreProducto};{producto.CategoriaProducto};{producto.CantidadProducto};{producto.PrecioProducto}");
                }
            }
            // Reemplazar archivo original
            File.Delete(archivo);
            File.Move(tempFile, archivo);
        }
        //MANEJO DE CATEGORIAS
        public List<string> CargarCategorias(string ruta = "categorias.csv", string encabezado = "Categorias")
        {
            var verificar = new GestionDatos();
            verificar.VerificarArchivo(ruta, encabezado);
            List<string> categorias = new List<string>();
            var lineas = File.ReadAllLines(ruta);
            for (int i = 1; i < lineas.Length; i++)
            {
                var partes = lineas[i].Split(';');
                if (partes.Length >= 1)
                {
                    var categoria = partes[0];
                    categorias.Add(categoria);
                }
            }
            return categorias;
        }
        public void RegistrarCategorias(List<string> categorias, string categoria, string ruta = "categorias.csv")
        {
            categorias = CargarCategorias();
            try
            {
                using (StreamWriter datos = File.AppendText(ruta))
                {
                    categorias.Add(categoria);
                    datos.WriteLine($"{categoria}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer el archivo" + ex.Message);
            }
        }
    }
}
