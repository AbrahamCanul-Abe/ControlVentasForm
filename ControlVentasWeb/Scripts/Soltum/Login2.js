$(document).ready(function () {
    var baseUrl = '/Account/Login.aspx';
    var baseUrl2 = '/PasswordReset.aspx';
    $('#btnLogin').click(function () {
        //GetLocation();
        alert("Click al boton");
        console.log("Click Al botón");
        var URL = baseUrl + '/Authentication';
        console.log(URL);
        //MessageBoxSys.Show(true, 'Iniciando Sesión', 'Espere un momento por favor...');
        //api_service.postsys(URL, getData(), function (response, data, object) {
        //    console.log(response.d.Status);
        //    if (response.d.Status === 302) {
        //        $("#btnLogin").focus();
        //        setCookie('LastSessionLevel', response.d.Data, 120);
        //        bootstrap_alert.success(response.d.Message);
        //        window.location = response.d.Redirect;
        //    } else if (response.d.Status === 403) {
        //        bootstrap_alert.info(response.d.Message);
        //    } else if (response.d.Status === 400) {
        //        bootstrap_alert.warning(response.d.Message);
        //    } else if (response.d.Status === 409) {
        //        bootstrap_alert.warning(response.d.Message);
        //        console.log(response.d.ErrorMessage);
        //        console.log(response.d.Data);
        //    } else {
        //        console.log(response.d.ErrorMessage);
        //        bootstrap_alert.error(response.d.Message);
        //    }
        //    MessageBoxSys.Show(false, '', '');
        //});
    });

    $('#RemindPass').click(function () {
        console.log("RemindPass");
        $("#RemindMailPassDialog").fadeIn(500);
    });

    $('#btnSenEmail').click(function () {
        var URL = baseUrl + '/MailChangePass';
        var Email = $('#txtEmail').val();
        if (Email !== "") {
            //console.log(Email);
            api_service.postWithParams(URL, { email: Email }, function (response) {
                if (response.d.Status === 200) {
                    $("#RemindMailPassDialog").fadeOut(500);
                    bootstrap_alert.success(response.d.Message);
                } else if (response.d.Status === 400) {
                    bootstrap_alert.warning(response.d.Message);
                } else if (response.d.Status === 406) {
                    bootstrap_alert.info(response.d.Message);
                } else {
                    bootstrap_alert.error(response.d.Message);
                    console.log(response.d.ErrorMessage);
                }
            });
        } else
            bootstrap_alert.info("Ingrese un correo electrónico");
    });

    $('#btnResetPass').click(function () {
        var URL = baseUrl2 + '/ResetPassword';
        var Pass = $('#txtPass').val();
        var RPass = $('#txtRPass').val();
        if (Pass !== "" || RPass !== "") {
            if (Pass === RPass) {
                //console.log(Email);
                api_service.postWithParams(URL, { Password: Pass, RPassword: RPass }, function (response) {
                    if (response.d.Status === 200) {
                        $("#PasswordResetSuccess").fadeIn(200);
                        bootstrap_alert.success(response.d.Message);
                    } else if (response.d.Status === 400) {
                        bootstrap_alert.warning(response.d.Message);
                    } else if (response.d.Status === 406) {
                        bootstrap_alert.info(response.d.Message);
                    } else {
                        $("#PasswordResetError").fadeIn(500);
                        bootstrap_alert.error(response.d.Message);
                        console.log(response.d.ErrorMessage);
                    }
                });
            } else {
                bootstrap_alert.info("Los campos de contraseña no coinciden");
            }
        } else
            bootstrap_alert.info("Faltan campos por llenar");
    });

    $("#txtUser").keyup(function (event) {
        if (event.keyCode === 13) {
            $("#btnLogin").click();
        }
    });

    $("#txtPassword").keyup(function (event) {
        if (event.keyCode === 13) {
            $("#btnLogin").click();
        }
    });

    GetLocation();


    //***************** Codigo para ajustar logo *******************
    $('#logo').one('load', function () {
        // do stuff
        AdjustLogoLogin();
    }).each(function () {
        if (this.complete) {
            //$(this).load(); // For jQuery < 3.0 
            $(this).trigger('load'); // For jQuery >= 3.0 
        }
    });
});

function getData() {
    return {
        user: $('#txtUser').val(),
        pass: $('#txtPassword').val(),
        level: getCookie('LastSessionLevel')
    };
}

function AdjustLogoLogin() {
    //console.log("AdjustLogoLogin2");
    let x = $('#logo').height();
    //console.log(x);
    x = x / 2;
    //console.log(x);
    $('#logo').css('top', `calc(50% - ${x}px)`);
    console.log("Logo Ajustado");
}


function setCookie(cname, cvalue, exdays) {
    var d = new Date();
    d.setTime(d.getTime() + (exdays * 24 * 60 * 60 * 1000));
    var expires = "expires=" + d.toUTCString();
    document.cookie = cname + "=" + cvalue + ";" + expires + ";path=/";
}

function getCookie(cname) {
    var name = cname + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) === ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) === 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}