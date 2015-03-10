/// <reference path="~/GeneratedArtifacts/viewModel.js" />
myapp.BrowseChonMons.Món_postRender = function (element, contentItem) {
    // Write code here.
    lsWire.list.enableMultiSelect(contentItem);
};

myapp.BrowseChonMons.THÊM_execute = function (screen) {
    var list = screen.findContentItem("Món");
       lsWire.list.selectAll(list, false);
    // Write code here.
    var newDK = new myapp.ChonMon();
    // Set the Status
    newDK.Ngày = new Date;
    screen.ChonMons.selectedItem = screen.ChonMons.data[0];
    
};
myapp.BrowseChonMons.CHỌN_execute = function (screen) {
    // Write code here.
    var list = screen.findContentItem("Món");

    //var count = lsWire.list.selectedCount(list);

    var selected = lsWire.list.selected(list);

    //var text = "Món bạn đã chọn gồm \n\n";

    _.forEach(selected, function (item) {

        //text += item.Mã + " - " + item.Tên + "\n";
        var newChiTiet = new myapp.ChonMonChiTiet();
        newChiTiet.setMónItem(item);
        newChiTiet.Số_lượng = 1;
        //        var myEntity = screen.details.dataWorkspace.QuanLyXetNghiemData.DinhDanhs_SingleOrDefault(item.Id)

        //.execute().then(function (data) {

        //    myEntity = data;
        //    newChiTiet.setDinhDanh(myEntity);

        //})

        //    });

    });
    

    //text += "Số món : " + count;

    //window.alert(text);
};
myapp.BrowseChonMons.LƯU_execute = function (screen) {
    // Write code here.
    //var list = screen.findContentItem("Món");

    ////var count = lsWire.list.selectedCount(list);

    //var selected = lsWire.list.selected(list);

    ////var text = "Món đã chọn\n\n";

    //_.forEach(selected, function (item) {

    //    //text += item.Mã + " - " + item.Tên + "\n";
    //    var newChiTiet = new myapp.ChonMonChiTiet();
    //    newChiTiet.setMónItem(item);
    //    newChiTiet.Số_lượng = 1;
    //    //        var myEntity = screen.details.dataWorkspace.QuanLyXetNghiemData.DinhDanhs_SingleOrDefault(item.Id)

    //    //.execute().then(function (data) {

    //    //    myEntity = data;
    //    //    newChiTiet.setDinhDanh(myEntity);

    //    //})

    //    //    });

    //});

    return myapp.activeDataWorkspace.BanHangData
      .saveChanges().then(function () {
          // Refresh the Customers
          //screen.ChonMons.refresh();
          screen.ChonMons.selectedItem = screen.ChonMons.data[0];
          screen.Chọn_Món_Chi_Tiết.refresh();
          var list = screen.findContentItem("Món");
          lsWire.list.selectAll(list, false);
          window.alert("LƯU THÀNH CÔNG !");
          //window.location.reload();
          
          //screen.getChọn_Món_Chi_Tiết();
          
      });
};


myapp.BrowseChonMons.THÊM_MÓN_execute = function (screen) {
    // Write code here.
    var list = screen.findContentItem("Món");

    //var count = lsWire.list.selectedCount(list);

    var selected = lsWire.list.selected(list);

    //var text = "Món bạn đã chọn gồm \n\n";

    _.forEach(selected, function (item) {

        //text += item.Mã + " - " + item.Tên + "\n";
        var newChiTiet = screen.Chọn_Món_Chi_Tiết.addNew();
        newChiTiet.setMónItem(item);
        newChiTiet.Số_lượng = 1;
        //newChiTiet.setChonMon()
        //        var myEntity = screen.details.dataWorkspace.QuanLyXetNghiemData.DinhDanhs_SingleOrDefault(item.Id)

        //.execute().then(function (data) {

        //    myEntity = data;
        //    newChiTiet.setDinhDanh(myEntity);

        //})

        //    });

    });
    //return myapp.activeDataWorkspace.BanHangData
    //      .saveChanges().then(function () {
    //          // Refresh the Customers
    //          //screen.ChonMons.refresh();
    //          //screen.ChonMons.selectedItem = screen.ChonMons.data[0];
    //          screen.Chọn_Món_Chi_Tiết.refresh();
    //          var list = screen.findContentItem("Món");
    //          lsWire.list.selectAll(list, false);
    //          window.alert("THÊM MÓN THÀNH CÔNG !");
    //          //window.location.reload();

    //          //screen.getChọn_Món_Chi_Tiết();

    //      });

    //text += "Số món : " + count;

    //window.alert(text);
};
myapp.BrowseChonMons.XÓA_MÓN_execute = function (screen) {
    screen.Chọn_Món_Chi_Tiết.deleteSelected();
    return myapp.activeDataWorkspace.BanHangData
     .saveChanges().then(function () {
         // Refresh the Customers
         //screen.ChonMons.refresh();
         //screen.ChonMons.selectedItem = screen.ChonMons.data[0];
         //screen.Chọn_Món_Chi_Tiết.refresh();
         //var list = screen.findContentItem("Món");
         //lsWire.list.selectAll(list, false);
         window.alert("XÓA THÀNH CÔNG !");
         //window.location.reload();

         //screen.getChọn_Món_Chi_Tiết();

     });

    //return myapp.commitChanges().then(null, function fail(e) {

    //    myapp.cancelChanges();

    //    throw e;

   // });
    // Write code here.
    ////screen.Chọn_Món_Chi_Tiết.deleteSelected();

    // Save changes
   // myapp.commitChanges().then(function success() {
        // If success.
        //msls.showMessageBox("Xóa thành công !!!", { title: "XÓA" });
        //}, function fail(e) {
        //    // If error occurs,
        //    msls.showMessageBox(e.message, { title: e.title }).then(function () {
        //        // Cancel Changes
        //        myapp.cancelChanges();
        //    });
        //});
   // };
}
myapp.BrowseChonMons.XÓA_NHÓM_execute = function (screen) {
    // Write code here.
    screen.setNhóm(null);
};