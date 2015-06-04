define(function (require, exports, module) {
    var ko = require('knockout'),
        productService = require('productService');

    var viewmodel = function (ko, productService) {
        var self = this;

        self.products = ko.observableArray();

        productService.getAllProducts().done(function (data) {
            console.log(data);
            self.products(data);
        });
    }
    
    exports.viewmodel = viewmodel(ko, productService);
});