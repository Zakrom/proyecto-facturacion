using System; 
using System.Web.UI.WebControls; 
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
                btnCotizar.Visible = false;
            }

        }

        public void llenarTabla()
        {
            DataSet ds = SQL.ConnectionSql.selectQuery("SELECT producto.pto_name as 'Articulo', producto.pto_price as 'Precio', producto.pto_type as 'Disposicion', producto.pto_img as 'ImagePath' FROM cotimex.producto;");
        
           
            this.gridTabla.DataSource = ds;
            this.gridTabla.AutoGenerateColumns = false;
            this.gridTabla.DataBind();

            foreach (GridViewRow item in gridTabla.Rows)
            {
                if (item.Cells[4].Text.Equals("1"))
                {
                    item.Cells[4].Text = "Venta";
                }
                else
                {
                    item.Cells[4].Text = "Renta";
                }
            }
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

            // Crear nueva columna: Cantidad 
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Cantidad";
            datos.Columns.Add(column);

            // Crear nueva columna: Precio 
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Precio";
            datos.Columns.Add(column);

            // Crear nueva columna: Subtotal  
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Subtotal";
            datos.Columns.Add(column);

            int total = 0;
            foreach (GridViewRow item in gridTabla.Rows)
            {
                CheckBox check = (CheckBox)item.FindControl("check");
                TextBox txtCantidad = (TextBox)item.FindControl("txtCantidad");
                if (check != null)
                {
                    if (check.Checked)
                    {

                        row = datos.NewRow(); 
                        row["Articulo"] = item.Cells[2].Text;
                        row["Cantidad"] = txtCantidad.Text;
                        row["Precio"] = item.Cells[3].Text;
                        total += Convert.ToInt32(item.Cells[3].Text) * Convert.ToInt32(txtCantidad.Text);
                        row["Subtotal"] = Convert.ToInt32(txtCantidad.Text)*Convert.ToInt32(item.Cells[3].Text);
                        datos.Rows.Add(row);
                    }
                } 
            }
            this.lblTotal.Text = "Total: " + total.ToString();
            this.gridAgregado.DataSource = datos;
            this.gridAgregado.DataBind();

            if (total == 0)
            {
                this.btnCotizar.Visible = false;
            }
            else
            {
                this.btnCotizar.Visible = true;
            }

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

        public String stractData()
        {
            String reciboImprecion;
            reciboImprecion = "Recibo: " + System.Environment.NewLine + "Producto || Cantidad || Precio || Subtotal";
            foreach (GridViewRow row in gridAgregado.Rows)
            {
                reciboImprecion += "\r\n" + row.Cells[0].Text + " || " + row.Cells[1].Text + " || $" + row.Cells[2].Text + " || $" + row.Cells[3].Text;

            }
            // this.lblTest.Text = reciboImprecion;
            reciboImprecion += System.Environment.NewLine + "\n" + this.lblTotal.Text;
            return reciboImprecion;
        }

        public void EnviarCorreo()
        {
            /*-------------------------MENSAJE DE CORREO----------------------*/

            //Creamos un nuevo Objeto de mensaje
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

            //Direccion de correo electronico a la que queremos enviar el mensaje
            mmsg.To.Add(this.txtMailField.Text);

            //Nota: La propiedad To es una colección que permite enviar el mensaje a más de un destinatario

            //Asunto
            mmsg.Subject = "Asunto de prueba";
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

            //Direccion de correo electronico que queremos que reciba una copia del mensaje
            // mmsg.Bcc.Add("destinatariocopia@servidordominio.com"); //Opcional

            //Cuerpo del Mensaje
            mmsg.Body = stractData();
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = false; //Si no queremos que se envíe como HTML

            //Correo electronico desde la que enviamos el mensaje
            mmsg.From = new System.Net.Mail.MailAddress("pruebasintegradorproyecto@gmail.com");


            /*-------------------------CLIENTE DE CORREO----------------------*/

            //Creamos un objeto de cliente de correo
            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

            //Hay que crear las credenciales del correo emisor
            cliente.Credentials =
                new System.Net.NetworkCredential("pruebasintegradorproyecto@gmail.com", "pruebas123");

            //Lo siguiente es obligatorio si enviamos el mensaje desde Gmail

            cliente.Port = 587;
            cliente.EnableSsl = true;


            cliente.Host = "smtp.gmail.com"; //Para Gmail "smtp.gmail.com";


            /*-------------------------ENVIO DE CORREO----------------------*/

            try
            {
                //Enviamos el mensaje      
                cliente.Send(mmsg);
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                //Aquí gestionamos los errores al intentar enviar el correo
            }
        }


        protected void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            EnviarCorreo();
        }

    }
}