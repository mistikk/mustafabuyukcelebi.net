(function () {
    'use strict';

    angular
        .module('app', ['ngRoute'])
        .controller('controller', controller);

    controller.$inject = ['$scope']; 

    function controller($scope) {
        $scope.title = 'MİSTİK';

        activate();

        function activate() { }
    }
})();
