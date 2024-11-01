// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


// Fade-in effect on page load
document.addEventListener("DOMContentLoaded", function () {
    const header = document.querySelector(".header-section");
    header.style.opacity = 1;
});

// Background color change on hover
const header = document.querySelector(".header-section");
header.addEventListener("mouseover", function () {
    header.style.background = "linear-gradient(135deg, #34ace0, #ffb142)";
});
header.addEventListener("mouseout", function () {
    header.style.background = "linear-gradient(135deg, #6a89cc, #b8e994)";
});

// Line Chart
var ctxLine = document.getElementById("lineChart").getContext("2d");
var lineChart = new Chart(ctxLine, {
    type: "line",
    data: {
        labels: ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep"],
        datasets: [
            {
                label: "Penerimaan",
                data: [120, 200, 150, 170, 210, 250, 300, 280, 330],
                borderColor: "#007bff",
                fill: false,
            },
            {
                label: "Pengeluaran",
                data: [80, 100, 120, 130, 160, 180, 210, 220, 240],
                borderColor: "#dc3545",
                fill: false,
            },
        ],
    },
});

// Pie Chart
var ctxPie = document.getElementById("pieChart").getContext("2d");
var pieChart = new Chart(ctxPie, {
    type: "pie",
    data: {
        labels: ["Ibadah Mingguan", "Ibadah Rumah Tangga", "Other Sources"],
        datasets: [
            {
                data: [53, 27, 20],
                backgroundColor: ["#007bff", "#dc3545", "#ffc107"],
            },
        ],
    },
});
