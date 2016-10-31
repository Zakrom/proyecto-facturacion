
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PantallaTablas.aspx.cs" Inherits="WebApplication1.PantallaTablas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Productos</title>
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
                    <div class="container">
                        <h1>Productos</h1>
                        <%-- Primer gridview: Productos --%>
                        <asp:GridView runat="server" ID="gridTabla" OnSelectedIndexChanged="gridTabla_SelectedIndexChanged">
                            <Columns>
                                <asp:TemplateField>
                                    <HeaderTemplate>
                                        Agregar
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <%--                    <asp:LinkButton runat="server" ID="lbtnAgregar" CommandName="select"><i class="glyphicon glyphicon-plus">Agregar </i></asp:LinkButton>--%>
                                        <asp:CheckBox runat="server" ID="check" />
                                    </ItemTemplate>
                                </asp:TemplateField>

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
                </div>
            </div>
        </div>
    </form>
</body>
</html>
