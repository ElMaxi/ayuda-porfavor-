using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remuevete_velozmente_los_zapatos
{
     class Libro
    {
        public string CodigoLibro { get { return CodigoLibro; } private set { value = CodigoLibro; } }
        public string TituloLibro { get { return TituloLibro; } private set { value = TituloLibro; } }
        public string AutorLibro { get { return AutorLibro; } private set { value = CodigoLibro; } }
        public int CantidadLibros { get { return CantidadLibros; } private set { if (value >= 0) value = CantidadLibros; } }

        public Libro(string codigoLibro, string tituloLibro, string autorLibro, int cantidadLibros)
        {
            CodigoLibro = codigoLibro;
            TituloLibro = tituloLibro;
            AutorLibro = autorLibro;
            CantidadLibros = cantidadLibros;
        }

        public void MostrarDetallesLibro()
        {
            Console.WriteLine($"Título de libro: {TituloLibro},\n" +
                $"Autor del libro: {AutorLibro}\n" +
                $"Codigo del libro: {CodigoLibro}\n" +
                $"Cantidad de Libros disponibles: {CantidadLibros} ");
        }

        public void SumarLibroDisponible() => CantidadLibros++;

        public void SacarLibroDisponible() => CantidadLibros--;
    }
}
