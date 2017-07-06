using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto43_GridView
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            TextBox customerID = GridView1.FooterRow.FindControl("CustomerIdTxt") as TextBox;
            TextBox CompanyName = GridView1.FooterRow.FindControl("CompanyNameTxt") as TextBox;
            DropDownList ContactTitle = GridView1.FooterRow.FindControl("drpContactTitle") as DropDownList;

            SqlDataSource1.InsertParameters["CustomerID"].DefaultValue = customerID.Text;
            SqlDataSource1.InsertParameters["CompanyName"].DefaultValue = CompanyName.Text;
            SqlDataSource1.InsertParameters["ContactTitle"].DefaultValue = ContactTitle.SelectedValue;

            SqlDataSource1.Insert();
        }
    }
}