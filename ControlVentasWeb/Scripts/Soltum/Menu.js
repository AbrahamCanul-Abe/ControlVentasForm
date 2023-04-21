var showmenu = true;
var showmenuAC = true;
var showContractMenu = true;
var MaxWidthMenu = 230;
var MinWidthMenu = 48;
var bodyPaddingleft = 25;
var reportMenu = false;
var accessMenu = false;
var contracMenu = false;

$(document).ready(function () {
    Selectedmenu();
    if (getCookie("menu") == "") {
        MenuCollapse();
    } else {
        if (getCookie("menu") == "true") {
            MenuShow();
        } else {
            MenuCollapse();
        }
    }

    $('#BurgerButton').click(function () {
        if (!showmenu)
            MenuShow();
        else
            MenuCollapse();
        addTrannsitions();
    })

    $("#btnOptions").click(function (event) {
        $("#optionsMenu").toggle();
        event.preventDefault();
    });

    $("#optionsMenu").hide();

    $("#reportMenu").hide();

    $("#accessMenu").hide();
    $("#contractMenu").hide();

    $("#openReportMenu").click(function () {
        //console.log(showmenu);
        if (showmenu) {
            $("#reportMenu").toggle('fast');
            reportMenu = !reportMenu;
            if (reportMenu)
                $('#card-Arrow-rpt').css("transform", "rotateZ(227deg)");
            else
                $('#card-Arrow-rpt').css("transform", "rotateZ(135deg)");
        } else {
            reportMenu = true;
            MenuShow();
        }
    });

    $("#openContractMenu").click(function () {
        if (showmenu) {
            $("#contractMenu").toggle('fast');
            contracMenu = !contracMenu;
            if (contracMenu)
                $('#card-Arrow-contract').css("transform", "rotateZ(227deg)");
            else
                $('#card-Arrow-contract').css("transform", "rotateZ(135deg)");
        } else {
            contracMenu = true;
            MenuShow();
        }
    });


    $("#openAccessMenu").click(function () {
        //console.log(showmenuAC);
        if (showmenu) {
            $("#accessMenu").toggle('fast');
            accessMenu = !accessMenu;
            if (accessMenu)
                $('#card-Arrow-ac').css("transform", "rotateZ(227deg)");
            else
                $('#card-Arrow-ac').css("transform", "rotateZ(135deg)");
        } else {
            accessMenu = true;
            MenuShow();
        }
    });

    $('#NotifyIcon').click(function () {
        $('#Notify-Content').html('<img src="/Images/Ajax-Preloader.gif" style="height: 100px;" />');
        //$('#Notify-Content').css("background-image", 'url("/Images/Ajax-Preloader.gif")');
        $("#winNotify").collapse("show");

        let baseUrl = '/Login.aspx';
        let URL = baseUrl + '/GetNotifycations';
        api_service.postWithParams(URL, {}, function (response) {
            if (response.d.Status === 200) {
                //setTimeout(function () {
                //    console.log(response.d.Data);
                //}, 2000);
                if (response.d.Data.length > 0) {
                    let dataContent = "";
                    $('#Notify-Content').html(dataContent);
                    for (const item of response.d.Data) {
                        dataContent = AddNotify(item.Title, item.Time, item.Body, item.Footer);
                        $('#Notify-Content').append(dataContent);
                    }
                } else {
                    $('#Notify-Content').html('<div class="Notify-Massage">No hay notificaciones</div>');
                }
            } else if (response.d.Status === 400) {
                //bootstrap_alert.warning(response.d.Message);
            } else {
                bootstrap_alert.error(response.d.Message);
                console.log(response.d.ErrorMessage);
            }
        });
    })

    $('#Background-winNotify').click(function () {
        $("#winNotify").collapse("hide");
    })
});

function MenuCollapse() {
    if (screen.width > 700) {
        $('#navbar_main').css("padding-left", MinWidthMenu + bodyPaddingleft);
        $('#bodyPage').css("padding-left", MinWidthMenu + bodyPaddingleft);
        $('#MenuMain').css("width", MinWidthMenu);
    } else {
        $('#navbar_main').css("padding-left", MinWidthMenu + 10);
        $('#bodyPage').css("padding-left", bodyPaddingleft);
        $('#MenuMain').css("width", "0px");
    }
    $(".card").addClass("cardtooltip");
    showmenu = false;
    //$("#reportMenu").hide('fast');
    HideSubmenus();
    setCookie("menu", "false", 1);
}

