using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjerciciosASP13Sql
{
    public partial class Ejercicio13_10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                GridView1.DataSource = (from s in db.Shippers
                                       select s).ToList();
            }
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                Shipper SP = new Shipper();
                SP.CompanyName = "Compañia añadida";
                SP.Phone = "Phone añadido";
                db.Shippers.InsertOnSubmit(SP);
                db.SubmitChanges();
            }
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        protected void ActualizarShipper(int id)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var dato = db.Shippers.SingleOrDefault(s => s.ShipperID.Equals(id));

                if (dato != null)
                {
                    dato.CompanyName = "Otra Company";
                    dato.Phone = "12121212";
                    db.SubmitChanges();
                }
            }
        }
    }
}