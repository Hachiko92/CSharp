using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP8_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("Provincias");
            dt.Columns.Add("ProvinciaID", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));

            DataRow row1 = dt.NewRow();
            row1["ProvinciaID"] = 8;
            row1["Nombre"] = "Barcelona";
            dt.Rows.Add(row1);

            DataRow row2 = dt.NewRow();
            row2["ProvinciaID"] = 28;
            row2["Nombre"] = "Madrid";
            dt.Rows.Add(row2);

            DataRow[] currentRows = dt.Select(null, null, DataViewRowState.CurrentRows);
            
            if(currentRows.Length > 1)
            {
                foreach(DataColumn columna in dt.Columns)
                {
                    Response.Write("<strong>" + columna.ColumnName + " </strong>");
                }

                Response.Write("<br>");

                foreach (DataRow fila in currentRows)
                {
                    foreach(DataColumn columuns in dt.Columns)
                    {
                        Response.Write(fila[columuns] + " ");
                    }
                    Response.Write("<br>");
                }
            }

            Response.Write("<br><br><strong>Con DataView</strong><br>");

            DataView provincias = new DataView(dt, null, null, DataViewRowState.CurrentRows);
            foreach (DataRowView filas in provincias)
            {
                DataRow filaData = filas.Row;
                foreach (DataColumn columnaData in dt.Columns)
                {
                    Response.Write(filaData[columnaData] + " ");
                }
                Response.Write("<br>");
            }
        }
    }
}