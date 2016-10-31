using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class PantallaTablas : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                llenarTabla();
            }

        }

        public void llenarTabla()
        {
            DataSet ds = SQL.ConnectionSql.selectQuery("SELECT producto.pto_name as 'Articulo', producto.pto_price as 'Precio', producto.pto_type as 'Disposicion', producto.pto_img as 'Imagen' FROM cotimex.producto;");

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                row["Imagen"] = ResolveUrl(row["Imagen"].ToString());
            }
            this.gridTabla.DataSource = ds;
            this.gridTabla.DataBind();

        }

        protected void gridTabla_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

            DataTable datos = new DataTable();

            //Tomar los datos del registro seleccionado
            //String id = this.gridTabla.SelectedRow.Cells[1].Text;
            //String articulo = this.gridTabla.SelectedRow.Cells[2].Text;
            //String precio = this.gridTabla.SelectedRow.Cells[3].Text;
            //String imagen = this.gridTabla.SelectedRow.Cells[4].Text;
            //String tipo = this.gridTabla.SelectedRow.Cells[5].Text;

            DataColumn column;
            DataRow row;


            // Crear nueva columna dentro del gridview  
            //column = new DataColumn();
            //column.DataType = System.Type.GetType("System.Int32");
            //column.ColumnName = "ID";
            //datos.Columns.Add(column);


            // Crear nueva columna dentro del gridview  
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Articulo";
            datos.Columns.Add(column);

            // Crear nueva columna dentro del gridview  
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Precio";
            datos.Columns.Add(column);

            // Crear nueva columna dentro del gridview  
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Subtotal";
            datos.Columns.Add(column);

            int total = 0;
            foreach (GridViewRow item in gridTabla.Rows)
            {
                CheckBox check = (CheckBox)item.FindControl("check");
                if (check != null)
                {
                    if (check.Checked)
                    {

                        row = datos.NewRow();
                        //row["ID"] = item.Cells[1].Text;
                        row["Articulo"] = item.Cells[1].Text;
                        row["Precio"] = item.Cells[2].Text;
                        total += Convert.ToInt32(item.Cells[2].Text);
                        row["Subtotal"] = total;
                        datos.Rows.Add(row);
                    }
                }
            }
            this.lblTotal.Text = "Total: " + total.ToString();
            this.gridAgregado.DataSource = datos;
            this.gridAgregado.DataBind();

            //if(total == 0){
            //    this.lblTotal.Visible = false;
            //}

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if (this.gridAgregado.Visible == false)
            {
                this.gridAgregado.Visible = true;
            }
            else
            {
                this.gridAgregado.Visible = false;
            }
        }
    }
}