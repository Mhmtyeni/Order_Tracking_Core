"use strict";

getTable();
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
        url: "/List/OrderTable",
        method: "GET",
        contentType: "application/json",
        dataType: "html",
        success: function (data) {
            tbl.html(data);
        }
    });
}
