
var productController = function (item) {
    var self = this;

    const baseUrl = "/api/ProductApi";

    self.Products = ko.observableArray([]);
    self.selectedProduct = ko.observable(new productModel());

    self.NewProduct = ko.observable(new productModel());
    self.isupdated = ko.observable(false);
    self.isEditing = ko.observable(false);


    self.getData = function () 

    {
        var url = baseUrl;
        console.log("Fetching data from URL: " + url);

        ajax.get(url).then(function (data) {
            console.log("Data received: ", data);
            //self.Products(data);

            var mappedProducts = ko.utils.arrayMap(data, (item) => {
                return new productModel(item);
            })
            self.Products(mappedProducts);
            console.log(self.Products());
        })
    };


    self.getData();


    //Add Product
    self.AddProduct = function () {
        if (self.isEditing()) {
            self.EditProduct(); // Call the EditProduct function if in edit mode
        }
        else {
            ajax.post(baseUrl + "/Add", ko.toJSON(self.NewProduct())).done(function (result) {
                console.log(result);
                self.Products.push(new productModel(result));
                self.resetForm();

                location.reload();
            })
        }
    };

    //Edit Product
    self.EditProduct = function () {
        ajax.put(baseUrl + "/" + self.NewProduct().id(), ko.toJSON(self.NewProduct())).done(function (result) {
            console.log(result);
            self.Products.replace(self.selectedProduct(), new productModel(result));
            self.resetForm();

            location.reload();
        });
    };

    //Delete Product

    self.DeleteProduct = function (model) {
        ajax.delete(baseUrl + "?id=" + model.id()).done((result) => {
            self.Products.remove(model);
        })
    };




    self.selectProduct = (model) =>
    {
        self.selectedProduct(model);
        self.NewProduct(new productModel(ko.toJS(model)));
        self.isupdated(true);
        self.isEditing(true);
    };

    self.resetForm = function () {
        self.NewProduct(new productModel());
        self.isupdated(false);
        self.isEditing(false); // Reset editing mode to false
    };

}


var ajax = {
    get: function (url) {
        return $.ajax({
            method: "GET",
            url: url,
            async: false,
        });
    },
    post: function (url, data) {
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

    put: function (url, data) {
        return $.ajax({
            headers: {
                'Accept': 'application/json',
                'COntent-Type': 'application/json'
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