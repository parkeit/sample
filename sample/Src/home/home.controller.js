(function () {
    'use strict';

    angular
        .module('sampleParks.home')
        .controller('HomeCtrl', HomeCtrl);

    function HomeCtrl(parks, amenities) {
        var vm = this;

        vm.parks = parks.data;
        vm.tags = amenities.data;
        vm.selectedAmenities = [];
        vm.amenityFilter = amenityFilter;
        vm.changeSelectedAmenities = changeSelectedAmenities;

        activate();

        function activate() {
        }

        function changeSelectedAmenities(amenity) {
            var exists = vm.selectedAmenities.indexOf(amenity);
            if (exists !== -1) {
                vm.selectedAmenities.splice(exists, 1);
            } else {
                vm.selectedAmenities.push(amenity);
            }
        }

        function amenityFilter(park) {
            if (vm.selectedAmenities.length > 0) {
                for (var i = 0; i < vm.selectedAmenities.length; i++) {
                    var exists = _.find(park.Tags, { Id: vm.selectedAmenities[i] });
                    if (exists == undefined) {
                        return;
                    }
                }
            }
            return park;
        }
    }

})();