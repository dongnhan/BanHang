/// <reference path="~/GeneratedArtifacts/viewModel.js" />

myapp.ViewMónItem1.Details_postRender = function (element, contentItem) {
    // Write code here.
    var name = contentItem.screen.MónItem1.details.getModel()[':@SummaryProperty'].property.name;
    contentItem.dataBind("screen.MónItem1." + name, function (value) {
        contentItem.screen.details.displayName = value;
    });
}

