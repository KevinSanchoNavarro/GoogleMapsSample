var flagEnviar = 0;
var showed;
var inAddUserMode = false;
var inEditUserMode = false;

$(function () {

    $("#frmBusquedaPuntos").on("submit", function (e) {
        if (flagEnviar) {
            flagEnviar = 0;
        } else {
            e.preventDefault();
        }
    });

    $("#btnBuscar").on("click", function (e) {
        //fnRefrescar();
        flagEnviar = 1;
        $("#frmBusquedaPuntos").submit();
    });

    fnRefrescar();

});
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
function fnRefrescar() {
    var params = new Object();

    if ($("#ddlEstados").val() === "" || $("#ddlEstados").val() === null) {
        params.Estado = 0;
    } else {
        var estadoInt = parseInt($("#ddlEstados").val());
        if (isNaN(estadoInt)) {
            params.Estado = 0;
        } else {
            params.Estado = estadoInt;
        }
    }

    Get("Home/ListPuntosByEstado", params).done(function (response) {
        if (response.result === 0) {
            //Pinto los puntos en el mapa

        }
    });

}


