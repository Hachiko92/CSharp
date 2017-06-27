using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto33b_Collecion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public class Student
        {
            public string firstName { get; set; }
            public string LastName { get; set; }
            public int[] Scores { get; set; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList arrList = new ArrayList();
            arrList.Add(new Student{ firstName = "Svetlana", LastName = "Omelchenko", Scores = new int[] { 98, 92, 81, 60 } });
            arrList.Add(new Student { firstName = "Claire", LastName = "O'Donnes", Scores = new int[] { 75, 84, 91, 39 } });
            arrList.Add(new Student { firstName = "Sven", LastName = "Mortensen", Scores = new int[] { 98, 89, 85, 82 } });
            arrList.Add(new Student { firstName = "Cesar", LastName = "Garcia", Scores = new int[] { 97, 94, 81, 69 } });

            var query = from Student student in arrList
                        where student.Scores[0] > 95
                        select student;

            foreach (Student s in query)
            {
                Response.Write(s.firstName + " " + s.LastName + ": " + s.Scores[0]);
                Response.Write("<br />");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int[] fibonacciNumbers = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };

            /* trabajar con Linq */
            /* necesito una variable anonima porque no se lo que devuelve */
            var data = from n in fibonacciNumbers   // recorrer los datos
                       where n%2 == 0               // filtro
                       select n;                    // seleccion final
            /* data es un listado de int */

            List<int> lista = data.ToList();

            for (int i = 0; i < lista.Count(); i++)
            {
                Response.Write(lista[i]);
                Response.Write("<br />");
            }
        }
    }
}