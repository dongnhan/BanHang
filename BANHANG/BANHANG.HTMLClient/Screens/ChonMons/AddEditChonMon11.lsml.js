/// <reference path="~/GeneratedArtifacts/viewModel.js" />

myapp.AddEditChonMon11.created = function (screen) {
    // Write code here.
    screen.ChonMon1.Ngày = new Date();
    screen.ChonMon1.Ngày_thực = new Date();
    screen.ChonMon1.Đã_xóa = 0;
    screen.ChonMon1.Trạng_thái = 0;
    screen.ChonMon1.Giảm_giá = 0
    screen.ChonMon1.In_phiếu = 0;
    
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
    //screen.ChonMons.Tiền_giảm = screen.ChonMons.Tiền_giảm - 0;
};