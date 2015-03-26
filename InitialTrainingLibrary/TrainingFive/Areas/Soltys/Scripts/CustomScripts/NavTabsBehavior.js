$(function() {
    $('#mainTabPanel a').mouseover(function(e) {
        e.preventDefault();
        $(this).tab('show');
    });
})