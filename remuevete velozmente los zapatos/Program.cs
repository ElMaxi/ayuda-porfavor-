using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remuevete_velozmente_los_zapatos
{
     class Program
    {
         
        static void Main()
        {
            BibliotecaSistema Sistema = new BibliotecaSistema();
            int opcion = 0;
            do
            {
                Console.WriteLine($"1. Crear Usuario \n");
                Console.WriteLine($"2. Pedir Libro \n");
                Console.WriteLine($"3. Extender Devolución \n");
                Console.WriteLine($"4. Mostrar Libros \n");
                Console.WriteLine($"5. Guardar y salir \n");

                 opcion = int.Parse(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        {
                            Console.WriteLine($"Para crear un usuario, Ingrese un nombre para su usuario:    ");
                            string name = Console.ReadLine();
                            Sistema.CrearUsuario(name);

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"\nPara pedir un libro, ingrese su nombre de usuario:  ");
                            string name = Console.ReadLine();

                            Console.WriteLine($"\nY ahora, ingrese el código del libro que desea pedir:   ");
                            string code = Console.ReadLine();

                            Sistema.PedirLibros(name, code);


                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"Para extender su devolución, debe ingresar su nombre de usuario:    ");
                            string name = Console.ReadLine();

                            Sistema.ExtenderDevolucion(name);
                            break;
                        }
                    case 4:
                        {
                            Sistema.MostrarLibros();

                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine($"chauchas");
                            Sistema.GuardarDatos();
                            break;
                        }
                    default:
                        {
                            Sistema.GuardarDatos();
                            break;
                        }

                }
            } while (opcion != 5);

        }
    }
}
