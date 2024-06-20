var companyController = function (item)
{
    var self = this;

    const baseUrl = "/api/CompanyApi";
    self.Companies = ko.observableArray([]);


    //Get Data
    self.getData = function ()
    {
        var url = baseUrl + "/GetCompanieesWithProducts";
        console.log("Fetching data from URL: " + url);

        ajax.get(url).then(function (data) {
            console.log("Data received: ", data);
            //self.Products(data);

            var mappedCompanies = ko.utils.arrayMap(data, (item) => {
                return new companyModel(item);
            })
            self.Companies(mappedCompanies);
            console.log(self.Companies());
        })
    };

    self.getData();
}

var ajax =
{
    get: function (url) {
        return $.ajax({
            method: "GET",
            url: url,
            async: false,
        });
    }
};