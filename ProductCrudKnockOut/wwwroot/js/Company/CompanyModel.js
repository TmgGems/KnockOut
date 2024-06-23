/// <reference path="knockout.js" />

var companyModel = function (item)
{
    var self = this;
    var item = item || {};
    self.id = item.id || 0;
    self.companyName = item.companyName || '';
    self.productId = item.productId || '';
    self.productManufactured = item.productManufactured || '';
    self.companyEstd = item.companyEstd || '';
    self.companyPhNo = item.companyPhNo || '';
}

var productVM = function (item)
{
    var self = this;
    var item = item || {};
    self.productId = item.productId || 0;
    self.productName = item.productName || '';
}