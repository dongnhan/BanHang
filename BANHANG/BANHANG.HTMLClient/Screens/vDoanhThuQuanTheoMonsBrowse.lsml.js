/// <reference path="~/GeneratedArtifacts/viewModel.js" />

myapp.vDoanhThuQuanTheoMonsBrowse.created = function (screen) {
    // Write code here.
    var tungay = new Date();
    tungay.setHours(0, 0, 0, 0)
    var denngay = new Date();
    denngay.setHours(0, 0, 0, 0)
    screen.Từ_ngày = tungay
    screen.Đến_ngày = denngay
};
myapp.vDoanhThuQuanTheoMonsBrowse.IN1_execute = function (screen) {
    // Write code here.
    window.open("http://192.168.1.38/ReportServer_SQLEXPRESS?%2fDoanhThuQuanTheoMon&rs:Command=Render&tungay=" + screen.Từ_ngày.format("yyyy-MM-dd") + "&denngay=" + screen.Đến_ngày.format("yyyy-MM-dd") + "&rs:Format=PDF", '_blank');
};