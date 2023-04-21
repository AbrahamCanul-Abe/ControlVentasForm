$(document).ready(function () {
    $(document).on("click", ".observation", function () {
        var text = $(this).data("observation");
        var documentdate = $(this).data("documentdate");
        console.log(text);
        Swal.fire({
            title: documentdate,
            text: text,
            icon: 'info',
            confirmButtonText: 'Aceptar'
        });
    });
    gridDocumentosProveedor.PerformCallback('LoadGrid');

    $("#grid").show();

    $("#wizard").steps({
        headerTag: "h4",
        bodyTag: "section",
        transitionEffect: "fade",
        enableAllSteps: true,
        transitionEffectSpeed: 500,
        onStepChanging: function (event, currentIndex, newIndex) {
            if (newIndex === 1) {
                $('.steps ul').addClass('step-2');
            } else {
                $('.steps ul').removeClass('step-2');
            }
            if (newIndex === 2) {
                $('.steps ul').addClass('step-3');
            } else {
                $('.steps ul').removeClass('step-3');
            }

            if (newIndex === 3) {
                $('.steps ul').addClass('step-4');
                $('.actions ul').addClass('step-last');
            } else {
                $('.steps ul').removeClass('step-4');
                $('.actions ul').removeClass('step-last');
            }
            return true;
        },
        labels: {
            finish: "",
            next: "Siguiente",
            previous: "Finalizar"
        }
    });

    // Custom Steps Jquery Steps
    $('.wizard > .steps li a').click(function () {
        $(this).parent().addClass('checked');
        $(this).parent().prevAll().addClass('checked');
        $(this).parent().nextAll().removeClass('checked');
    });

    // Custom Button Jquery Steps
    $('.forward').click(function () {
        $("#wizard").steps('next');
    });

    $('.backward').click(function () {
        $("#wizard").steps('previous');
    });

    // Checkbox
    $('.checkbox-circle label').click(function () {
        $('.checkbox-circle label').removeClass('active');
        $(this).addClass('active');
    });

    $(".actions").hide();

    $("#customForm").submit(function (e) {
        e.preventDefault();
    });

    $("#btn-proveedor").click(function (e) {
        var nombrecomercial = $("#nombrecomercial").val();
        var calle = $("#calle").val();
        var noexterior = $("#noexterior").val();
        var nointerior = $("#nointerior").val();
        var colonia = $("#colonia").val();
        var localidad = $("#localidad").val();
        var municipio = $("#municipio").val();
        var estado = $("#estado").val();
        var pais = $("#pais").val();
        var cp = $("#cp").val();

        var json = {
            nombrecomercial: nombrecomercial,
            calle: calle,
            noexterior: noexterior,
            nointerior: nointerior,
            colonia: colonia,
            localidad: localidad,
            municipio: municipio,
            estado: estado,
            pais: pais,
            cp: cp
        };

        console.log(json);

        $.ajax("/web/PreAlta.aspx/SaveSupplier", {
            type: 'POST',
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            async: true,
            data: JSON.stringify(json),
            success: function (response) {
                $("#wizard").steps('next');
            },
            error: function (response) {
                alert("No se pueden guardar los datos");
            }
        });
        e.preventDefault();
    });
});

let onUploadDocument = function (s) {
    $("#modalUpload-name").html(s.cp_name);
    $("#modalUpload-periodo").html(s.cp_periodo);
    $("#modalUpload-clave").html(s.cp_clave);
    $('#modalUpload').modal('show');
    $("#validations-box").hide();
};

let UploadComplete = function (s, a) {
    let reasons = s.cp_reasons;
    gridValidationResult.PerformCallback('ReloadGrid');
    $("#validations-box").hide();
    if (reasons.length > 0) {
        $("#validations-box").show();
        return;
    }
};

let onEndCallbackGridDocumentosProveedor = function (s, a) {
    console.log(s);
    console.log(a);
    if (s.callbackCommand['0'] != 'CUSTOMBUTTON') {
        try {
            eval(s.cp_action + '(s, a);');
        } catch (err) { }
        return;
    }
    if (s.cp_view) {
        console.log('view');
        if (s.cp_hasFile) {
            console.log('loadDocument');
            onLoadDocument(s.cp_url, s.cp_numdoc);
        } else {
            Swal.fire({
                title: 'Info',
                text: 'No hay ningun documento cargado',
                icon: 'info',
                confirmButtonText: 'Aceptar'
            });
        }
    } else if (s.cp_redirect) {
        console.log('redirect');
        if (s.cp_hasFile) {
            console.log('download');
            window.open(s.cp_url, '_blank');
        } else {
            Swal.fire({
                title: 'Info',
                text: 'No hay ningun documento cargado',
                icon: 'info',
                confirmButtonText: 'Aceptar'
            });
        }
    } else if (s.cp_upload) {
        console.log('Cargar archivo');
        onUploadDocument(s);
    } else {
        console.log('Cargar archivo');
    }
};

let onCustomButtonClick = function (s, a) {
    console.log(s);
    console.log(a);
};