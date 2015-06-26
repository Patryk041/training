function readyHandler() {
    $("#confirmFilter").on('click', function() {
        //alert('dziala');

        var filter = $("#filter").val();

        $.ajax(
            {
                //url: '/api/people?surname=' + filter + '&',
                url: 'http://localhost:49602/api/people?surname=Kowalski',
                success: function(msg) { SuccessfullFilter(msg); }
            }
        );
    });
}

function SuccessfullFilter(msg) {
    console.log(msg);

    var div = $("#searchResults");
    div.html('');
    var result = '';

    for (var i = 0; i < msg.length; i++)
        for (var item in msg[i]) {
            result += '<span>' + msg[i][item] + '</span>';

        }
    console.log(result);
    div.html(result);
}

$(document).ready(readyHandler);