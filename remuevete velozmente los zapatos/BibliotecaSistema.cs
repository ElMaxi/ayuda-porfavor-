using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace remuevete_velozmente_los_zapatos
{
    public class BibliotecaSistema
    {
        static List<Usuario> UsuarioList = new();
        static List<Libro> LibroList = new();
        static readonly string ArchivoUsuario = "Usuario.txt";
        static readonly string ArchivoLibros = "Libros.txt";
        public void CrearUsuario(string Nombre)
        {
            var query = UsuarioList.FirstOrDefault(query => (query.NombreUsuario == Nombre));

            if (query == null)
            {
                throw new Exception($"Este usuario ya existe.");
            }

            Usuario name = new Usuario(Nombre);
            UsuarioList.Add(name);
            Console.WriteLine($"Usuario añadido exitosamente.\n");
        
        }

        public void PedirLibros(string Nombre, string Codigo)
        {

            var query = UsuarioList.FirstOrDefault(query => (query.NombreUsuario == Nombre));

            if (query != null) {
                throw new Exception($"Este usuario no existe.)"); }

            foreach (Usuario usuario in UsuarioList)
            {

               if (usuario.NombreUsuario == Nombre)
                {
                    if (usuario.ListaPrestamos.Peek().Devuelto == false)
                    {
                        throw new Exception($"Hay deudas que saldar... 💀");
                    }
                }

                LibroPrestamo example = new LibroPrestamo(Nombre, Codigo, DateTime.Now);
                usuario.ListaPrestamos.Push(example);

                Console.WriteLine($"\nLibro pedido con éxito.\n");
            }
        }


        public void DevolverLibros(string Nombre)
        {
            var query = UsuarioList.FirstOrDefault(query => (query.NombreUsuario == Nombre));

            if (query != null)
            {
                throw new Exception($"Este usuario no existe.");
            }
            foreach (Usuario usuario in UsuarioList)
            {

                if (usuario.NombreUsuario == Nombre)
                {
                    if (usuario.ListaPrestamos.Peek().Devuelto == false)
                    {
                        usuario.ListaPrestamos.Peek().Devuelto = true;
                        Console.WriteLine($"\nLibro devuelto con éxito.\n");
                        break;
                    } 
                }
            }
        }

        public void ExtenderDevolucion(string Nombre)
        {
            var query = UsuarioList.FirstOrDefault(query => (query.NombreUsuario == Nombre));

            if (query != null)
            {
                throw new Exception($"Este usuario no existe.");
            }
            Console.WriteLine($"Ingrese la cantidad de días a agregar:\n");
            int caramba = int.Parse(Console.ReadLine());
            foreach (Usuario usuario in UsuarioList)
            {

                if (usuario.NombreUsuario == Nombre)
                {

                    usuario.ListaPrestamos.Peek().FechaDevolucionPrestamo.AddDays(caramba);
                    Console.WriteLine($"\n Devolución extendida con éxito.\n");
                    break;
                }
            }
        }

        public void MostrarLibros()
        {
            Console.WriteLine($"Libros disponibles:");

            foreach(Libro libro in LibroList)
            {
                Console.WriteLine($"\n");
                libro.MostrarDetallesLibro();
                Console.WriteLine($"\n\n");
            }
        }

        public void GuardarDatos()
        {
            using StreamWriter writer1 = new StreamWriter(ArchivoLibros, true);
                using StreamWriter writer2 = new StreamWriter(ArchivoUsuario, true);

            foreach (Libro libro in LibroList)
            {
                writer1.WriteLine($"{libro.CodigoLibro} - {libro.TituloLibro} - {libro.AutorLibro} - {libro.CantidadLibros}\n");
            }
            foreach (Usuario usuario in UsuarioList)
            {
                writer2.WriteLine($"+");
                writer2.WriteLine(usuario.NombreUsuario);
                foreach (var LibroPrestamo in usuario.ListaPrestamos)
                {
                    writer2.WriteLine("-");
                    writer2.WriteLine(LibroPrestamo);
                }

            }
        }
        public void CargarContactos()
        {
            
            if (File.Exists(ArchivoLibros))
            {
                foreach(var line in File.ReadAllLines(ArchivoLibros))
                {
                    var datos = line.Split("-");
                    var libro = new Libro(datos[0], datos[1], datos[2], int.Parse(datos[3]));
                    LibroList.Add(libro);
                }
            }
            if (File.Exists(ArchivoUsuario))
            {
                foreach (var line in File.ReadAllLines(ArchivoUsuario))
                {
                    using StreamReader reader = new StreamReader(ArchivoUsuario);
                    string linea;
                    Usuario nuevo = null;

                    while ((linea = reader.ReadLine()) != null)
                    {
                        if (linea == "+")
                        {
                            nuevo = null;
                        }
                        else if (nuevo == null)
                        {
                            
                            
                        }
                        if (!linea.StartsWith("-"))
                        {
                            
                        }
                    }

                    UsuarioList.Add(nuevo);        
                    
                }

            }

        }


    }
}



