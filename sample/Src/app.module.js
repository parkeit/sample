(function() {
    'use strict';

    angular
        .module('sampleParks', [
            /* Application modules*/
            'sampleParks.home',

            /* Third party modules */
          //'angulartics',
          //'angulartics.google.analytics',
          //'angular.filter',
          //'angular-loading-bar',
          //'angularMoment',
          //'angular-storage',
          //'ngAria',
          //'ngSanitize',
          'ui.bootstrap',
          'ui.router'
          //'ui.scrollfix',
          //'ngAnimate',
          //'toastr'

        ])
        .config(ConfigFunction)
    ;

    function ConfigFunction($urlRouterProvider, $httpProvider, $provide) {
        
        $urlRouterProvider.otherwise('/');
    }
})();