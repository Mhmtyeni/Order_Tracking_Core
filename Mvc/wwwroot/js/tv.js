"use strict";


var hrefId = window.location.href.split("/");
const lineid = hrefId[hrefId.length - 1];
getTable();
console.log(lineid);
var connection = new signalR.HubConnectionBuilder().withUrl("/orderHub").build();
connection.on("SendData", function (message) {
    if (message == "success") {
        getTable();
    }
});

connection.start().then(function () {
    console.log("connection started");
}).catch(function (err) {
    console.log("hata verdi");
});
function getTable() {
    var tbl = $('#dataTable');
    $.ajax({
        url: '/Tv/TvTable/' + lineid,
        method: "GET",
        contentType: "application/json",
        dataType: "html",
        success: function (data) {
            tbl.html(data);
        }
    });
}
