/// <reference path="knockout.js" />

var companyModel = function (item)
{
    var self = this;
    var item = item || {};
    self.companyName = item.companyName || '';
    self.productManufactured = item.productManufactured || '';
    self.companyEstd = item.companyEstd || '';
    self.companyPhNo = item.companyPhNo || '';
}

