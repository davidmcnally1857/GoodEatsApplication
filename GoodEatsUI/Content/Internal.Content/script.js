function openChat() {

    document.getElementById("Form").style.display = "block";

}

function showHelp() {

    setTimeout(function () {

        document.getElementById("hiddenchat").style.display = "block";



    }, 2000);

}

jQuery(function ($) {
    $(document).ajaxSend(function () {
        $("#overlay").fadeIn(300);
    });

    $('#button').click(function () {
        $.ajax({
            type: 'GET',
            success: function (data) {
                console.log(data);
            }
        }).done(function () {
            setTimeout(function () {
                $("#overlay").fadeOut(300);
            }, 500);
        });
    });
});