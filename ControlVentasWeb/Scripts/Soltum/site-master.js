$(document).ready(function () {
    $('#btnLoguear').click(function () {
        $('#modalPreviewSite').modal('show');
        //  hideUserData();
        //eraseCMBCompany();
        //loadCompanies();
        //insertInfoUser();
    });
});

/* Alerts */
var contMsgs = 0;

bootstrap_alert = function () { };
bootstrap_alert.warning = function (message) {
    $('#alert_placeholder').append(getDiv('warning', message));
    $('#alertMsg' + contMsgs)
        .show({ duration: 500, queue: true })
        .delay(5000)
        .hide({ duration: 200, queue: true });
};

bootstrap_alert.success = function (message) {
    $('#alert_placeholder').append(getDiv('success', message));

    $('#alertMsg' + contMsgs)
        .show({ duration: 500, queue: true })
        .delay(5000)
        .hide({ duration: 200, queue: true });
};

bootstrap_alert.error = function (message) {
    $('#alert_placeholder').append(getDiv('danger', message));

    $('#alertMsg' + contMsgs)
        .show({ duration: 500, queue: true })
        .delay(5000)
        .hide({ duration: 200, queue: true });
};

bootstrap_alert.info = function (message) {
    $('#alert_placeholder').append(getDiv('info', message));
    $('#alertMsg' + contMsgs)
        .show({ duration: 500, queue: true })
        .delay(11000)
        .hide({ duration: 200, queue: true });
};

function getDiv(type, message) {
    contMsgs++;
    let div = '<div id="alertMsg' + contMsgs + '" class="alert alert-' + type + ' alert dismissible alert-remove-margin" role="alert">'
        + '<a class="close" data-dismiss="alert">×</a>'
        + '<span>' + message + '</span></div>';
    return div;
}

/* Mask */
function loading_mask(show) {
    if (show) {
        $('body').addClass('body-mask');
        $('#loadingMask').show();
    } else {
        $('#loadingMask').hide();
        $('body').removeClass('body-mask');
    }
}

MessageBoxSys = function () { };

MessageBoxSys.Show = function (show, title, text) {
    $("#loadingMesageBoxTitle").empty();
    $("#loadingMesageBoxText").empty();
    if (show) {
        $("#loadingMesageBoxTitle").append(title);
        $("#loadingMesageBoxText").append(text);
        $('body').addClass('body-mask');
        $('#loadingMesageMask').show();
    } else {
        $('#loadingMesageMask').hide();
        $('body').removeClass('body-mask');
    }
};

//*******************   DialogMessageBoxSys   ************************
DialogMessageBoxSys = function () { };
DialogMessageBoxSys.Show = function (show, title, text, showBtnLink, btntext, btnLink) {
    //console.log(show, title, text, showBtnLink, btntext, btnLink);
    $("#modalDialogMessageboxTitle").empty();
    $("#modalDialogMessageboxText").empty();

    if (showBtnLink) {
        $("#btnModalDialogMessageboxLink").text(btntext);
        $("#btnModalDialogMessageboxLink").attr("href", btnLink);
        $("#btnModalDialogMessageboxLink").show();
        //$("#btnModalDialogMessagebox").hide();
    }
    else {
        //$("#btnModalDialogMessagebox").html(btntext);
        //$("#btnModalDialogMessagebox").show();
        $("#btnModalDialogMessageboxLink").hide();
    }
    //console.log("step2");

    if (show) {
        $("#modalDialogMessageboxTitle").append(title);
        $("#modalDialogMessageboxText").append(text);
        $('#modalDialogMessagebox').modal('show');
        //console.log("show");

    } else {
        $('#modalDialogMessagebox').modal('hide');
        //console.log("hide");

    }
};


//MessageBoxSys.setTitle = function (title) {
//    $("#loadingMesageBoxTitle").append(title);
//}

//MessageBoxSys.setText = function (text) {
//    $("#loadingMesageBoxText").append(text);
//}

/* ApiService */
api_service = function () { };

api_service.get = function (url, successCallback) {
    //if (!url.includes('http:') && !url.includes('https:')) {
    //  url = api_class.getAbsolutePath + url;
    //}
    loading_mask(true);
    $.ajax({
        type: 'GET',
        url: url,
        //data: JSON.stringify(params),
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        async: true,
        success: function (response) {
            successCallback(response);
            loading_mask(false);
        },
        error: errorApiService
    });
};

api_service.getWithParams = function (url, params, successCallback) {
    loading_mask(true);
    $.ajax({
        type: 'GET',
        url: url + params.join('/'),
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        async: true,
        success: function (response) {
            successCallback(response);
            loading_mask(false);
        },
        error: errorApiService
    });
};

api_service.post = function (url, value, successCallback) {
    //if (!url.includes('http:') && !url.includes('https:')) {
    //  url = api_class.getAbsolutePath + url;
    //}
    loading_mask(true);
    $.ajax(url, {
        type: 'POST',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        async: true,
        data: JSON.stringify(value),
        success: function (response) {
            successCallback(response);
            loading_mask(false);
        },
        error: errorApiService
    });
};

api_service.postsys = function (url, value, successCallback) {
    $.ajax(url, {
        type: 'POST',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        async: true,
        data: JSON.stringify(value),
        success: function (response) {
            successCallback(response);
        },
        error: errorApiService
    });
};

api_service.postWithParams = function (url, params, successCallback) {
    loading_mask(true);
    $.ajax({
        type: 'POST',
        url: url,
        data: JSON.stringify(params),
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        async: true,
        success: function (response) {
            successCallback(response);
            loading_mask(false);
        },
        error: errorApiService
    });
};

api_service.postWithParamsWithoutLoadingMask = function (url, params, successCallback) {
    $.ajax({
        type: 'POST',
        url: url,
        data: JSON.stringify(params),
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        async: true,
        success: function (response) {
            successCallback(response);
        },
        error: errorApiService
    });
};

api_service.postWithOutParams = function (url, successCallback) {
    loading_mask(true);
    $.ajax({
        type: 'POST',
        url: url,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        async: true,
        success: function (response) {
            successCallback(response);
            loading_mask(false);
        },
        error: errorApiService
    });
};

api_service.put = function (url, value, successCallback) {
    loading_mask(true);
    $.ajax(url, {
        type: 'PUT',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        async: true,
        data: JSON.stringify(value),
        success: function (response) {
            successCallback(response);
            loading_mask(false);
        },
        error: errorApiService
    });
}
//Delete
api_service.delete = function (url, params, successCallback) {
    loading_mask(true);
    $.ajax({
        type: 'DELETE',
        url: url + params.join('/'),
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',

        async: true,
        success: function (response) {
            successCallback(response);
            loading_mask(false);
        },
        error: errorApiService
    });
}
//

