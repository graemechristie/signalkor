/// <reference path="jquery-1.6.4-vsdoc.js" />
/// <reference path="knockout.debug.js" />
/// <reference path="jquery-ui-1.8.19.js" />


ko.bindingHandlers.draggable = {
    init: function (element, valueAccessor, allBindingsAccessor, viewModel, bindingContext) {
        var value = ko.utils.unwrapObservable(valueAccessor());
        $(element).draggable(value);
    }
};