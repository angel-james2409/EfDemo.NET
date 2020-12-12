using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EfDemo
{
    public partial class CustomerE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CustomerEf _context = new CustomerEf();
            var list = from c in _context.Customers
                       where c.customerId > 2
                       select c;
            GridView1.DataSource = list.ToList();
            GridView1.DataBind();

        }
    }
}