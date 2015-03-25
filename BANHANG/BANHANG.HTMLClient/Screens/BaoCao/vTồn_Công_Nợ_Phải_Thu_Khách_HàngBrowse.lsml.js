/// <reference path="~/GeneratedArtifacts/viewModel.js" />

myapp.vTồn_Công_Nợ_Phải_Thu_Khách_HàngBrowse.created = function (screen) {
    // Write code here.
    var d = new Date();
    var month = d.getMonth() + 1;
    var year = new Date().getFullYear();
    //var a = myapp.activeDataWorkspace.SalesManagerData.Thangs_SingleOrDefault(n);
    //screen.Thangs = a;
    myapp.activeDataWorkspace.BanHangData.Thang_SingleOrDefault(month).execute().then(function (result) {
        screen.Tháng = result.results[0];
    });
    myapp.activeDataWorkspace.BanHangData.Nam_SingleOrDefault(year).execute().then(function (result) {
        screen.Năm = result.results[0];

    });
    //screen.Khách_Hàng = screen.Khách_Hàng.data[0];
};