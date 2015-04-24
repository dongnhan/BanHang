/// <reference path="~/GeneratedArtifacts/viewModel.js" />

myapp.AddEditChonMon1.THEM_execute = function (screen) {
    // Write code here.

};
myapp.AddEditChonMon1.ChonMonChiTiets_selectedItem_postRender = function (element, contentItem) {
    // Write code here.
    $(element).parent().on("popupcreate", function (e) {
        $(e.target).popup({
            positionTo: "window",     // position the popup in the center of the browser window
            dismissible: false        // prevent the popup from being dismissable
        });
    });
};
myapp.AddEditChonMon1.THEM_Tap_execute = function (screen) {
    screen.ChonMonChiTiets.addNew();
    // Write code here.
    $(window).one("popupcreate", function (e) {
        $(e.target).popup({
            positionTo: "window"
        });
    });
    screen.showPopup("ChonMonChiTiets_selectedItem");
};
myapp.AddEditChonMon1.created = function (screen) {
    // Write code here.
    screen.ChonMon1.Ngày = new Date();
    screen.ChonMon1.Ngày_thực = new Date();
    screen.ChonMon1.UserName = "admin";
    //if (screen.ChonMon1.UserName == undefined && screen.ChonMon1.UserName == null) {
    //    screen.ChonMon1.UserName = screen.UserName;
    //}
    //Write code here.
    if (screen.ChonMon1.Đã_xóa == undefined && screen.ChonMon1.Đã_xóa == null) {
        screen.ChonMon1.Đã_xóa = 0;
    }
    if (screen.ChonMon1.In_phiếu == undefined && screen.ChonMon1.In_phiếu == null) {
        screen.ChonMon1.In_phiếu = 0;
    }
    if (screen.ChonMon1.Trạng_thái == undefined && screen.ChonMon1.Trạng_thái == null) {
        screen.ChonMon1.Trạng_thái = 0;
    }
    if (screen.ChonMon1.Giảm_giá == undefined && screen.ChonMon1.Giảm_giá == null) {
        screen.ChonMon1.Giảm_giá = 0;
    }

    if (screen.ChonMon1.Tiền_giảm == undefined && screen.ChonMon1.Tiền_giảm == null) {
        screen.ChonMon1.Tiền_giảm = 0;
    }
    if (screen.ChonMon1.Tổng_giảm == undefined && screen.ChonMon1.Tổng_giảm == null) {
        screen.ChonMon1.Tổng_giảm = 0;
    }
    if (screen.ChonMon1.Thành_tiền == undefined && screen.ChonMon1.Thành_tiền == null) {
        screen.ChonMon1.Thành_tiền = 0;
    }
    if (screen.ChonMon1.Tổng_tiền == undefined && screen.ChonMon1.Tổng_tiền == null) {
        screen.ChonMon1.Tổng_tiền = 0;
    }
};
myapp.AddEditChonMon1.CLOSE_execute = function (screen) {
    // Write code here.
    screen.closePopup();
};
myapp.AddEditChonMon1.LƯU_execute = function (screen) {
    // Write code here.
    return myapp.applyChanges().then(function () {
        window.alert("LƯU THÀNH CÔNG !");
        //myapp.showAddEditChonMon11();
        window.location.reload();
    });
};