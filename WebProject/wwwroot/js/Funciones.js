function Buscador() {

    var body = $('#body').val();



    $.ajax({
        type: "POST",
        url: '/Posts/ConsultPosts',
        data: {
            body: body,
        },
        dateType: 'json',
        success: function (response) {
           
            alert("Bn")


        },
        error: function (response) {
            alert("Bad")

        }
    });
}