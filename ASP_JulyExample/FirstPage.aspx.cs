using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_JulyExample
{
    public partial class FirstPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btndisplay_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            Label1.Text = txtname.Text;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Label2.Text = "Welcome";
        }
    }
}