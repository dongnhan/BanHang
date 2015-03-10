/// <reference path="~/GeneratedArtifacts/viewModel.js" />

myapp.ViewMónItem.Details_postRender = function (element, contentItem) {
    // Write code here.
    var name = contentItem.screen.MónItem.details.getModel()[':@SummaryProperty'].property.name;
    contentItem.dataBind("screen.MónItem." + name, function (value) {
        contentItem.screen.details.displayName = value;
    });
}

