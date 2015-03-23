/// <reference path="~/GeneratedArtifacts/viewModel.js" />

myapp.ViewChonMon11.Details_postRender = function (element, contentItem) {
    // Write code here.
    var name = contentItem.screen.ChonMon1.details.getModel()[':@SummaryProperty'].property.name;
    contentItem.dataBind("screen.ChonMon1." + name, function (value) {
        contentItem.screen.details.displayName = value;
    });
}

