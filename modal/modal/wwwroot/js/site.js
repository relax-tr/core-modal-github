//function OrtakDuzenle(ortakId) {

//    var url = '@Url.Action("Home", "Ortak")';
//    url += '/?Id=' + ortakId;
//    $(".modal-body").load(url);
//}

$(function () {
    $("body").on('click', '#btnEdit', function () {
        $("#MyPopup").modal("hide");
        var obj =    $(this).attr('data-id');

        $.ajax({
            url: 'Home/EditClient?id='+obj,
            data: JSON.stringify(obj),
            type: 'POST',
            dataType: 'html',
            contentType: "application/json; charset=utf-8",
            success: function (response) {
                $("#dvPartial").html(response);
                $("#MyPopup").modal("show");
            }
        });
    });
});