function MenuShow() {
    if (screen.width > 700) {
        $('#navbar_main').css("padding-left", MaxWidthMenu + bodyPaddingleft);
        $('#bodyPage').css("padding-left", MaxWidthMenu + bodyPaddingleft);
        $('#MenuMain').css("width", MaxWidthMenu);
    } else {
        $('#navbar_main').css("padding-left", MinWidthMenu + 10);
        $('#bodyPage').css("padding-left", bodyPaddingleft);
        $('#MenuMain').css("width", MaxWidthMenu);
    }
    $(".card").removeClass("cardtooltip");
    showmenu = true;
    //if (reportMenu) {
    //    $("#reportMenu").show('fast');
    //}
    //if (contracMenu) {
    //    $("#contractMenu").show('fast');
    //}
    //if (accessMenu) {
    //    $("#accessMenu").show('fast');
    //}
    setCookie("menu", "true", 1);
}


function HideSubmenus() {
    if (reportMenu) {
        $("#reportMenu").hide('fast');
        reportMenu = false;
        if (reportMenu)
            $('#card-Arrow-rpt').css("transform", "rotateZ(227deg)");
        else
            $('#card-Arrow-rpt').css("transform", "rotateZ(135deg)");
    }
    if (contracMenu) {
        $("#contractMenu").hide('fast');
        contracMenu = false;
        if (contracMenu)
            $('#card-Arrow-contract').css("transform", "rotateZ(227deg)");
        else
            $('#card-Arrow-contract').css("transform", "rotateZ(135deg)");
    }
    if (accessMenu) {
        $("#accessMenu").hide('fast');
        accessMenu = false;
        if (accessMenu)
            $('#card-Arrow-ac').css("transform", "rotateZ(227deg)");
        else
            $('#card-Arrow-ac').css("transform", "rotateZ(135deg)");
    }
}

function addTrannsitions() {
    $('#navbar_main').css("transition", "all 300ms ease");
    $('#bodyPage').css("transition", "all 300ms ease");
    $('#MenuMain').css("transition", "all 300ms ease");
}

function Selectedmenu() {
    var urlp = window.location.pathname;
    if (urlp.includes("/Expedientes.aspx")) {
        $("#Menu01").addClass("active");
    } else if (urlp.includes("/Documentos.aspx")) {
        $("#Menu02").addClass("active");
    } else if (urlp.includes("/ConfiguracionExpediente.aspx")) {
        $("#Menu03").addClass("active");
    } else if (urlp.includes("/Proveedores.aspx")) {
        $("#Menu04").addClass("active");
    } else if (urlp.includes("/Usuarios.aspx")) {
        $("#A1").addClass("active");
    } else if (urlp.includes("/ProfileProveedor.aspx")) {
        $("#A2").addClass("active");
    } else if (urlp.includes("/HistoricoDocumentosProveedor.aspx")) {
        $("#A3").addClass("active");
    } else if (urlp.includes("/Trabajadores.aspx")) {
        $("#Menu05").addClass("active");
    } else if (urlp.includes("Usuario1")) {
        $("#Menu06").addClass("active");
    } else if (urlp.includes("Usuario2")) {
        $("#Menu07").addClass("active");
    } else if (urlp.includes("/AutorizacionDocumentos.aspx")) {
        $("#Menu08").addClass("active");
    } else if (urlp.includes("/ValidaCFDINomina.aspx")) {
        $("#Menu09").addClass("active");
    } else if (urlp.includes("/DocumentosExpediente.aspx")) {
        $("#Menu10").addClass("active");
    } else if (urlp.includes("Usuario3")) {
        $("#Menu011").addClass("active");
    }
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
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}

function AddNotify(title, time, body, footer) {
    let content = `
        <div class="Card-Notify">
            <div class="Header-Notify">
                <div class="Title-Header-Notify">${title}</div>
                <div class="Time-Header-Notify">${time}</div>
            </div>
            <div class="Body-Notify">
                ${body}
            </div>
            <div class="Footer-Notify">${footer}</div>
        </div>
        `
    return content;
}