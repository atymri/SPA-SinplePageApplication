$(function () {
    $("#showLable").html("افزودن کاربر جدید");
    $("#returnButton").show();

    $("#btnAdd").click(function () {
        var person = {
            PersonName: $("#PersonName").val(),
            PersonFamily: $("#PersonFamily").val(),
            PersonAge: $("#PersonAge").val()
        };

        $.ajax({
            url: "/Api/People",
            type: "Post",
            data: person,
            success: function () {
                $("#list").load("/Home/List");
                $("#returnButton").hide();
            },
            error: function () {
                alert("خطای غیر منتظره");
            }
        });
    });
});