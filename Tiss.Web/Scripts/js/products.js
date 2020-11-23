$("input#search").on('click', function () {

    clearTableBody();

    let load = '<tr><td colspan="3" align="center"><img src="/Gifs/load.gif" width="100" height="100" alt="Загрузка..."></td></tr>';
    $('tbody').append(load);

    $.ajax({
        type: "GET",
        url: "Home/GetAllProducts",
        success: function (data) {
            clearTableBody();
            $("tbody").html(data);
        }
    })
});

let clearTableBody = function () {
    $('tbody').empty();
}