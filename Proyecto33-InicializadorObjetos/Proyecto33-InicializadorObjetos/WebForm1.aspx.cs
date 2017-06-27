using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto33_InicializadorObjetos
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* tiene los mismos metodos del SortedList y del ArrayList */
            List<int> lista = new List<int>();
            lista.Add(1);
            lista.Add(23);
            lista.Add(6);
            lista.Add(43);
            lista.Add(1);

            foreach (int valores in lista)
            {
                Response.Write(valores);
            }

            Person person = new Person { nombre = "John", apellido = "Doe", edad = 24};

            List<Person> listaPersonas = new List<Person>();

            List<Person> amigos = new List<Person>
            {
                new Person { nombre = "Andrés", apellido = "Jimenèz", edad = 34 },
                new Person { nombre = "Ana", apellido = "Rodriguez", edad = 36 },
                new Person { nombre = "Eva", apellido = "Sanchez", edad = 30 }
            };

            /* las var tengan que ser inicializada desde el principio */
            //var cont;
            var cont = 0;

            var persona = new Person { nombre = "John", apellido = "Doe", edad = 24 };
        }
    }
}