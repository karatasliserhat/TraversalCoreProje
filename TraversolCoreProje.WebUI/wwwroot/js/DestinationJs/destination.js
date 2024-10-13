$(document).ready(function () {

    GetDestinations();
});
/* Read Data */
function GetDestinations() {

    $.ajax({

        url: "/Admin/AdminDestination/GetDestinations",
        type: "get",
        datatype: "json",
        contentType: "application/json;charset=utf-8",
        success: function (response) {
            if (response == null || response == undefined || response.length == 0) {

                var object = '';
                object += '<tr>';
                object += '<td colspan="7">' + 'Kayıtlı Rota Bulunamadı' + '</td>';
                object += '</tr>';
                $("#tblBody").html(object);
            }
            else {

                var object = '';
                var count = 0;
                $.each(response, function (index, item) {
                    count++;
                    object += '<tr>';
                    object += '<td>' + count + '</td>';
                    object += '<td>' + item.city + '</td>';
                    object += '<td>' + item.price + '</td>';
                    object += '<td>' + item.capacity + '</td>';
                    object += '<td>' + item.status + '</td>';
                    object += '<td><a class="btn btn-outline-info btn-sm" href="/Destination/DestinationDetail?dataId=' + item.dataProtect + '">Sitede Gör</a></td>';
                    object += '<td><a href="#" class="btn btn-outline-warning btn-sm" onclick="Edit(\'' + item.dataProtect + '\')"><i class="bx bx-edit-alt me-1"></i>Güncelle</a>|<a href="#" class="btn btn-outline-danger btn-sm" onclick="Delete(\'' + item.dataProtect + '\')"><i class="bx bx-trash me-1"></i>Sil</a></td>';
                    object += '</tr>';
                });
                $("#tblBody").html(object);
            }
        },
        error: function () {
            alert('Rota Verileri Okunamadı');
        }

    });
};
$('#btnAdd').click(function () {

    $("#DestinationModal").modal('show');
    $("#modalTitle").text('Rota Ekleme');
});
function HideModal() {

    ClearData();
    $("#DestinationModal").modal("hide");
}
/*Insert Destination*/
function Insert() {
    var result = Validate();
    if (result == false) {
        return false;
    }
    var formData = new Object();
    formData.id = $("#Id").val();
    formData.city = $("#City").val();
    formData.dayNight = $("#DayNight").val();
    formData.price = $("#Price").val();
    formData.image = $("#Image").val();
    formData.capacity = $("#Capacity").val();
    formData.coverImage = $("#CoverImage").val();
    formData.image2 = $("#Image2").val();
    formData.details1 = $("#Details1").val();
    formData.details2 = $("#Details2").val();
    formData.description = $("#Description").val();


    $.ajax({
        url: "/Admin/AdminDestination/Create",
        data: formData,
        type: "post",
        success: function (response) {


            if (response.success == false) {
                for (i = 0; i < response.errors.length; i++) {
                    $("#modelOnly").html(response.errors[i].errorMessage);
                };
            }
            else {

                HideModal();
                GetDestinations();
                alert(response);
            }
        },
        error: function () {
            alert("Rota Kaydedilemedi.");
        }
    });
};
function ClearData() {
    $("#City").val("");
    $("#DayNight").val("");
    $("#Price").val(0);
    $("#Image").val("");
    $("#Capacity").val(0);
    $("#CoverImage").val("");
    $("#Image2").val("");
    $("#Details1").val("");
    $("#Details2").val("");
    $("#Description").val("");
    $("#modelOnly").html("");

    $("#City").css("border-color", "green")
    $("#DayNight").css("border-color", "green")
    $("#Price").css("border-color", "green")
    $("#Image").css("border-color", "green")
    $("#Capacity").css("border-color", "green")
    $("#CoverImage").css("border-color", "green")
    $("#Image2").css("border-color", "green")
    $("#Details1").css("border-color", "green")
    $("#Details2").css("border-color", "green")
    $("#Description").css("border-color", "green")



};
function Validate() {
    var isValid = true;
    if ($("#City").val().trim() == "") {
        $("#City").css("border-color", "Red")
        isValid = false;
    }
    else {
        $("#City").css("border-color", "green")
    }
    if ($("#DayNight").val().trim() == "") {
        $("#DayNight").css("border-color", "Red")
        isValid = false;
    }
    else {
        $("#DayNight").css("border-color", "green")
    }
    if ($("#Price").val().trim() == 0) {
        $("#Price").css("border-color", "Red")
        isValid = false;
    }
    else {
        $("#Price").css("border-color", "green")
    }
    if ($("#Image").val().trim() == "") {
        $("#Image").css("border-color", "Red")
        isValid = false;
    }
    else {
        $("#Image").css("border-color", "green")
    }
    if ($("#Capacity").val().trim() == 0) {
        $("#Capacity").css("border-color", "Red")
        isValid = false;
    }
    else {
        $("#Capacity").css("border-color", "green")
    }
    if ($("#CoverImage").val().trim() == "") {
        $("#CoverImage").css("border-color", "Red")
        isValid = false;
    }
    else {
        $("#CoverImage").css("border-color", "green")
    }
    if ($("#Image2").val().trim() == "") {
        $("#Image2").css("border-color", "Red")
        isValid = false;
    }
    else {
        $("#Image2").css("border-color", "green")
    }
    if ($("#Details1").val().trim() == "") {
        $("#Details1").css("border-color", "Red")
        isValid = false;
    }
    else {
        $("#Details1").css("border-color", "green")
    }
    if ($("#Details2").val().trim() == "") {
        $("#Details2").css("border-color", "Red")
        isValid = false;
    }
    else {
        $("#Details2").css("border-color", "green")
    }
    if ($("#Description").val().trim() == "") {
        $("#Description").css("border-color", "Red")
        isValid = false;
    }
    else {
        $("#Description").css("border-color", "green")
    }

    return isValid;
};
$("#City").change(function () {
    Validate();
});
$("#DayNight").change(function () {
    Validate();
});
$("#Price").change(function () {
    Validate();
});
$("#Image").change(function () {
    Validate();
});
$("#Capacity").change(function () {
    Validate();
});
$("#CoverImage").change(function () {
    Validate();
});
$("#Image2").change(function () {
    Validate();
});
$("#Details1").change(function () {
    Validate();
});
$("#Details2").change(function () {
    Validate();
});
$("#Description").change(function () {
    Validate();
});

