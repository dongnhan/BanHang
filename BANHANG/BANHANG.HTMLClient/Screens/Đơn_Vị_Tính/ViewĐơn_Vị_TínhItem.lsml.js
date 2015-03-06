/// <reference path="~/GeneratedArtifacts/viewModel.js" />

myapp.ViewĐơn_Vị_TínhItem.Details_postRender = function (element, contentItem) {
    // Write code here.
    var name = contentItem.screen.Đơn_Vị_TínhItem.details.getModel()[':@SummaryProperty'].property.name;
    contentItem.dataBind("screen.Đơn_Vị_TínhItem." + name, function (value) {
        contentItem.screen.details.displayName = value;
    });
}

