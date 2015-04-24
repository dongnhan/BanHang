/// <reference path="~/GeneratedArtifacts/viewModel.js" />
var UserName = null;
myapp.AddEditChonMon11.created = function (screen) {
    
    //msls.promiseOperation(CallGetUserName).then(function PromiseSuccess(PromiseResult) {
    //    // Set the result of the CallGetUserName function to the 
    //    // UserName of the entity
    //    screen.UserName = PromiseResult;
        
    //    //screen.ChonMon1.UserName = screen.Name;
    //});
    //if (screen.ChonMon1.UserName == undefined && screen.ChonMon1.UserName == null) {
    //    if (UserName == null) {
    //        window.alert("không" + screen.UserName);
    //    }
    //    else {
    //        window.alert("có" + screen.UserName);
    //        screen.ChonMon1.UserName = screen.UserName
    //    }
    //}
    //if (screen.UserName == null) {
       
    //}
    //else{
    //    screen.ChonMon1.UserName = screen.UserName;
    //}
    //}
    
    //}
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
    //if (UserName == undefined && UserName == null) {
        
        
};
//function CallGetUserName(operation) {
//    $.ajax({
//        type: 'post',
//        data: {},
//        url: '../web/GetUserName.ashx',
//        success: operation.code(function AjaxSuccess(AjaxResult) {
//            operation.complete(AjaxResult);
//        })
//    });
//}
myapp.AddEditChonMon11.Món_postRender = function (element, contentItem) {
    // Write code here.
    lsWire.list.enableMultiSelect(contentItem);
};
myapp.AddEditChonMon11.THÊM_execute = function (screen) {
    // Write code here.
    var list = screen.findContentItem("Món");

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
        //newChiTiet.Số_lượng = 1
        newChiTiet.Giá = item.Giá;
        newChiTiet.Tiền_giảm = 0;
        newChiTiet.Thành_tiền = 0;
    });
    lsWire.list.selectAll(list, false);
    //screen.ChonMons.Tiền_giảm = screen.ChonMons.Tiền_giảm - 0;
};
myapp.AddEditChonMon11.THÊM_ĐÓNG_execute = function (screen) {
    // Write code here.
    var list = screen.findContentItem("Món");

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
        //newChiTiet.Số_lượng = 1
        newChiTiet.Giá = item.Giá;
        newChiTiet.Tiền_giảm = 0;
        newChiTiet.Thành_tiền = 0;
    });
    lsWire.list.selectAll(list, false);
    screen.closePopup();
};
myapp.AddEditChonMon11.beforeApplyChanges = function (screen) {
    // Write code here.
    //screen.ChonMon1.Tiền_giảm = 0;
    //screen.ChonMon1.Tổng_giảm = 0;
    //screen.ChonMon1.Thành_tiền = 0;
    //screen.ChonMon1.Tổng_tiền = 0;
    //screen.ChonMon1.Tiền_giảm = screen.ChonMon1.Tiền_giảm - 0;
    //myapp.applyChanges();
    //screen.ChonMon1.details.refresh();
    
};
//myapp.AddEditChonMon11.REFRESH_execute = function (screen) {
//    // Write code here.
//    window.location.reload();
//};
myapp.AddEditChonMon11.THOÁT_execute = function (screen) {
    // Write code here.
    //return myapp.activeDataWorkspace.BanHangDataQuan
    // .saveChanges().then(function () {
    //     // Refresh the Customers
    //     //screen.ChonMons.refresh();
    //     //screen.ChonMons.selectedItem = screen.ChonMons.data[0];
    //     //screen.Chọn_Món_Chi_Tiết.refresh();
    //     //var list = screen.findContentItem("Món");
    //     //lsWire.list.selectAll(list, false);
    //     //window.alert("XÓA THÀNH CÔNG !");
    //     //window.location.reload();

    //     //screen.getChọn_Món_Chi_Tiết();
    //     screen.closePopup();
    // });
    //return myapp.activeDataWorkspace.BanHangDataQuan
    // .saveChanges().then(function () {
    //     screen.closePopup();
    // });
    //screen.ChonMon1.Tiền_giảm = screen.ChonMon1.Tiền_giảm - 0;
    //screen.ChonMon1.Tổng_giảm = screen.ChonMon1.Tổng_giảm - 0;
    screen.closePopup();
    //myapp.commitChanges().then(function success() {
    //     //If success.
    //    //msls.showMessageBox("Xóa thành công !!!", { title: "XÓA" });
    //}, function fail(e) {
        
    //        // If error occurs,
    //        msls.showMessageBox(e.message, { title: e.title }).then(function () {
    //            // Cancel Changes
    //            myapp.cancelChanges();
    //        });
    //    });
       

    };
