/// <reference path="~/GeneratedArtifacts/viewModel.js" />


myapp.AddEditMónItem1.THÊM_ĐỊNH_LƯỢNG_postRender = function (element, contentItem) {
    // Write code here.
   
};
myapp.AddEditMónItem1.THÊM_ĐỊNH_LƯỢNG_execute = function (screen) {
    // Write code here.
    $(window).one("popupbeforeposition", function (e) {
        $(e.target).popup({
            positionTo: "window"
        });
    });
    // Show the Popup
    screen.showPopup("Group");
    var newChiTiet = screen.MonDinhLuongs.addNew();
};
myapp.AddEditMónItem1.THÊM_ĐÓNG_execute = function (screen) {
    // Write code here.
    screen.closePopup();
};
myapp.AddEditMónItem1.SỬA_execute = function (screen) {
    // Write code here.
    return myapp.applyChanges().then(function () {
        window.alert("SỬA THÀNH CÔNG !");
        screen.closePopup();
    });
};
myapp.AddEditMónItem1.Details_postRender = function (element, contentItem) {
    // Write code here.
    $("[data-ls-tap='tap:{data.shell.saveCommand.command}']").hide();
};
myapp.AddEditMónItem1.XÓA_execute = function (screen) {
    // Write code here.
    screen.MonDinhLuongs.deleteSelected();
    return myapp.applyChanges().then(function () {
        window.alert("XÓA THÀNH CÔNG !");
        //myapp.showAddEditChonMon11();
        screen.closePopup();
    });
};
myapp.AddEditMónItem1.LƯU_execute = function (screen) {
    // Write code here.
    return myapp.applyChanges().then(function () {
        window.alert("LƯU THÀNH CÔNG !");
        //myapp.showAddEditChonMon11();
       });
};