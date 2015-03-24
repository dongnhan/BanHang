/// <reference path="~/GeneratedArtifacts/viewModel.js" />

myapp.ViewChonMonChiTiet1.Details_postRender = function (element, contentItem) {
    // Write code here.
    var name = contentItem.screen.ChonMonChiTiet1.details.getModel()[':@SummaryProperty'].property.name;
    contentItem.dataBind("screen.ChonMonChiTiet1." + name, function (value) {
        contentItem.screen.details.displayName = value;
    });
}

