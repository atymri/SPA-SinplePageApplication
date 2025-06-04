
$("#showLable").html("مدیریت کاربران");
$("#ButtonHolder").html("<a class='btn btn-success' onclick='AddUserBtn()' id='btnAddNew'>افزودن کاربر جدید</a>");

$.getJSON("/Api/People",

    function (res) {
        $.each(res, function (key, val) {

            var content = "<tr id='tr_" + val.PersonID +"' >" +
                "<td>" + val.PersonID + "</td>" +
                "<td>" + val.PersonName + "</td>" +
                "<td>" + val.PersonFamily + "</td>" +
                "<td>" + val.PersonAge + "</td>" +
                "<td><a class='btn btn-danger btn-sm' onclick='deletePerson("+val.PersonID+")' >حذف</a>" +
                "<a class='btn btn-warning btn-sm' onclick='editPerson(" + val.PersonID +")' >ویرایش</a></td>" +
                "</tr>";


            $("#tableList").append(content);

        });

    });

function AddUserBtn() {
    $("#list").load("/Home/Add");
}

function deletePerson(id) {
    $.ajax({
        url: "/Api/People/" + id,
        type: "Delete",
        success: function() {
            $("#tr_" + id).addClass("text text-danger");
            $("#tr_" + id).hide('slow');
        },
        error: function(err) {
            alert(err);
        }
    });
}

function editPerson(id) {
    $("#list").load("/Home/Edit/" + id);
}