api_service.getPaging = function (url, params, successCallback) {
    loading_mask(true);
    $.ajax(url, {
        type: 'POST',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        async: true,
        data: JSON.stringify(params),
        success: function (response) {
            successCallback(response);
            loading_mask(false);
        },
        error: errorApiService
    });
};

api_service.getPaging2 = function (url, params, successCallback) {
    loading_mask(true);
    var data = { filter: params };
    $.ajax(url, {
        type: 'POST',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        async: true,
        data: JSON.stringify(data),
        success: function (response) {
            successCallback(response.d);
            loading_mask(false);
        },
        error: errorApiService
    });
};

api_service.senData = function (url, params, successCallback) {
    loading_mask(true);
    var oReq = new XMLHttpRequest();
    oReq.open('POST', url, true);
    oReq.setRequestHeader('Content-Type', 'application/json; charset=utf-8');
    oReq.responseType = 'blob';
    oReq.onload = function (oEvent) {
        if (oEvent.srcElement.status === 200) {
        } else if (oEvent.srcElement.status === 300) {
            bootstrap_alert.error(oEvent.srcElement.statusText);
        } else {
            errorApiService();
        }
        loading_mask(false);
    };
    oReq.send(JSON.stringify(params));
};

/**Descarga de PDF de Ajax a C#*/
api_service.downloadDocument = function (url, params, extension) {
    loading_mask(true);
    var req = new XMLHttpRequest();
    req.open("POST", url, true);
    req.setRequestHeader('Content-Type', 'application/json; charset=utf-8');
    req.responseType = "blob";

    req.onload = function (event) {
        if (event.srcElement.status === 200) {
            var blob = req.response;
            var link = document.createElement('a');
            link.href = window.URL.createObjectURL(blob);
            link.download = getDocumentName(req, link.href, extension);
            link.click();
        } else if (event.srcElement.status === 300) {
            bootstrap_alert.error(event.srcElement.statusText);
        } else {
            errorApiService();
        }
        loading_mask(false);
    };

    if (params) {
        req.send(JSON.stringify(params));
    }
    else {
        req.send();
    }
};

/**Descarga de XML de Ajax a C#*/
api_service.downloadDocumentXML = function (url, params, resp) {
    loading_mask(true);
    var req = new XMLHttpRequest();
    req.open("POST", url, true);
    req.setRequestHeader('Content-Type', 'application/json; charset=utf-8');
    req.responseType = "blob";

    req.onload = function (event) {
        if (event.srcElement.status === 200) {
            var blob = req.response;
            //console.log(blob.size);
            var link = document.createElement('a');
            link.href = window.URL.createObjectURL(blob);
            link.ownerDocument.defaultView.window.name;
            link.download = resp.replace("blob:http://localhost:2303/", "") + ".xml";
            link.click();
        } else if (event.srcElement.status === 300) {
            bootstrap_alert.error(event.srcElement.statusText);
        } else {
            errorApiService();
        }
        loading_mask(false);
    };

    req.send(JSON.stringify(params));
};

api_service.getDocument = function (url, params, successCallback, errorCallback) {
    loading_mask(true);
    var oReq = new XMLHttpRequest();
    oReq.open('POST', url, true);
    oReq.setRequestHeader('Content-Type', 'application/json; charset=utf-8');
    oReq.responseType = 'blob';
    oReq.onload = function (oEvent) {
        if (oEvent.srcElement.status === 200) {
            var url = window.URL.createObjectURL(oReq.response);
            successCallback(url);
        } else if (oEvent.srcElement.status === 300) {
            bootstrap_alert.error(oEvent.srcElement.statusText);
        } else {
            errorApiService();
            errorCallback();
        }
        loading_mask(false);
    };
    if (params) {
        oReq.send(JSON.stringify(params));
    } else {
        oReq.send();
    }
};

function getDocumentName(request, link, extension) {
    if (request) {
        var content = request.getResponseHeader('Content-Disposition');
        if (content && content.includes('filename=')) {
            return content.substring(content.lastIndexOf('=') + 1);
        }
    } else {
        return link.href.substring(link.href.lastIndexOf('/') + 1) + extension;
    }
}

api_service.uploadDocument = function (baseUrl, files, successCallback) {
    loading_mask(true);
    var formData = new FormData();

    $.each(files, function (index, file) {
        formData.append('file', file, file.name);
    });

    var ajaxRequest = $.ajax({
        type: 'POST',
        url: baseUrl,
        contentType: false,
        processData: false,
        data: formData
    });

    ajaxRequest.done(function (xhr, textStatus) {
        if (textStatus === 'success') {
            if (successCallback) {
                successCallback({ Data: xhr.Data, Success: true });
            }
            loading_mask(false);
        } else {
            errorApiService(xhr);
        }
    });
};

api_service.uploadDocument2 = function (baseUrl, file, fileSession, successCallback, barprogress) {
    //loading_mask(true);
    var formData = new FormData();
    //formData.append('sessionName', fileSession);
    formData.append('file', file, file.name);

    var ajaxRequest = $.ajax({
        type: 'POST',
        url: baseUrl,
        contentType: false,
        processData: false,
        data: formData,
        xhr: function () {
            if (barprogress != undefined && barprogress != null) {
                barprogress.parentElement.style.display = "block";
                var textpercent = barprogress.parentElement.childNodes[0].nextSibling;
                textpercent.innerHTML = "<p>0%</p>";
                barprogress.style.width = "0%";
                var xhr = $.ajaxSettings.xhr();
                xhr.upload.onprogress = function (evt) {
                    if (evt.lengthComputable) {
                        var percentComplete = ((evt.loaded / evt.total) * 100).toFixed(2);
                        var elem = barprogress;
                        textpercent.innerHTML = "<p>" + percentComplete + " %</p>";
                        elem.style.width = percentComplete + "%";
                    }
                };
            }
            return xhr;
        }
    });

    ajaxRequest.done(function (xhr, textStatus) {
        if (textStatus === 'success') {
            if (successCallback) {
                successCallback({ Success: true });
            }
            //loading_mask(false);
        } else {
            errorApiService(xhr);
        }
        if (barprogress != undefined && barprogress != null) {
            //barprogress.parentElement.style.display = "none";
            //barprogress.style.width = "0%";
        }
    });
};

