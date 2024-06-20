/// <reference path="knockout.js" />

var companyModel = function (item)
{
    var self = this;
    var item = item || {};
    self.companyName = item.companyName || '';
    self.companyEstd = item.companyEstd || '';
    self.companyPhNo = item.companyPhNo || '';
    self.productId = item.productId || 0;
    self.product = item.product || '';
}