
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PantallaTablas.aspx.cs" Inherits="WebApplication1.PantallaTablas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Productos</title>
    <script src="jquery-1.12.3.js"></script>
    <script src="bootstrap.min.js"></script>
    <link href="bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="StyleTable.css" />
    <link rel="stylesheet" type="text/css" href="Login.css" />
    <meta name="viewport" content="initial-scale=1.0; maximum-scale=1.0; width=device-width;" />
    

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="row">
                <div class="col-md-6">
                     <div class="container col-xs-6">
                        <h1>Productos</h1>
                        <%-- Primer gridview: Productos --%>
                        <asp:GridView runat="server" ID="gridTabla" OnSelectedIndexChanged="gridTabla_SelectedIndexChanged" >
                            <Columns>

                                 <%-- Columna Agregar: llenado de checkbox --%>
                                <asp:TemplateField>
                                    <HeaderTemplate>
                                        Agregar
                                    </HeaderTemplate>
                                     
                                    <ItemTemplate> 
                                        <asp:CheckBox runat="server" ID="check" />
                                    </ItemTemplate>
                                    </asp:TemplateField>

                                
                                 <%-- Columna Cantidad: llenado de textbox --%>
                                 <asp:TemplateField>
                                    <HeaderTemplate>
                                        Cantidad
                                    </HeaderTemplate>
                                    <ItemTemplate> 
                                        <asp:TextBox runat="server" ID="txtCantidad" TextMode="Number" Width="50px" BackColor="White">0</asp:TextBox>
                                    </ItemTemplate>
                                </asp:TemplateField>  
                                <asp:BoundField DataField = "Articulo" HeaderText = "Articulo" />
                                <asp:BoundField DataField = "Precio" HeaderText = "Precio" />
                                <asp:BoundField DataField = "Disposicion" HeaderText = "Disposicion" />
                                <asp:BoundField DataField = "ImagePath" HeaderText = "ImagePath" Visible="false" />
                                <asp:ImageField DataImageUrlField="ImagePath" ControlStyle-Width="100"
                                                ControlStyle-Height = "100" HeaderText = "Imagen"/>
                            </Columns>

                        </asp:GridView>
                        <asp:Button runat="server" ID="btnAgregar" OnClick="btnAgregar_Click" CssClass="btn btn-success btn-lg" Text="Agregar" />
                    </div>
                </div>
                <div class="col-md-offset-7">
                    <div class="container">
                        <%-- Segundo gridview; Productos agregados--%>
                        <h1>Articulos agregados</h1>
                        <asp:LinkButton runat="server" class="btn btn-success" OnClick="Unnamed1_Click" ID="carrito"><i class="glyphicon glyphicon-shopping-cart"></i></asp:LinkButton>
                        <br />

                        <asp:GridView runat="server" ID="gridAgregado">
                        </asp:GridView>
                        <div class="alert alert-success col-md-3">
                            <asp:Label runat="server" ID="lblTotal" Font-Size="32px"></asp:Label> 
                        </div>
                    </div>
                   <button type="button" runat="server" ID="btnCotizar" class="btn btn-primary btn-lg" data-toggle="modal" data-target="#myModal">
                    <i class="glyphicon glyphicon-envelope"> </i> &nbsp Realizar cotizacion
                   </button>
                        <asp:Label runat="server" ID="lblTest" Font-Size="32px"></asp:Label>
                </div>
            </div>
        </div>
        
        <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
        <h4 class="modal-title" id="myModalLabel">Prueba correo</h4>
      </div>
      <div class="modal-body">
        <asp:Label runat="server" ID="lblMailTitle" Text="Direccion de correo destino:"></asp:Label>
          <br />
          
          <asp:TextBox runat="server" ID="txtMailField" placeholder="Correo@Example.com" CssClass="form-control" TextMode="Email"></asp:TextBox>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
        <asp:Button ID="btnEnviarCorreo" runat="server" CssClass="btn btn-primary" Text="Enviar correo" OnClick="btnEnviarCorreo_Click"/>
      </div>
    </div>
  </div>
</div>






    </form>
</body>
</html>