myapp.AddEditChonMon11.LƯU_execute = function (screen) {
    // Write code here.
    screen.ChonMon1.details.refresh();
    screen.ChonMonChiTiets.refresh();
    //screen.ChonMon1.Tiền_giảm = screen.ChonMon1.Tiền_giảm - 0;
    return myapp.commitChanges().then(function () {
        window.alert("LƯU THÀNH CÔNG !");
        //myapp.showAddEditChonMon11();
    });
    //myapp.commitChanges().then(function success() {
    //     //If success.
    //    //msls.showMessageBox("Xóa thành công !!!", { title: "XÓA" });
    //}, function fail(e) {

    //        // If error occurs,
    //        msls.showMessageBox(e.message, { title: e.title }).then(function () {
    //            // Cancel Changes
    //            myapp.cancelChanges();
    //        });
    //    });
};
//myapp.AddEditChonMon11.XÓA_MÓN_execute = function (screen) {
//    // Write code here.
//    screen.ChonMonChiTiets.deleteSelected();
//    return myapp.applyChanges().then(function () {
//        window.alert("XÓA THÀNH CÔNG !");
//        //myapp.showAddEditChonMon11();
//    });
//};
myapp.AddEditChonMon11.XÓA_execute = function (screen) {
    // Write code here.
    screen.ChonMonChiTiets.deleteSelected();
    return myapp.applyChanges().then(function () {
        window.alert("XÓA THÀNH CÔNG !");
        //myapp.showAddEditChonMon11();
        screen.closePopup();
    });
};
myapp.AddEditChonMon11.SỬA_execute = function (screen) {
    // Write code here.
        return myapp.applyChanges().then(function () {
        window.alert("SỬA THÀNH CÔNG !");
        screen.closePopup();
    });
};

myapp.AddEditChonMon11.Details_postRender = function (element, contentItem) {
    // Write code here.
    //$("[data-ls-tap='tap:{data.shell.discardCommand.command}']").hide();
    $("[data-ls-tap='tap:{data.shell.saveCommand.command}']").hide();
    //$("[data-ls-tap='tap:{data.shell.okCommand.command}']").hide();
    //$("[data-ls-tap='tap:{data.shell.cancelCommand.command}']").hide();
    };
//myapp.AddEditChonMon11.Số_lượng_postRender = function (element, contentItem) {
//    // Write code here.
//    myapp.ChonMonChiTiet1.selectedItem.setSoLuong()
//};
myapp.AddEditChonMon11.Bàn_Tap_execute = function (screen) {
    // Write code here.
   
};
myapp.AddEditChonMon11.Bàn_Tap1_execute = function (screen) {
    
};
myapp.AddEditChonMon11.Ban_ItemTap_execute = function (screen) {
    // Write code here.
    // Write code here.
    var BanSet = screen.findContentItem("Ban");
    // Get the selected item in the list
    var Ban = BanSet.value.selectedItem;
    // update Region for the Incident 
    screen.ChonMon1.setBànItem(Ban);
    //Close the Popup 
    screen.closePopup();
};