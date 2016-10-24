using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            
        }

        private void validateUser()
        {
            String user = this.username.Text.Trim();
            String pass = this.password.Text.Trim();
        }

    }
}