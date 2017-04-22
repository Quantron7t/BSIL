using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using BusinessObjects;

namespace WebApp
{
    public partial class _Default : Page
    {
        EmployeeData eD = new EmployeeData();

        protected void Page_Load(object sender, EventArgs e)
        {
            gridView.DataSource = eD.Read();            
            gridView.DataBind();
            gridView.HeaderRow.TableSection = TableRowSection.TableHeader;
        }

        protected void gridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            eD.Delete(int.Parse(gridView.Rows[e.RowIndex].Cells[2].Text));
            gridView.DataSource = eD.Read();
            gridView.DataBind();
            UpdatePanel1.Update();
        }
    }
}