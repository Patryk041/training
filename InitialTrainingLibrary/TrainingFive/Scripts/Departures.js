

function readyHandler() {
    $("#ClientId").on('change', function (e) { ClientIdChange(e); });
}

function ClientIdChange(e) {

    var id = $("#ClientId > option:selected").attr("value");

    console.log('changed', e);
    //window.location.reload();
    $.ajax({
        url: 'http://localhost:51763/rider',
        data: 'ClientId=' + id,
        method: 'POST',
        success: GetForm
        }
        );
}

function GetForm(html) {
    //var html = $("#DeparturesForm").submit();
    var div = $("#formContainer");

    div.html(html);
    readyHandler();
}

$(document).ready(readyHandler);