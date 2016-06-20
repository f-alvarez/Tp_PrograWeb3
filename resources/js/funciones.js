/// <reference path="../../main/cocineros/eventos.asmx" />
/// <reference path="../../main/cocineros/eventos.asmx" />
function ShowPopup(index) {
    $(function () {
        $("#dialog").html("¿Esta seguro que desea cancerlar el evento?");
        $("#dialog").dialog({
            title: "Cancelacion de Evento",
            resizable: false,
            height: 200,
            modal: true,
            buttons: {
                "Confirmar": function (e) {
                    var dataToSend = JSON.stringify({ idEvento: index });
                    $.ajax({
                        type: "POST",
                        url: "/main/cocineros/eventos.asmx/Cancelar",
                        data: dataToSend,
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: function (result) {
                            if (!result.error) window.location.href = "/main/cocineros/cancelar.aspx";
                        },
                        error: function (result) {
                            $("#errorAjax").html("No se pudo cancelar el evento: " + result.status + ' ' + result.statusText);
                        }
                    });
                    $(this).dialog("close");
                },
                "Cancelar": function () {
                    $(this).dialog("close");
                }
            }
        });
    });
};