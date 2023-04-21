<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SOLTUM.Satelites.ControlDeCasas.Account.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>SOLTUM - Control de Casas - Login</title>    
    <link rel="icon" type="image/png" href="~/Images/FavIcon-Expediente.png" runat ="server" />
    <link href="content/soltum-login-2.css" rel="stylesheet" />
    <link href="/Content/Soltum/soltum-variables.css" rel="stylesheet" />
    <link href="~/Content/Soltum/soltum-main.css" rel="stylesheet" />
    <link href="/Content/Fonts/Fonts.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server">
            <Scripts>
                <asp:ScriptReference Path="~/Scripts/Global/jquery-3.4.1.min.js" />
                <asp:ScriptReference Path="~/Scripts/Global/jquery-ui.js" />
                <asp:ScriptReference Path="~/Scripts/Global/umd/popper.js" />
                <asp:ScriptReference Path="~/Scripts/Global/bootstrap.min.js" />
                <asp:ScriptReference Path="~/Scripts/Global/font-awsome.min.js" />

                <asp:ScriptReference Path="~/Scripts/Global/jquery.validate.min.js" />

                <asp:ScriptReference Path="~/Scripts/Soltum/site-master.js?v=2" />
                <asp:ScriptReference Path="~/Scripts/Soltum/Login2.js?v=3" />
                <asp:ScriptReference Path="~/Scripts/Soltum/GeoLocalization.js?v=1" />
            </Scripts>
        </asp:ScriptManager>
    </form>
    <div class="container">
        <div class="left-panel">
            <div class="img-panel">
  	            <img src="../Images/Expediente-Logo.png" />
  	        </div>
        </div>

        <div class="right-panel">
            <div class="login-Container">
                 <div class="logo-panel">
                <div class="logo-img">
                    <img runat="server" id="logo" src="https://soltumapps.com.mx/images/soltum-logo-favIcon.png" />
                </div>
	        </div>

            <div class="login-box">
                <form id="form" >
                    <div class="login-input">
                        <div class="input-field">
                            <label for="uname"><b>Usuario o correo</b></label>
                            <input type="text" id="txtUser" name="txtUser" value="" placeholder="Usuario" required="required" />
                        </div>
                        <div class="input-field">
                            <div><div style="float:left;"><label for="psw"><b>Contraseña</b></label></div> <div style="float:right;text-align:right;" ><label id="RemindPass">Olvide Contraseña</label></div></div>
                            <input type="password" id="txtPassword" name="txtPassword" value="" placeholder="Contraseña" required="required" />
                            <label><input type="checkbox" id="chkbox" value="first_checkbox" />Recordar</label>
                        </div>
                        <br/>
                        <input type="button" id="btnLogin" name="" class="login-button" value="Entrar"/>
                    </div>
                </form>
            </div>
            <div class="login-footer">
                <p>&copy;SOLTUM Tecnologia SA de CV. Todos los derechos reservados.</p>
                <p><a id="lblPrivacidad" href="#" target="_blank" runat="server">Aviso de Privacidad</a><a id="lblTerm" runat="server" hidden="hidden">Terminos de Uso</a></p>
            </div>
            </div>
        </div>
    </div>

    <%--AQUI VA EL RECUPERADOR DE PASSWORDS--%>

    <div id="RemindMailPassDialog" class="CustomDialog" style="display:none; ">
        <div class="backgroudDialog" onclick="$('#RemindMailPassDialog').fadeOut(500);">
        </div>
        <div class="DialogForm ResetDialog">
            <div class="header">
                <div>¿Olvidó su contraseña?</div>
                <div id="btnClose" class="btnClose" onclick="$('#RemindMailPassDialog').fadeOut(500);">x</div>
            </div>
            
            <div class="body">
                <div class="label1">Recuperación de contraseña</div>
                <div class="label2">Ingrese dirrección de correo electrónico, y encontraremos su cuenta</div>
                <input id="txtEmail" class="form-control input_pass" type="email" name="Email" value="" placeholder="Correo electrónico o Usuario" required="required"/>
                <div class="label3">Le enviaremos una solicitud de recuperación de contraseña al correo electrónico asociado con su cuenta</div>
            </div>
            <div class="footer">
                <input id="btnSenEmail" class="btn btn-primary" type="button" name="Send" value="Continuar"/>
            </div>
        </div>
    </div>

    <div id="loadingMask"></div>
    <div id="alert_placeholder" class="alert-container"></div>
    <div id="loadingMesageMask" class="loadingMesageMask">
        <div id="loadingMesageBox">
            <div id="loadingMesageBoxImage"><img src="#" alt="Alternate Text" /></div>
            <div id="loadingMesageBoxContent">
                <div id="loadingMesageBoxTitle">Espere un momento...</div>
                <div id="loadingMesageBoxText">Espere un momento, por favor. Desplegando información de CFDI.</div>
            </div>
        </div>
    </div>
</body>
</html>
