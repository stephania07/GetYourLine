; (function () {
    'use strict';
    angular.module('GetYourlLine')
    .controller('HomeController', function ($scope, $http) {
        var vm = this;
        $scope.Customers = {};
        $http.get('../Api')
       .success(function (data) {
           $scope.Customers = data;
       })
    });
})();