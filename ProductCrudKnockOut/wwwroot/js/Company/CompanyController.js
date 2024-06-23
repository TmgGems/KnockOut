/// <reference path="companymodel.js" />

var companyController = function (item) {
    var self = this;

    const baseUrl = "/api/CompanyApi";
    self.Companies = ko.observableArray([]);


    self.Products = ko.observableArray([]);

    self.SelectedCompany = ko.observable(new companyModel());
    self.NewCompany = ko.observable(new companyModel());
    self.isEditing = ko.observable(false);
    self.isupdated = ko.observable(false);

    //Get Data
    self.getData = function () {
        var url = baseUrl + "/GetCompanieesWithProducts";
        console.log("Fetching data from URL: " + url);

        ajax.get(url).then(function (data) {
            console.log("Data received: ", data);
            
            var mappedCompanies = ko.utils.arrayMap(data, (item) => {
                return new companyModel(item);
            })
            self.Companies(mappedCompanies);
            console.log(self.Companies());
        })
    };

    self.getData();

    //Fetch Products
    self.getProducts = function () {
        var url = baseUrl + "/GetProductsVM"; 
        console.log("Fetching products from URL: " + url);

        return ajax.get(url).then(function (data) {
           // console.log("Products received: ", data);
            var mappedProducts = ko.utils.arrayMap(data, (item) => {
                return new productVM(item);
            });
            self.Products(mappedProducts);
            console.log("Products Data: ", self.Products());
        }).fail(function (jqXHR, textStatus, errorThrown) {
            console.error("Error fetching products: ", textStatus, errorThrown);
        });
    };

   // self.getProducts();

    //Add Company


    self.AddCompany = function ()
    {
        if (self.isEditing()) {
            self.EditCompany();
        }
        else {
            var url = baseUrl + "/Add"
            console.log("Fetching Add Url  :", url);
            ajax.post(url, ko.toJSON(self.NewCompany())).done(function (result) {
                console.log(result);
                self.Companies.push(new companyModel(result));
                console.log("Company ma :", self.Companies());
                self.getData();
                self.resetForm();
                //location.reload();
            })
        }
    };

 

    //Edit Cpmpany
    self.EditCompany = function () {
        ajax.put(baseUrl + "/Updates" , ko.toJSON(self.NewCompany())).done(function (result) {
            console.log(result);
            self.Companies.replace(self.SelectedCompany(), new companyModel(result));
            self.getData();
            self.resetForm();
           // location.reload();
        });
    };

    //Delete Company

    //Delete Product

    self.DeleteCompany = function (model) {
        var companyId = ko.toJS(model).id;
        ajax.delete(baseUrl + "/Delete?id=" + companyId).done((result) => {
            self.Companies.remove(model);
        })
    };

    self.selectCompany = (model) => {
        self.getProducts().then(function () {
            self.SelectedCompany(model);
            self.NewCompany(new companyModel(ko.toJS(model)));
            self.isupdated(true);
            self.isEditing(true);
        });
    };

    self.resetForm = function () {
        self.NewCompany(new companyModel());
        self.isupdated(false); 
        self.isEditing(false);
    };
};


var ajax =
{
    get: function (url) {
        return $.ajax({
            method: "GET",
            url: url,
            async: false,
        });
    },
    post: function (url, data)
    {
        return $.ajax({
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            method: "POST",
            url: url,
            data: (data)
        })
    },

    put: function (url, data)
    {
        return $.ajax({
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            method: "PUT",
            url: url,
            data: data
        });
    },
    delete: function (route) {
        return $.ajax({
            method: "DELETE",
            url: route,
        });
    }
};