<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empleado.aspx.cs" Inherits="WebApplication1.Cliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <script type="texy/javascript" src="CustomScripts/jquery-3.1.1.min.js"></script>
    <script type="text/javascript"  src="CustomScripts/bootstrap-3.3.7-dist/js\bootstrap.min.js"></script>
     <link rel="stylesheet" href="CustomScripts/bootstrap-3.3.7-dist/css/bootstrap.min.css"/>
     <script type="text/javascript" src="CustomScripts/login.js"></script>
    <link rel="stylesheet" href="CustomScripts/LoginEmpleado.css" />

    <title>Login</title>
</head>
<body> 
          <div>
    
        <div class="container">
  
  <div class="row" id="pwd-container">
    <div class="col-md-4"></div>
    
    <div class="col-md-4">
      <section class="login-form">
        <form method="post" action="#" role="login" runat="server">
         
          
                      
          <div class="pwstrength_viewport_progress"></div>
                   
          
            
        <img src="Images\tecmed3d-logo.png" class="img-responsive" alt="" /><br />
        <asp:Label ID="lblempleado" runat="server" Text="Usuario"></asp:Label><br />
        <asp:TextBox  ID="txtEmpleado" runat="server"  CssClass="textbox"></asp:TextBox><br />
        <asp:Label ID="lblcontra" runat="server" Text="Contraseña"></asp:Label>
        <asp:TextBox ID="txtPass" runat="server"  CssClass="textbox" TextMode="Password" ></asp:TextBox> <br />
        <asp:Button  ID="login" runat="server" Text="Iniciar sesion" CssClass="btnlogin" />

         
          
        
        
        
      </section>  
      </div>
      
      <div class="col-md-4"></div>
      

  </div>
  
  <p>
    <a href="http://validator.w3.org/check?uri=http%3A%2F%2Fbootsnipp.com%2Fiframe%2FW00op" target="_blank"><small>HTML</small><sup>5</sup></a>
    <br/>
    <br/>
    
  </p>     
  
  
</div>
        
    </div>


    </div>
    </form>
</body>
</html>
