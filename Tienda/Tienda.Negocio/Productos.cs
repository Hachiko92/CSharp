using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Negocio
{
    public class Productos
    {
        public static DataTable cargarTabla()
        {
            return Datos.Productos.cargarTabla();
        }
        
    }
}
