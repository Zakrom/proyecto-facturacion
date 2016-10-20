<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

   
    <script type="texy/javascript" src="CustomScripts/jquery-3.1.1.min.js"></script>
    <script type="text/javascript"  src="CustomScripts/bootstrap-3.3.7-dist/js\bootstrap.min.js"></script>
     <link rel="stylesheet" href="CustomScripts/bootstrap-3.3.7-dist/css/bootstrap.min.css"/>


     <script type="text/javascript" src="CustomScripts/login.js"></script>
    <link rel="stylesheet" href="CustomScripts/Login.css" />

    <title>COTIMEX</title>
</head>
<body>
    
    <div>
    
        <div class="container">
  
  <div class="row" id="pwd-container">
    <div class="col-md-4"></div>
    
    <div class="col-md-4">
      <section class="login-form">
        <form method="post" action="#" role="login" runat="server">
          <img src="Images\tecmed3d-logo.png" class="img-responsive" alt="" />
          
           
            
          <div class="pwstrength_viewport_progress"></div>
                   
          
            <div id="label">
                 Iniciar sesion como:
            </div>

            <asp:Button ID="btnCliente" runat="server" Text="Cliente"  /><br />
            <asp:Button ID="btnEmpleado" runat="server" Text="Empleado" OnClick="btnEmpleado_Click"  /> <br />

          <div>
            <a href="#">Crear cuenta</a> or <a href="#">reset password</a>
          </div>
          
        
        
        <div class="form-links">
          <a href="#">www.website.com</a>
        </div>
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
    </form>
</body>
</html>
