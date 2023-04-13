$(document).ready(function () {
    var baseUrl = '/Login.aspx';
    var baseUrl2 = '/PasswordReset.aspx';
    $('#btnLogin').click(function () {
        var URL = baseUrl + '/DoLogin';
        //console.log(URL);

        api_service.postWithParams(URL, getData(), function (response, data, object) {
            if (response.d.Status == 302) {
                $("#btnLogin").focus();
                bootstrap_alert.success(response.d.Message);
                window.location = response.d.Redirect;
            } else if (response.d.Status == 403) {
                bootstrap_alert.info(response.d.Message);
            } else if (response.d.Status == 400) {
                bootstrap_alert.warning(response.d.Message);
            } else {
                bootstrap_alert.error(response.d.Message);
                console.log(response.d.ErrorMessage);
            }
        });
    });

    $('#RemindPass').click(function () {
        console.log("RemindPass");
        $("#RemindMailPassDialog").fadeIn(500);
    });

    $('#btnSenEmail').click(function () {
        var URL = baseUrl + '/MailChangePass';
        var Email = $('#txtEmail').val()
        if (Email != "") {
            //console.log(Email);
            api_service.postWithParams(URL, { email: Email }, function (response) {
                if (response.d.Status == 200) {
                    $("#RemindMailPassDialog").fadeOut(500);
                    bootstrap_alert.success(response.d.Message);
                } else if (response.d.Status == 400) {
                    bootstrap_alert.warning(response.d.Message);
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
        var Pass = $('#txtPass').val()
        var RPass = $('#txtRPass').val()
        if (Pass != "" || RPass != "") {
            if (Pass == RPass) {
                //console.log(Email);
                api_service.postWithParams(URL, { Password: Pass, RPassword: RPass }, function (response) {
                    if (response.d.Status == 200) {
                        $("#PasswordResetSuccess").fadeIn(200);
                        bootstrap_alert.success(response.d.Message);
                    } else if (response.d.Status == 400) {
                        bootstrap_alert.warning(response.d.Message);
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
});

function getData() {
    return {
        user: $('#txtUser').val(),
        pass: $('#txtPassword').val(),
    };
}