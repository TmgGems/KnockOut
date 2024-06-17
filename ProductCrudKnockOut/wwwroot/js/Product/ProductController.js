
var productController = function (item) {
    var self = this;

    const baseUrl = "/api/ProductApi";

    self.Products = ko.observableArray([]);

    self.NewProduct = ko.observable(new productModel());

    self.getData = function () {
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


}

var ajax = {
    get: function (url) {
        return $.ajax({
            method: "GET",
            url: url,
            async: false,
        });
    }
};