/*Edit*/
function Edit(dataProtect) {
    $.ajax({
        url: "/Admin/AdminDestination/Update?dataId=" + dataProtect,
        type: "get",
        contentType: "application/json;charset=utf-8",
        datatype: "json",
        success: function (response) {
            if (response == null || response == undefined) {
                alert('Rota bilgileri Okunamadı');
            } else if (response.lenght == 0) {
                alert('Gönderdiğiniz Id ye ait Rota Bulunamadı ');
            } else {
                $("#DestinationModal").modal('show');
                $("#modalTitle").text('Rota Güncelleme');
                $("#Save").css("display", "none");
                $("#Update").css("display", "block");

                $("#City").val(response.city);
                $("#Id").val(response.id);
                $("#DayNight").val(response.dayNight);
                $("#Price").val(response.price);
                $("#Image").val(response.image);
                $("#Capacity").val(response.capacity);
                $("#CoverImage").val(response.coverImage);
                $("#Image2").val(response.image2);
                $("#Details1").val(response.details1);
                $("#Details2").val(response.details2);
                $("#Description").val(response.description);

            }
        },
        error: function () {
            alert('Rota bilgileri Okunamadı');
        }
    });
}

/*Update Data */
function Update() {
    var result = Validate();
    if (result == false) {
        return false;
    }
    var formData = new Object();
    formData.id = $("#Id").val();
    formData.city = $("#City").val();
    formData.dayNight = $("#DayNight").val();
    formData.price = $("#Price").val();
    formData.image = $("#Image").val();
    formData.capacity = $("#Capacity").val();
    formData.coverImage = $("#CoverImage").val();
    formData.image2 = $("#Image2").val();
    formData.details1 = $("#Details1").val();
    formData.details2 = $("#Details2").val();
    formData.description = $("#Description").val();


    $.ajax({
        url: "/Admin/AdminDestination/Update",
        data: formData,
        type: "post",
        success: function (response) {


            if (response.success == false) {

                for (i = 0; i < response.errors.length; i++) {
                    $("#modelOnly").html(response.errors[i].errorMessage);
                };
            }
            else {
                HideModal();
                GetDestinations();
                alert(response);
            }
        },
        error: function () {
            alert("Rota Güncellenemedi.");
        }
    });
}

/*Delete Destination*/
function Delete(dataProtect) {


    swal({
        title: "Rota Silinecek?",
        text: "Rotayı Silmek İstediğinize Emin Misiniz?",
        icon: "warning",
        buttons: true,
        dangerMode: true,
    })
        .then((willDelete) => {
            if (willDelete) {

                $.ajax({

                    url: "/Admin/AdminDestination/Delete?dataId=" + dataProtect,
                    type: "post",
                    success: function (response) {
                        if (response == null || response == undefined) {
                            swal("Rota Silinemedi");
                        } else if (response.lenght == 0) {
                            swal("Silinecek Rota Bulunamadı.");
                        } else {
                            GetDestinations();
                            swal(response, {
                                icon: "success",
                            });
                        }
                    },
                    error: function () {
                        alert("Rota Silinemedi");
                    }
                });

            } else {
                swal("Rotayı Silmekten Vazgeçtiniz.");
            }
        });

}