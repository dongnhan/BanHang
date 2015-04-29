/// <reference path="~/GeneratedArtifacts/viewModel.js" />

myapp.AddEditChonMon1.Details_postRender = function (element, contentItem) {
    // Write code here.
    $("[data-ls-tap='tap:{data.shell.saveCommand.command}']").hide();
};
myapp.AddEditChonMon1.Mon_postRender = function (element, contentItem) {
    // Write code here.
    lsWire.list.enableMultiSelect(contentItem);
};
myapp.AddEditChonMon1.created = function (screen) {
    // Write code here.
    screen.ChonMon1.Ngày = new Date();
    screen.ChonMon1.Ngày_thực = new Date();
    msls.promiseOperation(CallGetUserName).then(function PromiseSuccess(PromiseResult) {
        // Set the result of the CallGetUserName function to the 
        // UserName of the entity
        screen.ChonMon1.UserName = PromiseResult;
    });
    //screen.ChonMon1.UserName = "admin";
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
function CallGetUserName(operation) {
    $.ajax({
        type: 'post',
        data: {},
        url: '../web/GetUserName.ashx',
        success: operation.code(function AjaxSuccess(AjaxResult) {
            operation.complete(AjaxResult);
        })
    });
}
myapp.AddEditChonMon1.LƯU2_execute = function (screen) {
    // Write code here.
    var list = screen.findContentItem("Mon");

    //var count = lsWire.list.selectedCount(list);

    var selected = lsWire.list.selected(list);

    //var text = "Món bạn đã chọn gồm \n\n";

    _.forEach(selected, function (item) {

        //text += item.Mã + " - " + item.Tên + "\n";
        var newChiTiet = screen.ChonMonChiTiets.addNew();
        newChiTiet.setMónItem(item);
        //var soluong = screen.SoLuongs.data[0];
        //newChiTiet.setSoLuong(soluong);
        //newChiTiet.SoLuong(1);
        newChiTiet.Số_lượng = 1
        newChiTiet.Giá = item.Giá;
        newChiTiet.Tiền_giảm = 0;
        newChiTiet.Thành_tiền = 0;
    });
    lsWire.list.selectAll(list, false);
    myapp.applyChanges().then(function success() {
        // If success.
           msls.showMessageBox("LƯU THÀNH CÔNG !!!", { title: "LƯU" });
               
    }, function fail(e) {
        // If error occurs,
        msls.showMessageBox(e.message, { title: e.title }).then(function () {
            // Cancel Changes
            window.location.reload();
        });
    });
    screen.closePopup();
};
myapp.AddEditChonMon1.ĐÓNG1_execute = function (screen) {
    // Write code here.
    screen.closePopup();
};
myapp.AddEditChonMon1.THÊM_MÓN_execute = function (screen) {
    // Write code here.
    $(window).one("popupcreate", function (e) {
        $(e.target).popup({
            positionTo: "window"
        });
    });
    screen.showPopup("Group");
};
myapp.AddEditChonMon1.ĐÓNG_execute = function (screen) {
    // Write code here.
    screen.closePopup();
};
myapp.AddEditChonMon1.LƯU1_execute = function (screen) {
    // Write code here.
    myapp.applyChanges().then(function success() {
              // If success.
        msls.showMessageBox("LƯU THÀNH CÔNG !!!", { title: "LƯU" });
               }, function fail(e) {
            // If error occurs,
            msls.showMessageBox(e.message, { title: e.title }).then(function () {
                // Cancel Changes
                window.location.reload();
            });
        });
    screen.closePopup();
};
myapp.AddEditChonMon1.XÓA_execute = function (screen) {
    // Write code here.
    screen.ChonMonChiTiets.deleteSelected();
    myapp.applyChanges().then(function success() {
            // If success.
        msls.showMessageBox("XÓA THÀNH CÔNG !!!", { title: "XÓA" });
           }, function fail(e) {
        // If error occurs,
        msls.showMessageBox(e.message, { title: e.title }).then(function () {
            // Cancel Changes
            window.location.reload();
        });
           });
    screen.closePopup();

};
myapp.AddEditChonMon1.LƯU_execute = function (screen) {
    // Write code here.
    screen.ChonMon1.details.refresh();
    screen.ChonMonChiTiets.refresh();
    myapp.applyChanges().then(function success() {
                // If success.
        msls.showMessageBox("LƯU THÀNH CÔNG !!!", { title: "LƯU" });
           }, function fail(e) {
        // If error occurs,
        msls.showMessageBox(e.message, { title: e.title }).then(function () {
            // Cancel Changes
            window.location.reload();
        });
           });
    screen.closePopup();
};