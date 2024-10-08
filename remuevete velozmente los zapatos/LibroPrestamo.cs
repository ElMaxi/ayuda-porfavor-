using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remuevete_velozmente_los_zapatos
{
     class LibroPrestamo
    {
        private string NombreUsuario {  get; set; }
        
        private string CodigoLibroPrestamo {  get; set; }
        private DateTime FechaPrestamo {  get; set; }
        public DateTime FechaDevolucionPrestamo
        {
            get { return FechaDevolucionPrestamo; }
            private set { value = FechaDevolucionPrestamo; }
        }
        public bool Devuelto;


      public LibroPrestamo(string nombreUsuario,string codigoLibroPrestamo, DateTime fechaPrestamo)
        {
            NombreUsuario = nombreUsuario;

            CodigoLibroPrestamo = codigoLibroPrestamo;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucionPrestamo = fechaPrestamo.AddDays(10);
            Devuelto = false;
        }

        public void PrestamoDevuelto() => Devuelto = true;





    }



}
