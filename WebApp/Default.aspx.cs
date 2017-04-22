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
        protected void Page_Load(object sender, EventArgs e)
        {
            EmployeeData eD = new EmployeeData();
            gridView.DataSource = eD.Read();            
            gridView.DataBind();
            gridView.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
    }
}