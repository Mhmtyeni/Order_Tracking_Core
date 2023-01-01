// ===================
function noStockOrder(id) {
    Swal.fire({
        title: 'Stok olmadığına emin misiniz?',
        text: "İptal işlemi geri alınamaz!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#d33',
        cancelButtonColor: '#3085d6',
        cancelButtonText: 'Vazgeç',
        confirmButtonText: 'Evet, stok yok!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                type: "POST",
                url: "/Order/NoStockOrder/" + id,
                success: function (result) {
                    Swal.fire({
                        position: 'center',
                        icon: 'success',
                        title: 'Başarıyla iptal edilmiştir!',
                        showConfirmButton: false,
                        timer: 800
                    }).then(() => {
                    })
                },
                error: function (data) {
                }
            });
        }
    })
}
// ===================
function acceptOrder(id) {
    Swal.fire({
        title: 'Siparişi yüklediğinize emin misiniz?',
        text: "İşlem geri alınamaz!",
        icon: 'success',
        showCancelButton: true,
        confirmButtonColor: '#228C22',
        cancelButtonColor: '#3085d6',
        cancelButtonText: 'Vazgeç',
        confirmButtonText: 'Evet, yükledim!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                type: "POST",
                url: "/Order/AcceptOrder/" + id,
                success: function (result) {
                    Swal.fire({
                        position: 'center',
                        icon: 'success',
                        title: 'Başarıyla gönderilmiştir!',
                        showConfirmButton: false,
                        timer: 800
                    }).then(() => {
                    })
                },
                error: function (data) {
                }
            });
        }
    })
}


function orderDetails(orderId) {
    $.ajax({
        url: '/Order/OrderDetails/?Id=' + orderId,
        success: function (data) {
            $('#orderDetailsModalPage').html(data);
            $('#orderDetailsModal').modal();
        }
    });
}