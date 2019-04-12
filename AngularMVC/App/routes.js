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

    /////////////////////////////////////////////////////
    // Routing & States Configuration
    /////////////////////////////////////////////////////
    RouteConfiguration.$inject = ['$stateProvider', '$locationProvider'];
    function RouteConfiguration($stateProvider, $locationProvider) {
        // Setup the routes, whenever you add new views and controllers, you'll need to assign the routes here 
        $stateProvider
            .state('dashboard', dashboardState);

        $locationProvider.hashPrefix('');
    }
})();