using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using WebApplication1.SQL;

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
 
            ClientScriptManager cs = Page.ClientScript;

            DataSet ds = SQL.ConnectionSql.selectQuery("SELECT user_id FROM cotimex.user WHERE user_name = '" + user + "' AND user_password = '" + pass + "';");
            int rowCount = ds.Tables[0].Rows.Count;
            if (rowCount > 0)
            {
                string name = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                string script1 = "<script>alert" + "('USUARIO  LOGGEADO');" + "</script>";
                cs.RegisterStartupScript(this.GetType(), "script1", script1);
                this.Response.Redirect("PantallaTablas.aspx");
                this.Session.Add("user", pass);

              

            }
            else
            {
                string script1 = "<script>alert('USUARIO INVALIDO');</script>";
                cs.RegisterStartupScript(this.GetType(), "script1", script1);
            }

        }

      
    }
}