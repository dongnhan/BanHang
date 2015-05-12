/// <reference path="~/GeneratedArtifacts/viewModel.js" />

myapp.AddEditChonMon1.created = function (screen) {
    // Write code here.
    //screen.ChonMon1.Ngày = new Date();
    //screen.ChonMon1.Ngày_thực = new Date();
    if (screen.ChonMon1.Ngày == undefined && screen.ChonMon1.Ngày == null) {
        screen.ChonMon1.Ngày = new Date();
    }
    if (screen.ChonMon1.Ngày_thực == undefined && screen.ChonMon1.Ngày_thực == null) {
        screen.ChonMon1.Ngày_thực = new Date();
    }
    msls.promiseOperation(CallGetUserName).then(function PromiseSuccess(PromiseResult) {
        // Set the result of the CallGetUserName function to the 
        // UserName of the entity
        screen.ChonMon1.UserName = PromiseResult;
    });
    //screen.ChonMon1.Khách_hàng = "admin";
    if (screen.ChonMon1.Khách_hàng == undefined && screen.ChonMon1.Khách_hàng == null) {
        screen.ChonMon1.Khách_hàng = "Vãng lai";
    }
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
myapp.AddEditChonMon1.Mon_postRender = function (element, contentItem) {
    // Write code here.
    lsWire.list.enableMultiSelect(contentItem);
};
myapp.AddEditChonMon1.ShowGroup_Tap_execute = function (screen) {
    // Write code here.
    $(window).one("popupcreate", function (e) {
        $(e.target).popup({
            positionTo: "window"
        });
    });
    screen.showPopup("Group");
};
myapp.AddEditChonMon1.LƯU2_execute = function (screen) {
    // Write code here.
    screen.ChonMon1.details.refresh();
    screen.ChonMonChiTiets.refresh();
    myapp.commitChanges().then(function success() {
        window.alert("LƯU THÀNH CÔNG !");
    }, function fail(e) {
        window.alert("LƯU THẤT BẠI - CẦN LÀM TƯƠI LẠI !");
        //window.location.reload();
        myapp.cancelChanges();
    });
};
myapp.AddEditChonMon1.LƯU_execute = function (screen) {
    // Write code here.
    var list = screen.findContentItem("Mon");

    //var count = lsWire.list.selectedCount(list);

    var selected = lsWire.list.selected(list);

    //var text = "Món bạn đã chọn gồm \n\n";

    _.forEach(selected, function (item) {

        //text += item.Mã + " - " + item.Tên + "\n";
        var newChiTiet = screen.ChonMonChiTiets.addNew();
        newChiTiet.setMónItem(item);
        var soluong = screen.SoLuongs.data[0];
        newChiTiet.setSoLuong(soluong);
        //newChiTiet.SoLuong(1);
        newChiTiet.Số_lượng = 1
        newChiTiet.Giá = item.Giá;
        newChiTiet.Tiền_giảm = 0;
        newChiTiet.Thành_tiền = 0;
    });
    lsWire.list.selectAll(list, false);
    myapp.applyChanges().then(function success() {
        window.alert("LƯU THÀNH CÔNG !");
        //không đóng
        //screen.closePopup();
    }, function fail(e) {
        window.alert("LƯU THẤT BẠI - CẦN LÀM TƯƠI LẠI !");
        //window.location.reload();
        myapp.cancelChanges();
        screen.closePopup();
    });
};
myapp.AddEditChonMon1.LƯU_ĐÓNG_execute = function (screen) {
    // Write code here.
    var list = screen.findContentItem("Mon");

    //var count = lsWire.list.selectedCount(list);

    var selected = lsWire.list.selected(list);

    //var text = "Món bạn đã chọn gồm \n\n";

    _.forEach(selected, function (item) {

        //text += item.Mã + " - " + item.Tên + "\n";
        var newChiTiet = screen.ChonMonChiTiets.addNew();
        newChiTiet.setMónItem(item);
        var soluong = screen.SoLuongs.data[0];
        newChiTiet.setSoLuong(soluong);
        //newChiTiet.SoLuong(1);
        newChiTiet.Số_lượng = 1
        newChiTiet.Giá = item.Giá;
        newChiTiet.Tiền_giảm = 0;
        newChiTiet.Thành_tiền = 0;
    });
    lsWire.list.selectAll(list, false);
    myapp.applyChanges().then(function success() {
        window.alert("LƯU THÀNH CÔNG !");
        screen.closePopup();
    }, function fail(e) {
        window.alert("LƯU THẤT BẠI - CẦN LÀM TƯƠI LẠI !");
        //window.location.reload();
        myapp.cancelChanges();
        screen.closePopup();
    });
};
myapp.AddEditChonMon1.ĐÓNG_execute = function (screen) {
    // Write code here.
    screen.closePopup();
};
myapp.AddEditChonMon1.XÓA_execute = function (screen) {
    // Write code here.
    screen.ChonMonChiTiets.deleteSelected();
    myapp.applyChanges().then(function success() {
        window.alert("XÓA THÀNH CÔNG !");
        screen.closePopup();
    }, function fail(e) {
        window.alert("XÓA THẤT BẠI - CẦN LÀM TƯƠI LẠI !");
        //window.location.reload();
        myapp.cancelChanges();
        screen.closePopup();
    });
};
myapp.AddEditChonMon1.LƯU1_execute = function (screen) {
    // Write code here.
    myapp.applyChanges().then(function success() {
        window.alert("LƯU THÀNH CÔNG !");
        screen.closePopup();
    }, function fail(e) {
        window.alert("LƯU THẤT BẠI - CẦN LÀM TƯƠI LẠI !");
        //window.location.reload();
        myapp.cancelChanges();
        screen.closePopup();
    });
};
myapp.AddEditChonMon1.ĐÓNG1_execute = function (screen) {
    // Write code here.
    screen.closePopup();
};
myapp.AddEditChonMon1.Details_postRender = function (element, contentItem) {
    // Write code here.
    $("[data-ls-tap='tap:{data.shell.saveCommand.command}']").hide();
};
myapp.AddEditChonMon1.IN1_execute = function (screen) {
    // Write code here.
    window.open("http://192.168.1.38/ReportServer_SQLEXPRESS/Pages/ReportViewer.aspx?%2fPhieuTinhTien&rs:Command=Render&id=" + screen.ChonMon1.Id + "&rs:Format=PDF", '_blank');
};
myapp.AddEditChonMon1.TÌM_execute = function (screen) {
    // Write code here.
 
};