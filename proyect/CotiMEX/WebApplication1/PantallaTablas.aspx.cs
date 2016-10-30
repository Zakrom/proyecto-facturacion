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
            //String connectionString = "Data Source=148.234.37.144;Initial Catalog=FIME-FlowSys-TrainingBD;User ID=cacevedo;Password=Carlozasdasd123";
            //SqlConnection conexion = new SqlConnection(connectionString);

            //SqlCommand sqlsp = new SqlCommand("sp_llenarTabla", conexion);
            //sqlsp.CommandType = CommandType.StoredProcedure;

            //conexion.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlsp);
            //DataSet dataSet = new DataSet();
            //sqlDataAdapter.Fill(dataSet);

            //this.gridTabla.DataSource = dataSet;
            //this.gridTabla.DataBind();

            //conexion.Close();

        }

        protected void gridTabla_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

            DataTable datos = new DataTable();

            ////Tomar los datos del registro seleccionado
            //String id = this.gridTabla.SelectedRow.Cells[1].Text;
            //String articulo = this.gridTabla.SelectedRow.Cells[2].Text;
            //String precio = this.gridTabla.SelectedRow.Cells[3].Text;
            //String imagen = this.gridTabla.SelectedRow.Cells[4].Text;
            //String tipo = this.gridTabla.SelectedRow.Cells[5].Text;

            DataColumn column;
            DataRow row;


            // Crear nueva columna dentro del gridview  
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "ID";
            datos.Columns.Add(column);


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
                        row["ID"] = item.Cells[1].Text;
                        row["Articulo"] = item.Cells[2].Text;
                        row["Precio"] = item.Cells[3].Text;
                        total += Convert.ToInt32(item.Cells[3].Text);
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