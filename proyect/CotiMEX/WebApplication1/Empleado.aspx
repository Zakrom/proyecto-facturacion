<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empleado.aspx.cs" Inherits="WebApplication1.Cliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <script type="texy/javascript" src="CustomScripts/jquery-3.1.1.min.js"></script>
    <script type="text/javascript"  src="CustomScripts/bootstrap-3.3.7-dist/js\bootstrap.min.js"></script>
     <link rel="stylesheet" href="CustomScripts/bootstrap-3.3.7-dist/css/bootstrap.min.css"/>
     <script type="text/javascript" src="CustomScripts/login.js"></script>
    <link rel="stylesheet" href="CustomScripts/Login.css" />

    <title>Login</title>
</head>
 
          
      <!-- 
 * parallax_login.html
 * @Author original @msurguy (tw) -> http://bootsnipp.com/snippets/featured/parallax-login-form
 * @Tested on FF && CH
 * @Reworked by @kaptenn_com (tw)
 * @package PARALLAX LOGIN.
-->
        <script src="http://mymaplist.com/js/vendor/TweenLite.min.js"></script>
        <body>
            <div class="container">
                <div class="row vertical-offset-100">
                    <div class="col-md-4 col-md-offset-4">
                        <div class="panel panel-default">
                            <div class="panel-heading">                                
                                <div class="row-fluid user-row">
                                    
                                    <img src="Images\tecmed3d-logo.png" class="img-responsive" alt="Conxole Admin" />


                                </div>
                            </div>
                            <div class="panel-body">
                                <form accept-charset="UTF-8" role="form" class="form-signin" runat="server">
                                    <fieldset>
                                        <label class="panel-login">
                                            <div class="login_result"></div>
                                        </label>
                                     
                                        <asp:TextBox  ID="username" runat="server"  CssClass="form-control" placeholder="Usuario" required="true"></asp:TextBox><br />
                                     

                                        <asp:TextBox ID="password" runat="server" placeholder="Contraseña" CssClass="form-control" TextMode="Password" required="true" ></asp:TextBox> <br />

                                        <br/>
                                        
                                         <asp:Button  ID="login" runat="server" Text="Iniciar sesion" CssClass="btn btn-lg btn-success btn-block" OnClick="login_Click" />

                                    </fieldset>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </body>
            </div> 
    
    </div>
    </form>
</>
</html>
