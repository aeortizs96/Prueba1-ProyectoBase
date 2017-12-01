﻿function templateRow() {
    var template = "<tr>";
    template += ("<td>" + "123" + "</td>");
    template += ("<td>" + "Jorge Junior" + "</td>");
    template += "</tr>";
    return template;
}


function addRow() {
    var template = templateRow();
    for (var i = 0; i < 10; i++) {
        $("#tbl_body_table").append(template);
    }
}


var tabla, data;

function addRowDT(data) {
    tabla = $("#tbl_pacientes").DataTable({
        "aaSorting": [[0, 'desc']],
        "bSort": true,
        "aoColumns": [
            null,
            null,
            { "bSortable": false }
        ]
    });

    tabla.fnClearTable();



    for (var i = 0; i < data.length; i++) {
        tabla.fnAddData([
            data[i].Id,
            data[i].Nombre,
            '<button type="button" value="Actualizar" title="Actualizar" class="btn btn-primary btn-edit" data-target="#imodal" data-toggle="modal"><i class="fa fa-check-square-o" aria-hidden="true"></i></button>&nbsp;' +
            '<button type="button" value="Eliminar" title="Eliminar" class="btn btn-danger btn-delete"><i class="fa fa-minus-square-o" aria-hidden="true"></i></button>'


        ]);
    }

}



function sendDataAjax() {
    $.ajax({
        type: "POST",
        url: "ListaCategoria.aspx/SelectAllCategoria",
        data: {},
        contentType: 'application/json; charset=utf-8',
        error: function (xhr, ajaxOptions, thrownError) {
            console.log(xhr.status + " \n" + xhr.responseText, "\n" + thrownError);
        },
        success: function (data) {
            addRowDT(data.d);
        }
    });
}

function updateDataAjax() {

    var obj = JSON.stringify({ id: JSON.stringify(data[0]), nombre: $("#txtNombre").val() });

    $.ajax({
        type: "POST",
        url: "ListaCategoria.aspx/ActualizarDatosCategoria",
        data: obj,
        dataType: "json",
        contentType: 'application/json; charset=utf-8',
        error: function (xhr, ajaxOptions, thrownError) {
            console.log(xhr.status + " \n" + xhr.responseText, "\n" + thrownError);
        },
        success: function (response) {
            if (response.d) {
                alert("Registro actualizado de manera correcta.");
            } else {
                alert("No se pudo actualizar el registro.");
            }
        }
    });
}

function deleteDataAjax(data) {

    var obj = JSON.stringify({ id: JSON.stringify(data) });

    $.ajax({
        type: "POST",
        url: "ListaCategoria.aspx/EliminarDatosCategoria",
        data: obj,
        dataType: "json",
        contentType: 'application/json; charset=utf-8',
        error: function (xhr, ajaxOptions, thrownError) {
            console.log(xhr.status + " \n" + xhr.responseText, "\n" + thrownError);
        },
        success: function (response) {
            if (response.d) {
                alert("Registro eliminado de manera correcta.");
            } else {
                alert("No se pudo eliminar el registro.");
            }
        }
    });
}

// evento click para boton actualizar
$(document).on('click', '.btn-edit', function (e) {
    e.preventDefault();//evita postback

    var row = $(this).parent().parent()[0];
    data = tabla.fnGetData(row);
    fillModalData();

});

// evento click para boton eliminar
$(document).on('click', '.btn-delete', function (e) {
    e.preventDefault();


    //primer método: eliminar la fila del datatble
    var row = $(this).parent().parent()[0];
    var dataRow = tabla.fnGetData(row);


    //segundo método: enviar el codigo del paciente al servidor y eliminarlo, renderizar el datatable
    // paso 1: enviar el id al servidor por medio de ajax
    deleteDataAjax(dataRow[0]);
    // paso 2: renderizar el datatable
    sendDataAjax();

});


// cargar datos en el modal
function fillModalData() {
    $("#txtNombre").val(data[1]);

}

// enviar la informacion al servidor
$("#btnactualizar").click(function (e) {
    e.preventDefault();
    updateDataAjax();
});

// Llamando a la funcion de ajax al cargar el documento
sendDataAjax();