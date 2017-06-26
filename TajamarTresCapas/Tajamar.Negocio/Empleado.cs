using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tajamar.Negocio
{
    public class Empleado
    {
        public static DataTable recuperarTodosEmpleados(byte tipoUsuario)
        {
            /* si el usuario es el administrator */
            if (tipoUsuario == 1)
            {
                // vee datos porque ha sido referenciado
                return Datos.Empleado.recuperarTodosEmpleados();
            }
            /* si el usuario es un usuario normal */
            else
            {
                return null;
            }
        }
    }
}
