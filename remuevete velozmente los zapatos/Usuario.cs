using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace remuevete_velozmente_los_zapatos
{
     public class Usuario
    {
        string NombreUsuario;
       
         Stack<LibroPrestamo> ListaPrestamos = new();


         Usuario(string nombreUsuario)
        {
            NombreUsuario = nombreUsuario;
        }
        

    }
}
