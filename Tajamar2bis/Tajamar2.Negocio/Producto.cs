using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tajamar2.Negocio
{
    public class Producto
    {
        public static DataTable obtenerProductos()
        {
            DataTable tabla = Datos.Producto.obtenerProductos();
            return tabla;
        }

        public static DataTable ObtenerProductoyCantidad(int idProducto)
        {
            DataTable tabla = Datos.Producto.ObtenerProductoyCantidad(idProducto);
            // Regla de Negocio
            if (Convert.ToInt32(tabla.Rows[0][2]) > 50)
            {
                return tabla;
            }
            else
            {
                return null;
            }
        }
    }
}