api_service.uploadDocumentWithName = function (baseUrl, files, filesName, successCallback) {
    loading_mask(true);
    var formData = new FormData();

    $.each(files, function (index, file) {
        formData.append(filesName[index], file, file.name);
    });

    var ajaxRequest = $.ajax({
        type: 'POST',
        url: baseUrl,
        contentType: false,
        processData: false,
        data: formData
    });

    ajaxRequest.done(function (xhr, textStatus) {
        if (textStatus === 'success') {
            if (successCallback) {
                successCallback({ Data: xhr.Data, Success: true });
            }
            loading_mask(false);
        } else {
            errorApiService(xhr);
        }
    });
};

api_service.uploadDocumentWithNameAndParam = function (baseUrl, files, filesName, params, successCallback) {
    loading_mask(true);
    var formData = new FormData();

    $.each(files, function (index, file) {
        formData.append(filesName[index], file, file.name);
    });

    // formData.append('testClass', params);

    var ajaxRequest = $.ajax({
        type: 'POST',
        url: baseUrl + '?data=' + JSON.stringify(params),
        contentType: false,
        processData: false,
        data: formData
    });

    ajaxRequest.done(function (xhr, textStatus) {
        if (textStatus === 'success') {
            if (successCallback) {
                successCallback({ Data: xhr.Data, Success: true });
            }
            loading_mask(false);
        } else {
            errorApiService(xhr);
        }
    });
};
api_service.uploadDocumentWithParamsPut = function (baseUrl, files, params, successCallback) {
    loading_mask(true);
    var formData = new FormData();

    $.each(files, function (index, file) {
        formData.append('file', file, file.name);
    });

    var ajaxRequest = $.ajax({
        type: 'PUT',
        url: baseUrl + '?data=' + JSON.stringify(params),
        contentType: false,
        processData: false,
        data: formData
    });

    ajaxRequest.done(function (xhr, textStatus) {
        if (textStatus === 'success') {
            if (successCallback) {
                successCallback({ Data: xhr.Data, Success: true });
            }
            loading_mask(false);
        } else {
            errorApiService(xhr);
        }
    });
};

api_service.uploadDocumentWithParams = function (baseUrl, files, params, successCallback) {
    loading_mask(true);
    var formData = new FormData();

    $.each(files, function (index, file) {
        formData.append('file', file, file.name);
    });

    var ajaxRequest = $.ajax({
        type: 'POST',
        url: baseUrl + '?data=' + JSON.stringify(params),
        contentType: false,
        processData: false,
        data: formData
    });

    ajaxRequest.done(function (xhr, textStatus) {
        if (textStatus === 'success') {
            if (successCallback) {
                successCallback({ Data: xhr.Data, Success: true });
            }
            loading_mask(false);
        } else {
            errorApiService(xhr);
        }
    });
};

function errorApiService(response) {
    //console.error(response);
    if (response && response.status == 500) {
        bootstrap_alert.error('Ha ocurrido un error en el servidor.');
    }
    loading_mask(false);
}
/****/

/* Grid */
var contGrid = 0;
data_grid = function () { };

data_grid.cargaComPago = function (tableId, arrayData, buttons) {
    $('#' + tableId).children('tbody').empty();//vacia el contenido de la tabla
    if (arrayData && arrayData.length) {
        var campos = [];
        //campos.push($("#" + tableId).children('thead').children('tr').children('th').append('olo'));
        $.each($("#" + tableId).children('thead').children('tr').children('th'), function (index, valor) {
            if (valor.attributes['data-field']) {
                campos.push({
                    campos: valor.attributes['data-field'].value,
                    css: valor.attributes['class'] ? valor.attributes['class'].value : ''
                });
            }
        });
        obtenValorArreglo(tableId, campos, arrayData, buttons);
    }
};

data_grid.cargaCFacturas = function (tableId, arrayData, buttons) {
    $('#' + tableId).children('tbody').empty();//vacia el contenido de la tabla
    if (arrayData && arrayData.length) {
        var campos = [];
        //campos.push($("#" + tableId).children('thead').children('tr').children('th').append('olo'));
        $.each($("#" + tableId).children('thead').children('tr').children('th'), function (index, valor) {
            if (valor.attributes['data-field']) {
                campos.push({
                    campos: valor.attributes['data-field'].value,
                    css: valor.attributes['class'] ? valor.attributes['class'].value : ''
                });
            }
        });
        obtenerValorArregloCF(tableId, campos, arrayData, buttons);
    }
};

function obtenerValorArregloCF(tablaId, campos, array, buttons) {
    //$('#' + tablaId).children('tbody').empty();//vacia el contenido de la tabla
    $.each(array, function (indicePropiedad, valorPropiedad) {
        $("#" + tablaId).append('<tr>');
        $.each(valorPropiedad, function (nombColumna, valorCelda) {
            if (nombColumna !== 'Motivo' && nombColumna !== 'ServParciales' && nombColumna !== 'MetodoPago') {
                if (valorCelda === 'Rechazada') {
                    var button = agregabtnRechazo(tablaId, indicePropiedad, 'btn btn-danger');
                    $('#' + tablaId).children('tbody').children('tr').last().append(button);
                } else if (valorCelda === 'PdteCarga') {
                    var button = agregabtnRechazo(tablaId, indicePropiedad, 'btn btn-secondary');
                    $('#' + tablaId).children('tbody').children('tr').last().append(button);
                }
                else {
                    if (valorCelda === 0) {
                        var content = '<td{{1}}>{{0}}</td>'.replace('{{0}}', 0).replace('{{1}}', ' class="' + campos[nombColumna, indicePropiedad] + '" style="text-align:center"');
                        $('#' + tablaId).children('tbody').children('tr').last().append(
                            content
                        );
                    } else {
                        var content = '<td{{1}}>{{0}}</td>'.replace('{{0}}', valorCelda ? valorCelda : '').replace('{{1}}', ' class="' + campos[nombColumna, indicePropiedad] + '" style="text-align:center"');
                        $('#' + tablaId).children('tbody').children('tr').last().append(
                            content
                        );
                    }
                }
            } else {
                var content = '<td{{1}} style="display: none">{{0}}</td>'.replace('{{0}}', valorCelda ? valorCelda : '').replace('{{1}}', ' class="' + campos[nombColumna, indicePropiedad] + '"');
                $('#' + tablaId).children('tbody').children('tr').last().append(
                    content
                );
            }
        });
        if (buttons && buttons.length) {
            addButton(buttons, tablaId, valorPropiedad);
        }
        $("#" + tablaId).append('</tr>');
    });
}

