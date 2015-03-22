/// <reference path="~/GeneratedArtifacts/viewModel.js" />

myapp.ViewBànItem1.Details_postRender = function (element, contentItem) {
    // Write code here.
    var name = contentItem.screen.BànItem1.details.getModel()[':@SummaryProperty'].property.name;
    contentItem.dataBind("screen.BànItem1." + name, function (value) {
        contentItem.screen.details.displayName = value;
    });
}

