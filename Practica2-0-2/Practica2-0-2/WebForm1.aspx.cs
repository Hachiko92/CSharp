using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica2_0_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public class Contact
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string State { get; set; }
        }

        public static List<Contact> CrearLista()
        {
            List<Contact> contact = new List<Contact>();

            Contact person1 = new Contact {FirstName = "Joe", LastName = "Doe", Email = "joedoe@email.com", Phone = "136436789", DateOfBirth = Convert.ToDateTime("15/3/1965"), State = "Florida" };
            contact.Add(person1);

            Contact person2 = new Contact { FirstName = "Arya", LastName = "Stark", Email = "alguien@gmail.com", Phone = "875345289", DateOfBirth = Convert.ToDateTime("8/4/1986"), State = "Florida" };
            contact.Add(person2);

            Contact person3 = new Contact { FirstName = "Mark", LastName = "Plinpton", Email = "mark@email.com", Phone = "923456789", DateOfBirth = Convert.ToDateTime("5/6/1990"), State = "Alabama" };
            contact.Add(person3);

            Contact person4 = new Contact { FirstName = "Cindy", LastName = "Clefford", Email = "Cindy@email.com", Phone = "427456789", DateOfBirth = Convert.ToDateTime("12/07/1984"), State = "Alabama" };
            contact.Add(person4);

            Contact person5 = new Contact { FirstName = "Hank", LastName = "Chinaski", Email = "hank@email.com", Phone = "654987321", DateOfBirth = Convert.ToDateTime("25/11/1982"), State = "Los Angeles" };
            contact.Add(person5);

            Contact person6 = new Contact { FirstName = "Andy", LastName = "Long", Email = "andy@email.com", Phone = "113244789", DateOfBirth = Convert.ToDateTime("1/10/1972"), State = "California" };
            contact.Add(person6);

            return contact;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Contact> contacts = CrearLista();

            var query = from c in contacts
                        orderby c.LastName ascending
                        select c;

            //var queryLambda = contacts.OrderBy(n => n.LastName);

            pContact.InnerHtml = "";
            foreach (Contact q in query)
            {
                pContact.InnerHtml += "<strong>" +  q.LastName + " " + q.FirstName + ":</strong> " + q.Email + " " + q.Phone + " " + q.DateOfBirth.ToShortDateString() + " " + q.State + "<br>";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Contact> contacts = CrearLista();

            var query = from c in contacts
                        where c.FirstName.StartsWith("A")
                        select c;

            result.InnerHtml = "";
            foreach (Contact q in query)
            {
                result.InnerHtml += q.FirstName + " " + q.LastName + " " + q.Phone + "<br>";
            }

            var queryLambda =
                contacts
                .Where(c => c.FirstName.StartsWith("A"))
                .Select(n => n.FirstName + " " + n.LastName + ": " + n.Phone);

            result.InnerHtml += "<br><strong>Con Lambda:</strong><br>";
            foreach (string q in queryLambda)
            {
                result.InnerHtml += q + "<br>";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            List<Contact> contacts = CrearLista();

            var query = (from c in contacts
                        where c.Email == "alguien@gmail.com"
                        select c).FirstOrDefault();

            var queryLambda = contacts
                              .Where(c => c.Email == "alguien@gmail.com")
                              .Select(c => c.LastName + " " + c.FirstName + " " + c.Phone)
                              .FirstOrDefault();

            if ((query != null)&&(queryLambda != null))
            {
                result.InnerHtml = "";
                result.InnerHtml += query.LastName + " " + query.FirstName + " " + query.Phone + "<br>";

                result.InnerHtml += "<br><strong>Con Lambda:</strong><br>";
                result.InnerHtml += queryLambda + "<br>";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            List<Contact> contacts = CrearLista();

            var query = from c in contacts
                        where (c.State == "Alabama") && (c.Phone.StartsWith("9"))
                        select c.LastName + " " + c.FirstName + " " + c.Phone;

            var queryLambda = 
                contacts
                .Where(c => (c.State == "Alabama") && (c.Phone.StartsWith("9")))
                .Select(c => c.LastName + " " + c.FirstName + " " + c.Phone);

            result.InnerHtml = "";
            foreach (string q in query)
            {
                result.InnerHtml += q + "<br>";
            }

            result.InnerHtml += "<br><strong>Con Lambda:</strong><br>";
            foreach (string q in queryLambda)
            {
                result.InnerHtml += q + "<br>";
            }
        }
    }
}