// Line Chart Pemasukan
var ctxLine = document.getElementById('chartpemasukan').getContext('2d');
var lineChart = new Chart(ctxLine, {
    type: 'line',
    data: {
        labels: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'],
        datasets: [{
            label: 'Penerimaan',
            data: [120, 200, 150, 170, 210, 250, 300, 280, 330, 350, 370, 400],
            borderColor: '#007bff',
            fill: false
        }]
    }
});

// Line Chart Pengeluaran
var ctxLine2 = document.getElementById('chartpengeluaran').getContext('2d');
var lineChart = new Chart(ctxLine2, {
    type: 'line',
    data: {
        labels: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'],
        datasets: [{
            label: 'Pengeluaran',
            data: [80, 100, 120, 130, 160, 180, 210, 220, 240, 260, 280, 300],
            borderColor: '#dc3545',
            fill: false
        }]
    }
});