function agregabtnRechazo(tablaId, index, clase) {
    var dato = clase.replace('"', '').replace('btn', '').replace(' ', '').replace('-', '');
    if (dato === 'btnsecondary') {
        return '<td><center><button id=' + tablaId + '_btn_' + index +
            '" class="' + clase + '" type="button" title="Pendiente de Carga" onclick=""><i class="fas fa-exclamation-circle"></i> PdteCarga</button></center></td>';
    } else {
        return '<td><center><button id=' + tablaId + '_btn_' + index +
            '" class="' + clase + '" type="button" title="Ver Motivo de Rechazo" onclick="abrirMensjModRechazo(this)"><i class="fas fa-times-circle"></i> Rechazada</button></center></td>';
    }
}

data_grid.CargaHist = function (tableId, arrayData, buttons) {
    $('#' + tableId).children('tbody').empty();//vacia el contenido de la tabla
    if (arrayData && arrayData.length) {
        var campos = [];
        //campos.push($("#" + tableId).children('thead').children('tr').children('th').append('olo'));
        $.each($("#" + tableId).children('thead').children('tr').children('th'), function (index, valor) {
            if (valor.attributes['data-field']) {
                campos.push({
                    campos: valor.attributes['data-field'].value,
                    css: valor.attributes['class'] ? valor.attributes['class'].value : ''
                });
            }
        });
        obtenValorArreglo(tableId, campos, arrayData, buttons);
    }
};

data_grid.CargaSNCHK = function (tableId, arrayData, buttons) {
    $('#' + tableId).children('tbody').empty();//vacia el contenido de la tabla
    if (arrayData && arrayData.length) {
        var campos = [];
        //campos.push($("#" + tableId).children('thead').children('tr').children('th').append('olo'));
        $.each($("#" + tableId).children('thead').children('tr').children('th'), function (index, valor) {
            if (valor.attributes['data-field']) {
                campos.push({
                    campos: valor.attributes['data-field'].value,
                    css: valor.attributes['class'] ? valor.attributes['class'].value : ''
                });
            }
        });
        obtenValorArreglo(tableId, campos, arrayData, buttons);
    }
};

data_grid.load = function (tableId, arrayData, buttons, checks, paginationId, pagination) {
    loading_mask(true);
    addPaginationInfo(paginationId, arrayData, pagination);

    $('#' + tableId).children('tbody').empty();
    if (arrayData && arrayData.length) {
        var dataSearch = $('#' + tableId).children('thead').children('tr')[0].attributes['data-search'];
        if (dataSearch) {
            $('#' + tableId).children('tbody').append('<tr>');
            $('#' + tableId).children('tbody').append('</tr>');

            $.each($('#' + tableId).children('thead').children('tr').children('th'), function (index, value) {
                if (value.attributes['data-field']) {
                    addDataSearch(tableId, dataSearch, value, index, arrayData, buttons, checks, paginationId, pagination);
                } else {
                    addField(tableId, {}, {});
                }
            });
        }

        var dataSort = $('#' + tableId).children('thead').children('tr')[0].attributes['data-sort'];
        if (dataSort) {
            $.each($('#' + tableId).children('thead').children('tr').children('th'), function (index, value) {
                if (value.attributes['data-sortable']) {
                    addSortColumn(tableId, arrayData, value, index, buttons, checks);
                }
            });
        }

        addDataGrid(tableId, arrayData, buttons, checks);
    }
    loading_mask(false);
};

function addPaginationInfo(paginationId, arrayData, pagination) {
    if (paginationId && $('#' + paginationId)) {
        $('#' + paginationId).html('Mostrando <strong>&nbsp;' + (arrayData ? arrayData.length : 0) + '&nbsp;</strong> elementos de <strong>&nbsp;' + (pagination ? pagination.size : 0) + '</strong>');
    }
}

function addDataGrid(tableId, arrayData, buttons, checks) {
    var fields = [];

    $.each($('#' + tableId).children('thead').children('tr').children('th'), function (index, value) {
        if (value.attributes['data-field']) {
            var field = {
                field: value.attributes['data-field'].value,
                css: value.attributes['class'] ? value.attributes['class'].value : '',
                isCheck: value.attributes['data-field-check'] ? true : false,
                isButton: value.attributes['data-field-button'] ? true : false,
                isFormatDate: value.attributes['data-field-date-format'] ? true : false
            };

            if (field.isButton) {
                field.buttonData = {
                    fieldToCompare: getAttributeValue(value, 'data-field-button'),
                    text: getAttributeValue(value, 'data-field-button-text'),
                    hideText: getAttributeValue(value, 'data-field-button-text-hide'),
                    icon: getAttributeValue(value, 'data-field-button-icon'),
                    tooltip: getAttributeValue(value, 'data-field-button-tooltip'),
                    event: getAttributeValue(value, 'data-field-button-event'),
                    css: getAttributeValue(value, 'data-field-button-css'),
                    callBack: getAttributeValue(value, 'data-field-button-callback'),
                    compareTo: getAttributeValue(value, 'data-field-button-visible-on'),
                    condition: getAttributeValue(value, 'data-field-button-condition')
                };
            }

            fields.push(field);
        }
    });
    getValueFromArray(tableId, fields, arrayData, buttons, checks);
    addFunctionSelectAll(tableId);
}

