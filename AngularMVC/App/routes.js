(function () {
    'use strict';

    /////////////////////////////////////////////////////
    // Angular Config
    /////////////////////////////////////////////////////
    angular
        .module('boilerplate')
        .config(RouteConfiguration);

    /////////////////////////////////////////////////////
    // States
    /////////////////////////////////////////////////////
    var dashboardState = {
        url: '/',
        templateUrl: '/Home/Dashboard',
        controller: 'dashboardController',
        controllerAs: 'dashboardCtrl'
    };

    var nakamaState = {
        url: '/nakama',
        templateUrl: '/Home/Nakama',
        controller: 'nakamaController',
        controllerAs: 'nakamaCtrl'
    };

    /////////////////////////////////////////////////////
    // Routing & States Configuration
    /////////////////////////////////////////////////////
    RouteConfiguration.$inject = ['$stateProvider', '$locationProvider'];
    function RouteConfiguration($stateProvider, $locationProvider) {
        // Setup the routes, whenever you add new views and controllers, you'll need to assign the routes here 
        $stateProvider
            .state('dashboard', dashboardState)
            .state('nakama', nakamaState);

        $locationProvider.hashPrefix('');
    }
})();