/// <reference path="../knockout.js" />


var customerModel = function (item)
{

    var self = this;
    var item = item || {};
    self.id = item.id || 0;
    self.customerName = item.customerName || '';
    self.customerAddress = item.customerAddress || '';
    self.gender = item.gender || '';
    self.companyId = item.companyId || 0;
    self.companyName = item.companyName || '';
    self.productId = item.productId || 0;
    self.productName = item.productName || '';
}

var productVM = function (item)
{
    var self = this;
    var item = item || {};
    self.productId = item.productId || 0;
    self.productName = item.productName || '';
}

var companyVM = function (item)
{
    var self = this;
    var item = item || {};
    self.companyId = item.companyId || 0;
    self.companyName = item.companyName || '';
}