(function() {
    "use strict";

    angular
       .module('sampleParks.home')
       .factory('HomeSrvc', HomeSrvc);

    function HomeSrvc($http) {
        var homeService = {
            getParks: getParks,
            getTags : getTags
        }

        return homeService;

        function getParks() {
            return $http.get('/api/parks', {cache:true});
        }

        function getTags() {
            return $http.get('/api/tags', {cache:true});
        }
    }
})();