function addSortColumn(tableId, arrayData, value, index, buttons, checks) {
    var sortId = tableId + '_sort-icon_' + index;
    value.innerHTML = '<div class="table-sort-div">' + value.textContent + ' <div id="' + tableId + '_div-sort_' + index + '" class="float-lg-right table-sort"><i id="' + sortId + '" class="fa fa-sort" aria-hidden="true"></i></div></div>'
    var id = tableId + '_sort_' + index + '_' + Date.now();
    if (value.id) {
        $('#' + value.id).off('click');
    }

    value.style.cursor = 'pointer';
    value.id = id;
    var dataSort = $('#' + tableId).children('thead').children('tr')[0].attributes['data-sort'];
    var dataField = value.attributes['data-field'];
    var isDate = value.attributes['data-field-date-format'] ? true : false;

    $('#' + id).on('click', function () {
        loading_mask(true);
        if (dataSort && dataSort.value == 'local') {
            if (dataField) {
                var ignoreStr = value.attributes['data-sortable-ignore'] ? value.attributes['data-sortable-ignore'].value : '';
                var typeSort = value.attributes['data-sortable-is'] ? value.attributes['data-sortable-is'].value : '';

                $.each($('#' + tableId).children('thead').children('tr').children('th'), function (index, value) {
                    if (value.attributes['data-sortable'] && value.attributes['data-field'] && value.id != id) {
                        value.children[0].children[0].children[0].className = 'fa fa-sort';
                    }
                });

                var filter = [];

                if ($('#' + sortId)[0].className == 'fa fa-sort' || $('#' + sortId)[0].className == 'fa fa-sort-down') {
                    $('#' + sortId)[0].className = 'fa fa-sort-up';
                    filter = sortArrayAsc(arrayData, dataField.value, isDate, ignoreStr, typeSort);
                } else {
                    $('#' + sortId)[0].className = 'fa fa-sort-down';
                    filter = sortArrayDesc(arrayData, dataField.value, isDate, ignoreStr, typeSort);
                }

                $.each($('#' + tableId).children('thead').children('tr').children('th'), function (index, value) {
                    if ($('#' + tableId).children('thead').children('tr')[0].attributes['data-search'] && value.attributes['data-sortable']) {
                        filter = filterAll(filter, value, tableId, index);
                    }
                });

                $('#' + tableId).find('tr:gt(1)').remove();
                addDataGrid(tableId, filter, buttons, checks);
            }
        } else {
            // window[dataSearch.value]($('#' + tableId + '_sort_' + index).val()); // Agregar para ir al servidor
        }
        loading_mask(false);
    });
}

function sortArrayAsc(array, field, isDate, ignoreStr, typeSort) {
    array.sort((a, b) => {
        var compareA = !isDate ? a[field] : transformBackDate(a[field], true);
        var compareB = !isDate ? b[field] : transformBackDate(b[field], true);

        if (ignoreStr) {
            compareA = compareA.replace(ignoreStr, '').trim();
            compareB = compareB.replace(ignoreStr, '').trim();
        }

        if (typeSort) {
            compareA = transformSort(compareA, typeSort);
            compareB = transformSort(compareB, typeSort);
        }

        if (compareA < compareB) {
            return -1;
        }
        if (compareA > compareB) {
            return 1;
        }

        return 0;
    });

    return array;
}

function sortArrayDesc(array, field, isDate, ignoreStr, typeSort) {
    array.sort((a, b) => {
        var compareA = !isDate ? a[field] : transformBackDate(a[field], true);
        var compareB = !isDate ? b[field] : transformBackDate(b[field], true);

        if (ignoreStr) {
            compareA = compareA.replace(ignoreStr, '').trim();
            compareB = compareB.replace(ignoreStr, '').trim();
        }

        if (typeSort) {
            compareA = transformSort(compareA, typeSort);
            compareB = transformSort(compareB, typeSort);
        }

        if (compareA > compareB) {
            return -1;
        }
        if (compareA < compareB) {
            return 1;
        }

        return 0;
    });

    return array;
}

function transformSort(value, typeSort) {
    if (typeSort == 'number') {
        return +value;
    }

    if (typeSort == 'date') {
        return new Date(value);
    }

    return value;
}

function getAttributeValue(value, attr) {
    return value.attributes[attr] ? value.attributes[attr].value : '';
}

function obtenValorArreglo(tablaId, campos, array, buttons) {
    //    $('#' + tablaId).children('tbody').empty();//vacia el contenido de la tabla
    $.each(array, function (indicePropiedad, valorPropiedad) {
        $("#" + tablaId).append('<tr>');
        $.each(valorPropiedad, function (nombColumna, valorCelda) {
            if (nombColumna !== 'Motivo') {
                if (valorCelda === 'Rechazada') {
                    var button = agregaBotonRechazo(tablaId, indicePropiedad, 'btn btn-danger', valorCelda,
                        'Ver Motivo de Rechazo.', 'fas fa-times-circle');
                    $('#' + tablaId).children('tbody').children('tr').last().append(button);
                } else if (valorCelda === 'PdteAutorizar') {
                    var button = agregaBotonRechazo(tablaId, indicePropiedad, 'btn btn-warning', valorCelda,
                        valorCelda, 'fas fa-file-alt');
                    $('#' + tablaId).children('tbody').children('tr').last().append(button);
                } else if (valorCelda === 'PdteCarga') {
                    var button = agregaBotonRechazo(tablaId, indicePropiedad, 'btn btn-secondary', valorCelda,
                        valorCelda, 'fas fa-exclamation-circle');
                    $('#' + tablaId).children('tbody').children('tr').last().append(button);
                } else if (valorCelda === 'Autorizada') {
                    var button = agregaBotonRechazo(tablaId, indicePropiedad, 'btn btn-info', valorCelda,
                        valorCelda, 'fas fa-check-circle');
                    $('#' + tablaId).children('tbody').children('tr').last().append(button);
                } else if (valorCelda === 'Pagada') {
                    var button = agregaBotonRechazo(tablaId, indicePropiedad, 'btn btn-success', valorCelda,
                        'Ver Datos de Pagada.', 'fas fa-dollar-sign');
                    $('#' + tablaId).children('tbody').children('tr').last().append(button);
                } else if (valorCelda === 'Terminada') {
                    var button = agregaBotonRechazo(tablaId, indicePropiedad, 'btn btn-primary', valorCelda,
                        'Ver Datos de Pago', 'fab fa-font-awesome-flag');
                    $('#' + tablaId).children('tbody').children('tr').last().append(button);
                } else {
                    var content = '<td{{1}}>{{0}}</td>'.replace('{{0}}', valorCelda ? valorCelda : '').replace('{{1}}', ' class="' + campos[nombColumna, indicePropiedad] + '" style="text-align:center"');
                    $('#' + tablaId).children('tbody').children('tr').last().append(
                        content
                    );
                }
            } else {
                var content = '<td{{1}} style="display: none">{{0}}</td>'.replace('{{0}}', valorCelda ? valorCelda : '').replace('{{1}}', ' class="' + campos[nombColumna, indicePropiedad] + '"');
                $('#' + tablaId).children('tbody').children('tr').last().append(
                    content
                );
            }
        });
        if (buttons && buttons.length) {
            addButton(buttons, tablaId, valorPropiedad);
        }
        $("#" + tablaId).append('</tr>');
    });
}

