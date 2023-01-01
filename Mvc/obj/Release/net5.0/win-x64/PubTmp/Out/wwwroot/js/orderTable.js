// ===================
function cancelOrder(id) {
    Swal.fire({
        title: 'Sipariş iptal edilecek. Emin misiniz?',
        text: "İptal işlemi geri alınamaz!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#d33',
        cancelButtonColor: '#3085d6',
        cancelButtonText: 'Vazgeç',
        confirmButtonText: 'Evet, iptal et!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                type: "POST",
                url: "/Order/CancelOrder/" + id,
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
function completeOrder(id) {
    Swal.fire({
        title: 'Siparişi teslim aldığınıza emin misiniz?',
        text: "İşlem geri alınamaz!",
        icon: 'success',
        showCancelButton: true,
        confirmButtonColor: '#228C22',
        cancelButtonColor: '#3085d6',
        cancelButtonText: 'Vazgeç',
        confirmButtonText: 'Evet, teslim aldım!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                type: "POST",
                url: "/Order/CompleteOrder/" + id,
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
function orderDetails(orderId) {
    $.ajax({
        url: '/Order/OrderDetails/?Id=' + orderId,
        success: function (data) {
            $('#orderDetailsModalPage').html(data);
            $('#orderDetailsModal').modal('show');
        }
    });
}