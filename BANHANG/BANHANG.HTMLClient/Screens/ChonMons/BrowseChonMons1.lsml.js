/// <reference path="~/GeneratedArtifacts/viewModel.js" />

myapp.BrowseChonMons1.created = function (screen) {
    // Write code here.
    msls.promiseOperation(CallGetUserName).then(function PromiseSuccess(PromiseResult) {
        // Set the result of the CallGetUserName function to the 
        // UserName of the entity
        screen.ChonMon1.UserName = PromiseResult;
        
    });
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