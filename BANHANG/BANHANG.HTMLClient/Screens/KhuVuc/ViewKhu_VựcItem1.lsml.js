/// <reference path="~/GeneratedArtifacts/viewModel.js" />

myapp.ViewKhu_VựcItem1.Details_postRender = function (element, contentItem) {
    // Write code here.
    var name = contentItem.screen.Khu_VựcItem1.details.getModel()[':@SummaryProperty'].property.name;
    contentItem.dataBind("screen.Khu_VựcItem1." + name, function (value) {
        contentItem.screen.details.displayName = value;
    });
}

