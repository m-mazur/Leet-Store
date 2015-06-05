define(['jquery'], function ($) {
	var productUri = '/api/Store';

	function getAllProducts() {
	    return $.getJSON(productUri);
	};

	function addNewProduct() {

	};

	function ajaxHelper (uri, method, data) {
	    return $.ajax({
	        type: method,
	        url: uri,
	        dataType: 'json',
	        contentType: 'application/json',
	        data: data ? JSON.stringify(data) : null
	    });
	};

	return {
	    getAllProducts: getAllProducts,
	    addNewProduct: addNewProduct
	}
});