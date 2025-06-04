

$(function() {
    $("#list").load("/Home/List");
    
});

function ReturnToHome() {
    $("#returnButton").hide();
    $("#list").load("/Home/List");
}
