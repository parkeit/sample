(function () {
	'use strict';

	angular
        .module('sampleParks.home', [
			'ui.router'
        ])
		.config(HomeConfig)
	;

    function HomeConfig($stateProvider) {
        $stateProvider.state('home', {
            url: '/',
            controller: 'HomeCtrl',
            controllerAs: 'vm',
            templateUrl: 'Src/home/home.tpl.html',
            resolve: {
                parks: function (HomeSrvc) {
                    return HomeSrvc.getParks();
                },
                amenities: function (HomeSrvc) {
                    return HomeSrvc.getTags();
                }
            }
        });
    }
})();