define(['jquery'], function ($) {
	var productUri = '/api/Store';

	function getAllProducts() {
		return $.getJSON(productUri);
	}

	return {
		getAllProducts: getAllProducts
	}
});