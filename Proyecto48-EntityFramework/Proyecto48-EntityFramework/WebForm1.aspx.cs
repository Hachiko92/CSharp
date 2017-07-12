using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto48_EntityFramework
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* la conexion */
            using(var context = new Model1Container())
            {
                var person = new Persona
                {
                    FirstName = "Roberto",
                    LastName = "Allen",
                    PhoneNumber = "123-4567"
                };
                context.PersonaSet.Add(person);

                var person1 = new Persona
                {
                    FirstName = "Roberta",
                    LastName = "Alena",
                    PhoneNumber = "123-4567"
                };
                context.PersonaSet.Add(person1);

            }
        }
    }
}