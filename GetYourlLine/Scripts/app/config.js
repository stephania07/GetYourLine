;(function () {
'use strict';
    angular.module("GetYourlLine").config(function ($routeProvider) {
        $routeProvider.when('/', {
            templateUrl: 'Scripts/app/view/home.html',
            controller: 'HomeController',
           // controllerAs: 'customerCtrl'

        })
    });
})();