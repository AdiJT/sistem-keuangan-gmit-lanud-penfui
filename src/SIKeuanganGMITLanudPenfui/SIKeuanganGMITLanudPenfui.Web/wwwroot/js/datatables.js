"use strict";

$("[data-checkboxes]").each(function () {
    var me = $(this),
        group = me.data('checkboxes'),
        role = me.data('checkbox-role');

    me.change(function () {
        var all = $('[data-checkboxes="' + group + '"]:not([data-checkbox-role="dad"])'),
            checked = $('[data-checkboxes="' + group + '"]:not([data-checkbox-role="dad"]):checked'),
            dad = $('[data-checkboxes="' + group + '"][data-checkbox-role="dad"]'),
            total = all.length,
            checked_length = checked.length;

        if (role == 'dad') {
            if (me.is(':checked')) {
                all.prop('checked', true);
            } else {
                all.prop('checked', false);
            }
        } else {
            if (checked_length >= total) {
                dad.prop('checked', true);
            } else {
                dad.prop('checked', false);
            }
        }
    });
});

$("#table-1").dataTable({
    "columnDefs": [
        { "sortable": false, "targets": [2, 3] }
    ]
});
$("#table-2").dataTable({
    "columnDefs": [
        { "sortable": false, "targets": [0, 2, 3] }
    ],
    order: [[1, "asc"]] 

});
$('#save-stage').DataTable({
    "scrollX": true,
    stateSave: true
});
$('#table-akun').DataTable({
    columnDefs: [
        { "sortable": false, "targets": [2] } 
    ],
});
$('#table-akun-1').DataTable({
    dom: '<"row justify-content-between"lf><"row"B>rt<"bottom-wrapper"ip>', // Atur posisi elemen
    buttons: [
        'csv', 'excel', 'pdf', 'print' // Tombol ekspor
    ],
    columnDefs: [
        { "sortable": false, "targets": [2] } // Menonaktifkan pengurutan untuk kolom tertentu
    ],
    lengthMenu: [10, 25, 50, 100], // Opsi "Show entries"
});
$('#table-akun-2').DataTable({
    dom: '<"row justify-content-between"lf><"row"B>rt<"bottom-wrapper"ip>', 
    buttons: [
        'csv', 'excel', 'pdf', 'print' 
    ],
    columnDefs: [
        { "sortable": false, "targets": [2] } 
    ],
    lengthMenu: [10, 25, 50, 100], 
});
$('#table-akun-3').DataTable({
    dom: '<"row justify-content-between"lf><"row"B>rt<"bottom-wrapper"ip>',
    buttons: [
        'csv', 'excel', 'pdf', 'print' 
    ],
    columnDefs: [
        { "sortable": false, "targets": [2] } 
    ],
    lengthMenu: [10, 25, 50, 100], 
});
$('#table-akun-4').DataTable({
    dom: '<"row justify-content-between"lf><"row"B>rt<"bottom-wrapper"ip>', 
    buttons: [
        'csv', 'excel', 'pdf', 'print' 
    ],
    columnDefs: [
        { "sortable": false, "targets": [2] } 
    ],
    lengthMenu: [10, 25, 50, 100], 
});

$("#table-search").dataTable({
    "paging": false, 
    "info": true, 
    "ordering": true, 
    "searching": true, 
    "dom": '<"d-flex justify-content-center"f><t>'
});




//$('#tableExport').DataTable({
//    dom: 'Bfrtip',
//    buttons: [
//        'copy', 'csv', 'excel', 'pdf', 'print'
//    ]
//});

$('#tableExport').DataTable({
    dom: 'Bfrtip',
    buttons: [
        'csv', 'excel', 'pdf', 'print'
    ]
});
