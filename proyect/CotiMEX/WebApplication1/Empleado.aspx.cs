using System;
using System.Collections.Generic;
using System.Data;
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

        protected void login_Click(object sender, EventArgs e)
        {
            String user = this.username.Text.Trim();
            String pass = this.password.Text.Trim();

            DataSet ds = SQL.ConnectionSql.selectQuery("SELECT user_id FROM cotimex.user WHERE user_name = '" + user + "' AND user_password = '" + pass + "';");
            this.username.Text = "nailed it";
            if(ds.Tables[0].Rows.Count == 1 )
            {
                this.username.Text = "Success";
            }
            else
            {
                this.username.Text = "Fails";
            }            

        }
    }
}