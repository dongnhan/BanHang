/// <reference path="~/GeneratedArtifacts/viewModel.js" />

myapp.AddEditChonMon11.created = function (screen) {
    // Write code here.
    //entity.OrderDate = new Date();
    // Using a Promise object we can call the CallGetUserName function
    screen.ChonMon1.Đã_xóa = 0
    screen.ChonMon1.Trạng_thái = 0
    screen.ChonMon1.In_phiếu = 0
    msls.promiseOperation(CallGetUserName).then(function PromiseSuccess(PromiseResult) {
        // Set the result of the CallGetUserName function to the 
        // UserName of the entity
        entity.UserName = PromiseResult;
    });
};

// This function will be wrapped in a Promise object
function CallGetUserName(operation) {
    $.ajax({
        type: 'post',
        data: {},
        url: '../web/GetUserName.ashx',
        success: operation.code(function AjaxSuccess(AjaxResult) {
            operation.complete(AjaxResult);
        })
    });
};