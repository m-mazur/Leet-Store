require.config({
    paths: {
        jquery: '../bower_components/jquery/dist/jquery',
        knockout: '../bower_components/knockout/dist/knockout',
        productService: '../src/product.service',
        viewmodel: '../src/viewmodel'
    }
});

require(['knockout', 'viewmodel'], function (ko, viewmodel) {
    ko.applyBindings(viewmodel);
});