function agregaBotonRechazo(tablaId, index, clase, valor, titulo, icono, valorPropiedad, baseUrl) {
    var dato = clase.replace('"', '').replace('btn', '').replace(' ', '').replace('-', '');
    if (dato !== 'btndanger' && dato !== 'btnsuccess' && dato !== 'btnprimary') {
        return '<td><center><button id=' + tablaId + '_btn_' + index +
            '" class="' + clase + '" type="button" title="' + titulo +
            '"><i class="' + icono + '" aria-hidden="true"></i> ' + valor +
            '</button></center></td>';
    } if (dato === 'btnsuccess') {
        return '<td><center><button id=' + tablaId + '_btn_' + index +
            '" class="' + clase + '" type="button" title="' + titulo +
            '" onclick="abrirDatosPagada(this)"><i class="' + icono +
            '" aria-hidden="true"></i> ' + valor +
            '</button></center></td>';
    } if (dato === 'btnprimary') {
        return '<td><center><button id=' + tablaId + '_btn_' + index +
            '" class="' + clase + '" type="button" title="' + titulo +
            '" onclick="abrirDatosPagada(this)"><i class="' + icono +
            '" aria-hidden="true"></i> ' + valor +
            '</button></center></td>';
    } else {
        return $('<td><center><button id=' + tablaId + '_btn_' + index +
            '" class="' + clase + '" type="button" title="' + titulo +
            '" ><i class="' + icono +
            '" aria-hidden="true"></i> ' + valor + '</button></center></td>').click(function () {
                document.getElementById('txtMotivoRech').value = (valorPropiedad === '') ? 'No hay Motivo Ingresado' :
                    (valorPropiedad === null) ? 'No hay Motivo Ingresado.' : valorPropiedad;
                $("#modalRechazo").modal('show');
            });
        //return '<td><center><button id=' + tablaId + '_btn_' + index +
        //    '" class="' + clase + '" type="button" title="' + titulo +
        //    '" onclick="abrirMensjModRechazoCarg(this)"><i class="' + icono +
        //    '" aria-hidden="true"></i> ' + valor + '</button></center></td>';
    }
}

function getValueFromArray(tableId, fields, array, buttons, checks) {
    var trFormatId = 'tr_' + tableId + '_';
    var trId = '';

    var dataRow = $('#' + tableId).children('thead').children('tr')[0].attributes['data-row'] ? true : false;
    var dataRowStyle = $('#' + tableId).children('thead').children('tr')[0].attributes['data-row-style'] ? $('#' + tableId).children('thead').children('tr')[0].attributes['data-row-style'].value.split(',') : '';
    var dataRowField = $('#' + tableId).children('thead').children('tr')[0].attributes['data-row-field'] ? $('#' + tableId).children('thead').children('tr')[0].attributes['data-row-field'].value : '';
    var dataRowCondition = $('#' + tableId).children('thead').children('tr')[0].attributes['data-row-condition'] ? $('#' + tableId).children('thead').children('tr')[0].attributes['data-row-condition'].value.split(',') : '';
    var dataRowVisibleOn = $('#' + tableId).children('thead').children('tr')[0].attributes['data-row-visible-on'] ? $('#' + tableId).children('thead').children('tr')[0].attributes['data-row-visible-on'].value.split(',') : '';

    $.each(array, function (iObject, object) {
        trId = trFormatId + iObject;

        $('#' + tableId).children('tbody').append('<tr id="{{0}}">'.replace('{{0}}', trId));
        $('#' + tableId).children('tbody').append('</tr>');

        $.each(fields, function (index, value) {
            var valorCelda = object[value.field];

            if (value.field === 'Check') {
                addSelect(tableId, object, iObject, (checks ? checks.callBack : undefined));
            } else if (value.isCheck) {
                addCheck(tableId, value, object, iObject);
            } else if (value.isButton && valorCelda !== 'RECHAZADO') {
                addButtonGrid(tableId, value, object, iObject);
            } else if (value.field === 'Estatus') {
                var indicePropiedad = iObject;
                var MotivoRech = object["Observaciones"];
                if (valorCelda === 'RECHAZADO') {
                    var button = agregaBotonRechazo(tableId, indicePropiedad, 'btn btn-danger', valorCelda, "Ver Motivo de Rechazo", 'fas fa-file-alt', MotivoRech);
                    $('#' + tableId).children('tbody').children('tr').last().append(button);
                } else {
                    var button = agregaBotonRechazo(tableId, indicePropiedad, 'btn btn-warning', valorCelda, valorCelda, 'fas fa-file-alt');

                    $('#' + tableId).children('tbody').children('tr').last().append(button);
                }
            } else if (value.isFormatDate) {
                addDateFormat(tableId, value, object);
            } else {
                if (dataRow) {
                    for (var iRow = 0; iRow < dataRowVisibleOn.length; iRow++) {
                        if (!dataRowCondition || !dataRow[iRow] || dataRowCondition[iRow] == 'equals') {
                            if (dataRowVisibleOn[iRow] == object[dataRowField]) {
                                $('#' + trId).addClass(dataRowStyle[iRow]);
                            }
                        } else if (dataRowCondition[iRow] == 'contains') {
                            if (object[dataRowField].toString().includes(dataRowVisibleOn[iRow])) {
                                $('#' + trId).addClass(dataRowStyle[iRow]);
                            }
                        }
                    }
                }

                addField(tableId, value, object);
            }
        });

        if (buttons && buttons.length) {
            if ($('#' + tableId).children('thead').children('tr')[0].attributes['data-group-buttons']) {
                addGroupButton(buttons, tableId, object);
            } else {
                addButton(buttons, tableId, object);
            }
        }
    });
}

function addCheck(tableId, value, object, iObject) {
    var id = tableId + '_' + value.field + '_chk_' + iObject;
    $('#' + tableId).children('tbody').children('tr').last().append('<td class="table-checkbox-custom">{{0}}</td>'.replace('{{0}}',
        '<input type="checkbox" id="' + id + '" />'
    ));

    $('#' + id).attr("disabled", true);
    $('#' + id).prop('checked', object[value.field]);
}

