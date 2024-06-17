/// <reference path="../knockout.js" />

var productModel = function (item)
{
    var self = this;
    item = item || {};
    self.id = ko.observable(item.id || 0);
    self.name = ko.observable(item.name || '');
    self.quantity = ko.observable(item.quantity || 0);
    self.company = ko.observable(item.company || '');
    self.manufacturedDate = ko.observable(item.manufacturedDate || '');
    self.expiryDate = ko.observable(item.expiryDate || '');
    self.order = ko.observable(item.order || '');
}