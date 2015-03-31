$(function() {
    $('#mainTabPanel a').mouseover(function(e) {
        e.preventDefault();
        $(this).tab('show');
    });

    $('#mainTabPanel a').click(function(e) {
        e.preventDefault();

        var $destination = $(this);

        if ($destination.hash === "#subskrypcja") {
            window.location.replace("~/Soltys/Subscriptions/Index");
        }
    });
});