function addButtonGrid(tableId, value, object, iObject) {
    var compares = value.buttonData.compareTo.split(',')
        , icons = value.buttonData.icon.split(',')
        , tooltips = value.buttonData.tooltip.split(',')
        , styles = value.buttonData.css.split(',')
        , callbacks = value.buttonData.callBack.split(',')
        , texts = value.buttonData.text.split(',')
        , index
        , condition = value.buttonData.condition.split(',');

    for (var i = 0; i < compares.length; i++) {
        if (object[value.buttonData.fieldToCompare] && isButtonToShow(object[value.buttonData.fieldToCompare].toString(), compares[i], condition[i])) {
            index = i;
            break;
        }
    }

    if (object[value.buttonData.fieldToCompare] && isButtonToShow(object[value.buttonData.fieldToCompare].toString(), compares[index], condition[index])) {
        var id = tableId + '_' + value.field + '_btn_' + iObject;
        var button = '<div style="text-align: center;"><button style="{{5}}" id="{{0}}" type="button" class="{{1}} btn-grid"{{2}}>{{3}}{{4}}</button></div>'
            .replace('{{0}}', id)
            .replace('{{1}}', styles[index])
            .replace('{{2}}', tooltips[index] ? ' data-toggle="tooltip" data-placement="top" title="{{0}}"'.replace('{{0}}', tooltips[index]) : '')
            .replace('{{4}}', texts[index] ? texts[index] : (value.buttonData.hideText ? '' : ' ' + object[value.field]))
            .replace('{{3}}', icons[index] ? '<i class="float-left {{0}}"></i>'.replace("{{0}}", icons[index]) : '')
            .replace('{{5}}', value.buttonData.hideText ? '' : 'width:100%;');

        $('#' + tableId).children('tbody').children('tr').last().append('<td>{{0}}</td>'.replace('{{0}}', button));

        if (value.buttonData.event && callbacks[index]) {
            $('#' + id).on(value.buttonData.event, function () {
                window[callbacks[index]](object);
            });
        }
    } else {
        addField(tableId, value, object);
    }
}

function isButtonToShow(value, compareTo, condition) {
    if (!condition || condition == 'equals') {
        if (value == compareTo) {
            return true;
        }
    } else if (condition == 'contains') {
        if (value.includes(compareTo)) {
            return true;
        }
    } else if (condition == 'no-contains') {
        if (!value.includes(compareTo)) {
            return true;
        }
    }

    return false;
}

function addSelect(tableId, data, index, callBack) {
    $('#' + tableId).children('tbody').children('tr').last().append('<td class="table-checkbox-custom">{{0}}</td>'.replace('{{0}}',
        '<input type="checkbox" id="' + tableId + '_chk_' + index + '" />'
    ));

    $('#' + tableId + '_chk_' + index).on('change', function (evt) {
        if (callBack) {
            callBack(this.checked, index, data);
        }
    });
}

function addDateFormat(tableId, value, object) {
    $('#' + tableId).children('tbody').children('tr').last().append(
        '<td{{1}} style="text-align:center">{{0}}</td>'.replace('{{0}}', (object[value.field] || object[value.field] === 0) ? transformBackDate(object[value.field], true) : '')
            .replace('{{1}}', value.css ? ' class="' + value.css + '"' : '')
    );
}

function addDataSearch(tableId, dataSearch, value, index, arrayData, buttons, checks, paginationId, pagination) {
    var dataHide = value.className.includes('d-none') ? value.className : '';

    $('#' + tableId).children('tbody').children('tr').last().append('<td class="{{1}}">{{0}}</td>'.replace('{{0}}',
        '<input type="text" class="txtSearch form-control" id="' + tableId + '_input_' + index + '" />'
    ).replace('{{1}}', dataHide));

    $('#' + tableId + '_input_' + index).keyup(function (e) {
        if (e.keyCode === 13) {
            if (dataSearch.value === 'local') {
                var filter = arrayData;
                $.each($('#' + tableId).children('thead').children('tr').children('th'), function (index, value) {
                    if (value.attributes['data-sortable']) {
                        filter = filterAll(filter, value, tableId, index);
                    }
                });

                /*var filter = $.grep(arrayData, function (d) {
                    var search = $('#' + tableId + '_input_' + index).val();

                    if (value.attributes['data-field-date-format']) {
                        return transformBackDate(d[value.attributes['data-field'].value], true).includes(search);
                    }

                    return d[value.attributes['data-field'].value].toString().includes(search);
                });*/

                $('#' + tableId).find('tr:gt(1)').remove();
                addPaginationInfo(paginationId, filter, pagination);
                addDataGrid(tableId, filter, buttons, checks);
            } else {
                window[dataSearch.value]($('#' + tableId + '_input_' + index).val());
            }
        }
    });
}

function filterAll(array, value, tableId, index) {
    return $.grep(array, function (d) {
        var search = $('#' + tableId + '_input_' + index).val();

        if (value.attributes['data-field-date-format']) {
            return transformBackDate(d[value.attributes['data-field'].value], true).includes(search);
        }

        return d[value.attributes['data-field'].value].toString().toLowerCase().includes(search.toLowerCase());
    });
}

function addField(tableId, value, object) {
    var val = value.field;

    if (val === 'TipoUsuario') {
        var valUser = object[value.field];
        var tipoUser = '';
        if (valUser === 0) { tipoUser = 'Proveedor'; }
        if (valUser === 1) { tipoUser = 'Administrador'; }
        if (valUser === 2) { tipoUser = 'Operativo'; }

        $('#' + tableId).children('tbody').children('tr').last().append(
            '<td{{1}} style="text-align:center">{{0}}</td>'.replace('{{0}}', tipoUser)
                .replace('{{1}}', value.css ? ' class="' + value.css + '" ' : ''));
    } else {
        $('#' + tableId).children('tbody').children('tr').last().append(
            '<td{{1}} style="text-align:center">{{0}}</td>'.replace('{{0}}', (object[value.field] || object[value.field] === 0) ? object[value.field] : '')
                .replace('{{1}}', value.css ? ' class="' + value.css + '"' : '')
        );
    }
}

function addFunctionSelectAll(tableId) {
    var $table = $('#' + tableId);
    $table.find("thead th:nth-child(1) input[type='checkbox']")
        .on("change", function () {
            if ($(this).is(":checked")) {
                $table.find("tbody td:nth-child(1) input[type='checkbox']:not(:disabled):not(:checked)").prop("checked", true).trigger("change");
            } else {
                $table.find("tbody td:nth-child(1) input[type='checkbox']:not(:disabled):checked").prop("checked", false).trigger("change");
            }
        })
        .end().find("tbody tr")
        .on("click", function () {
            /*var $checkbox = $(this).find("td:nth-child(1) input[type='checkbox']:not(:disabled)");
            $checkbox.prop("checked", !$checkbox.is(":checked")).trigger("change");*/
        })
        .end()
        .find("tbody td:nth-child(1) input[type='checkbox']")
        .on("change", function () {
            var $uncheckedCheckboxes = $(this).closest("tbody").find("td:nth-child(1) input[type='checkbox']:not(:disabled):not(:checked)"),
                isCheckedAll = $uncheckedCheckboxes.length === 0;

            $table.find("thead th:nth-child(1) input[type='checkbox']").prop("checked", isCheckedAll);
        })
        .trigger("change")
        .end()
        .find("tbody td a,input[type='checkbox']")
        .on("click", function (e) {
            e.stopPropagation();
        })
        .end();
}

function addButton(buttons, tableId, object) {
    var actions = '';
    var buttonsId = [];
    var botonesHabilitados = 0;
    $.each(buttons, function (index, value) {
        if (index <= 1) {
            var id = ++contGrid;
            buttonsId.push(tableId + '_btn_' + id);
            botonesHabilitados += 1;
            actions += '<button id="{{0}}" type="button" class="btn btn-sm btn-secondary btn-grid"{{2}}>{{1}}</button>'
                .replace('{{0}}', buttonsId[index])
                .replace('{{1}}', value.text ? value.text : (value.icon ? '<i class="{{0}}"></i>'.replace("{{0}}", value.icon) : ''))
                .replace('{{2}}', value.tooltip ? ' data-toggle="tooltip" data-placement="top" title="{{0}}"'.replace('{{0}}', value.tooltip) : '');
        } else if (object.ServiciosParciales !== null && object.ServiciosParciales !== '0') {
            var id = ++contGrid;
            botonesHabilitados += 1;
            buttonsId.push(tableId + '_btn_' + id);
            actions += '<button id="{{0}}" type="button" class="btn btn-sm btn-secondary btn-grid"{{2}}>{{1}}</button>'
                .replace('{{0}}', buttonsId[index])
                .replace('{{1}}', value.text ? value.text : (value.icon ? '<i class="{{0}}"></i>'.replace("{{0}}", value.icon) : ''))
                .replace('{{2}}', value.tooltip ? ' data-toggle="tooltip" data-placement="top" title="{{0}}"'.replace('{{0}}', value.tooltip) : '');
        }
    });

    var tamanio = (botonesHabilitados * 45);
    var tamnioColumna;
    if ($('#botons').length) {
        tamnioColumna = document.getElementById('botons').style.width.replace('px', '');
    } else { tamanio = 0; }

    if (tamanio > tamnioColumna) {
        document.getElementById('botons').style.width = tamanio + 'px';
    }

    $('#' + tableId).children('tbody').children('tr').last().append('<td>{{0}}</td>'.replace('{{0}}', actions));

    $.each(buttons, function (index, value) {
        $('#' + buttonsId[index]).click(function () {
            value.callBack(object);
        });
    });
}

function addGroupButton(buttons, tableId, object) {
    var button =
        '<div class="dropdown">' +
        '<button class="btn btn-secondary dropdown-toggle" type="button" id="dropdownMenuButton" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">' +
        '<i class="fas fa-align-justify"></i>' +
        '</button >' +
        '<div class="dropdown-menu dropdown-menu-right dropdown-menu-sm-left" aria-labelledby="dropdownMenuButton">{0}</div> ';

    var action = '<a id="{2}" class="dropdown-item" href="#">{3}{1}</a>';
    var actions = '';
    var buttonsId = [];

    $.each(buttons, function (index, value) {
        var id = ++contGrid;
        buttonsId.push(tableId + '_btn_' + id);
        actions += action.replace('{1}', value.text).replace('{2}', buttonsId[index]).replace('{3}', value.icon ? '<i class="{{0}}"></i> '.replace('{{0}}', value.icon) : '');
    });

    $('#' + tableId).children('tbody').children('tr').last().append('<td>{{0}}</td>'.replace('{{0}}', button.replace('{0}', actions)));

    $.each(buttons, function (index, value) {
        $('#' + buttonsId[index]).click(function () {
            value.callBack(object);
        });
    });
}
/* Validator */
$.validator.addMethod('valueNotEquals', function (value, element, arg) {
    return arg !== value;
}, 'Este campo es obligatorio');

$.validator.addMethod('lettersOnly', function (value, element) {
    return this.optional(element) || /^[a-z \u00C0-\u00FF]+$/i.test(value);
}, 'Este campo sólo acepta letras');

$.validator.addMethod('emailOnly', function (value, element) {
    return this.optional(element) || /^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$/i.test(value);
}, 'El correo electrónico es inválido');
/*************/
/* Format data */
data_transform = function () { };

data_transform.backDate = function (value) {
    if (!value) {
        return value;
    }
    return transformBackDate(value);
};

function transformBackDate(value, withHours) {
    if (value.indexOf('Date') !== -1) {
        let date = new Date(parseInt(value.replace("/Date(", "").replace(")/", ""), 10));
        let format = date.getFullYear() + '-' + (date.getMonth() + 1) + '-' + (date.getDate().length === 1 ? '0' + date.getDate() : date.getDate());

        if (withHours) {
            format += ' ' + date.getUTCHours() + ':' + date.getMinutes() + ':' + date.getSeconds();
        }

        return format;
    } else if (value.indexOf('T') !== -1) {
        return value.substring(0, value.indexOf('T'));
    }
    return value;
}
data_transform.ConvertNumber = function ConvertNumber(texto) {
    return texto.replace(/&#(\d{1,8});/g, function (m, ascii) {
        return String.fromCharCode(ascii);
    });
}

//select

data_select = function () { };

data_select.load = function (name, array) {
    $("#" + name).html("");
    var key = $("#" + name).attr("data-key");
    var value = $("#" + name).attr("data-value");
    $("#" + name).append('<option value="0">---Selecciona una opción---</option>');
    $.each(array, function (iObject, object) {
        $("#" + name).append('<option value="' + object[key] + '">' + object[value] + '</option>');
    });
}

data_select.loadDefault = function (name, array, Valuedefault) {
    $("#" + name).html("");
    var key = $("#" + name).attr("data-key");
    var value = $("#" + name).attr("data-value");
    $("#" + name).append('<option value="0">---Selecciona una opción---</option>');
    $.each(array, function (iObject, object) {
        $("#" + name).append('<option value="' + object[key] + '" ' + (object[key] == Valuedefault ? "selected" : " ") + ' >' + object[value] + '</option>');
    });
}

//FUNCOINES PARA LA CREACION DE COOKIES
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